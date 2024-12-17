using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DEKTL2_HOME
{
   
    public partial class QuanLyMonHoc : Form
    {
        enum Loai
        {
            All,
            rd2015,
            rd2017,
            rd2020
        }
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc(Loai.All);
        }

        private void LoadMonHoc(Loai loai)
        {
            string connectionString = "server = DESKTOP-S2LH4GM\\SQLEXPRESS ; database = QLDKHP2 ; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT mh.MaMH, TenMH, TenCTDT, SoTC FROM MonHoc mh, ChuongTrinhDT ctdt WHERE mh.MaCTĐT = ctdt.MaCTDT";
            if (rd2015.Checked)
            {
                cmd.CommandText += " AND ctdt.MaCTDT = 1 ";
            }
            if (loai == Loai.rd2017)
                cmd.CommandText += " AND TenCTDT = N'Chương trình đào tạo 2017'";
            if (rd2020.Checked)
                cmd.CommandText += " AND TenCTDT = N'Chương trình đào tạo 2020'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            dtgvDSMH.DataSource = dt;

        }

        private void rd2015_CheckedChanged(object sender, EventArgs e)
        {
            LoadMonHoc(Loai.All);
        }

        private void rd2017_CheckedChanged(object sender, EventArgs e)
        {
            LoadMonHoc(Loai.rd2017);
        }

        private void rd2020_CheckedChanged(object sender, EventArgs e)
        {
            LoadMonHoc(Loai.rd2020);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMonHoc mh = new frmMonHoc();
            mh.Show(this);
            mh.FormClosed += new FormClosedEventHandler(frmMH_Closing);
           
        }

        private void dtgvDSMH_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvDSMH.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvDSMH.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                frmMonHoc mh = new frmMonHoc();
                mh.Show(this);
                mh.DisplaySubjectInfo(rowView);
                mh.FormClosed += new FormClosedEventHandler(frmMH_Closing);
            }
        }
        void frmMH_Closing(object sender, FormClosedEventArgs e)
        {
            LoadMonHoc(Loai.All);
        }

        private void tsmCaclSUM_Click(object sender, EventArgs e)
        {
            string connectionString = "server = DESKTOP-S2LH4GM\\SQLEXPRESS ; database = QLDKHP2 ; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select @Tong= Count(MaSV) from Hoc hoc where hoc.MaMH = @MaMH";
            if (dtgvDSMH.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvDSMH.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                cmd.Parameters.Add("@MaMH", SqlDbType.NChar,10);
                cmd.Parameters["@MaMH"].Value = rowView["MaMH"];

                cmd.Parameters.Add("@Tong", SqlDbType.Int);
                cmd.Parameters["@Tong"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();

                string result = cmd.Parameters["@Tong"].Value.ToString();
                MessageBox.Show("Tổng SL HSDK Môn Học " + rowView["TenMH"] + " là : " + result);

                conn.Close();

            }
            cmd.Dispose();
            conn.Dispose();
        }
    }
}
