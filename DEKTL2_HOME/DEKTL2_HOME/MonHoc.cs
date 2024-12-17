using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace DEKTL2_HOME
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadCTDT();
        }

        private void LoadCTDT()
        {
            string connectionString = "server = DESKTOP-S2LH4GM\\SQLEXPRESS ; database = QLDKHP2 ; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MACTDT, TENCTDT FROM ChuongTrinhDT";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbCTDT.DataSource = dt;
            cbbCTDT.DisplayMember = "TenCTDT";
            cbbCTDT.ValueMember = "MaCTDT";
        }

        public void ResetText()
        {
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            cbbCTDT.ResetText();
            nudSoTC.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text =="")
            {
                ThemMH();
                
            }
            else
            {
                CapNhatMH();
            }

        }

        private void ThemMH()
        {
            try
            {
                string connectionString = "server = DESKTOP-S2LH4GM\\SQLEXPRESS ; database = QLDKHP2 ; Integrated Security = true";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "EXECUTE InsertSubject @mamh output, @tenmh, @sotc, @mactđt";

                cmd.Parameters.Add("@mamh", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sotc", SqlDbType.Int);
                cmd.Parameters.Add("@mactđt", SqlDbType.Int);

                cmd.Parameters["@mamh"].Direction = ParameterDirection.Output;
                //cmd.Parameters["@mamh"].Value = txtTenMH.Text;
                cmd.Parameters["@tenmh"].Value = txtTenMH.Text;
                cmd.Parameters["@sotc"].Value = nudSoTC.Value;
                cmd.Parameters["@mactđt"].Value = cbbCTDT.SelectedValue;

                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    string subjectID = cmd.Parameters["@MaMH"].Value.ToString();
                    DialogResult result = MessageBox.Show("Successfully adding new subject, Subject ID = " + subjectID, "Message", MessageBoxButtons.OK);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Adding subject failed");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "SQL Error");
            }


            //ADD CTDT Int
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "EXECUTE InsertCTDT @mactdt output, @tenctdt, @mota";

            //cmd.Parameters.Add("@mactdt", SqlDbType.Int);
            //cmd.Parameters.Add("@tenctdt", SqlDbType.NVarChar, 50);
            //cmd.Parameters.Add("@mota", SqlDbType.NVarChar, 1000);

            //cmd.Parameters["@mactdt"].Direction = ParameterDirection.Output;
            ////cmd.Parameters["@mamh"].Value = txtTenMH.Text;
            //cmd.Parameters["@tenctdt"].Value = txtTenMH.Text;
            //cmd.Parameters["@mota"].Value = txtTenMH.Text;

            //conn.Open();

            //int numRowAffected = cmd.ExecuteNonQuery();
            //if (numRowAffected > 0)
            //{
            //    string subjectID = cmd.Parameters["@mactdt"].Value.ToString();
            //    MessageBox.Show("Successfully adding new subject, Subject ID = " + subjectID, "Message");

            //    this.ResetText();
            //}
            //else
            //{
            //    MessageBox.Show("Adding subject failed");
            //}
        }

        public void DisplaySubjectInfo(DataRowView rowView)
        {
            try
            {
                txtMaMH.Text = rowView["MaMH"].ToString();
                txtTenMH.Text = rowView["TenMH"].ToString();
                
                nudSoTC.Text = rowView["SoTC"].ToString();

                cbbCTDT.SelectedIndex = -1;
                for (int index = 0; index < cbbCTDT.Items.Count; index++)
                {
                    DataRowView cat = cbbCTDT.Items[index] as DataRowView;
                    if (cat["TenCTDT"].ToString() == rowView["TenCTDT"].ToString())
                    {
                        cbbCTDT.SelectedIndex = index;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }

        public void CapNhatMH()
        {
            try
            {
                string connectionString = "server = DESKTOP-S2LH4GM\\SQLEXPRESS ; database = QLDKHP2 ; Integrated Security = true";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "EXECUTE UpdateSubject @mamh, @tenmh, @sotc, @mactđt";

                cmd.Parameters.Add("@mamh", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tenmh", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@sotc", SqlDbType.Int);
                cmd.Parameters.Add("@mactđt", SqlDbType.Int);


                cmd.Parameters["@mamh"].Value = txtMaMH.Text;
                cmd.Parameters["@tenmh"].Value = txtTenMH.Text;
                cmd.Parameters["@sotc"].Value = nudSoTC.Value;
                cmd.Parameters["@mactđt"].Value = cbbCTDT.SelectedValue;

                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    
                    MessageBox.Show("Successfully updating new subject" , "Message");

                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating subject failed");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "SQL Error");
            }
        }
    }
}
