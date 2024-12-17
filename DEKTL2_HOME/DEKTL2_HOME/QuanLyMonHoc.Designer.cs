namespace DEKTL2_HOME
{
    partial class QuanLyMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd2020 = new System.Windows.Forms.RadioButton();
            this.rd2017 = new System.Windows.Forms.RadioButton();
            this.rd2015 = new System.Windows.Forms.RadioButton();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdSoTC = new System.Windows.Forms.RadioButton();
            this.rdMaTenMH = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvDSMH = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCaclSUM = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd2020);
            this.groupBox1.Controls.Add(this.rd2017);
            this.groupBox1.Controls.Add(this.rd2015);
            this.groupBox1.Controls.Add(this.rdAll);
            this.groupBox1.Location = new System.Drawing.Point(91, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chương trình đào tạo";
            // 
            // rd2020
            // 
            this.rd2020.AutoSize = true;
            this.rd2020.Location = new System.Drawing.Point(495, 36);
            this.rd2020.Name = "rd2020";
            this.rd2020.Size = new System.Drawing.Size(61, 21);
            this.rd2020.TabIndex = 3;
            this.rd2020.TabStop = true;
            this.rd2020.Text = "2020";
            this.rd2020.UseVisualStyleBackColor = true;
            this.rd2020.CheckedChanged += new System.EventHandler(this.rd2020_CheckedChanged);
            // 
            // rd2017
            // 
            this.rd2017.AutoSize = true;
            this.rd2017.Location = new System.Drawing.Point(341, 36);
            this.rd2017.Name = "rd2017";
            this.rd2017.Size = new System.Drawing.Size(61, 21);
            this.rd2017.TabIndex = 2;
            this.rd2017.TabStop = true;
            this.rd2017.Text = "2017";
            this.rd2017.UseVisualStyleBackColor = true;
            this.rd2017.CheckedChanged += new System.EventHandler(this.rd2017_CheckedChanged);
            // 
            // rd2015
            // 
            this.rd2015.AutoSize = true;
            this.rd2015.Location = new System.Drawing.Point(175, 36);
            this.rd2015.Name = "rd2015";
            this.rd2015.Size = new System.Drawing.Size(61, 21);
            this.rd2015.TabIndex = 1;
            this.rd2015.TabStop = true;
            this.rd2015.Text = "2015";
            this.rd2015.UseVisualStyleBackColor = true;
            this.rd2015.CheckedChanged += new System.EventHandler(this.rd2015_CheckedChanged);
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(35, 36);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(69, 21);
            this.rdAll.TabIndex = 0;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Tất cả";
            this.rdAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.rdSoTC);
            this.groupBox2.Controls.Add(this.rdMaTenMH);
            this.groupBox2.Location = new System.Drawing.Point(91, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(295, 33);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(299, 22);
            this.txtTimKiem.TabIndex = 2;
            // 
            // rdSoTC
            // 
            this.rdSoTC.AutoSize = true;
            this.rdSoTC.Location = new System.Drawing.Point(162, 34);
            this.rdSoTC.Name = "rdSoTC";
            this.rdSoTC.Size = new System.Drawing.Size(103, 21);
            this.rdSoTC.TabIndex = 1;
            this.rdSoTC.Text = "Theo số TC";
            this.rdSoTC.UseVisualStyleBackColor = true;
            // 
            // rdMaTenMH
            // 
            this.rdMaTenMH.AutoSize = true;
            this.rdMaTenMH.Checked = true;
            this.rdMaTenMH.Location = new System.Drawing.Point(10, 34);
            this.rdMaTenMH.Name = "rdMaTenMH";
            this.rdMaTenMH.Size = new System.Drawing.Size(134, 21);
            this.rdMaTenMH.TabIndex = 0;
            this.rdMaTenMH.TabStop = true;
            this.rdMaTenMH.Text = "Theo mã/tên MH";
            this.rdMaTenMH.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.dtgvDSMH);
            this.groupBox3.Location = new System.Drawing.Point(12, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 248);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách môn học";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(695, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvDSMH
            // 
            this.dtgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSMH.Location = new System.Drawing.Point(6, 39);
            this.dtgvDSMH.Name = "dtgvDSMH";
            this.dtgvDSMH.RowHeadersWidth = 51;
            this.dtgvDSMH.RowTemplate.Height = 24;
            this.dtgvDSMH.Size = new System.Drawing.Size(764, 209);
            this.dtgvDSMH.TabIndex = 0;
            this.dtgvDSMH.DoubleClick += new System.EventHandler(this.dtgvDSMH_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewStudent,
            this.tsmCaclSUM});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(358, 76);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(357, 24);
            this.tsmDelete.Text = "Xóa";
            // 
            // tsmViewStudent
            // 
            this.tsmViewStudent.Name = "tsmViewStudent";
            this.tsmViewStudent.Size = new System.Drawing.Size(357, 24);
            this.tsmViewStudent.Text = "Xem danh sách sinh viên đăng ký môn học";
            // 
            // tsmCaclSUM
            // 
            this.tsmCaclSUM.Name = "tsmCaclSUM";
            this.tsmCaclSUM.Size = new System.Drawing.Size(357, 24);
            this.tsmCaclSUM.Text = "Tổng số lượng SV đăng ký môn học";
            this.tsmCaclSUM.Click += new System.EventHandler(this.tsmCaclSUM_Click);
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyMonHoc";
            this.Text = "QuanLyMonHoc";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd2020;
        private System.Windows.Forms.RadioButton rd2017;
        private System.Windows.Forms.RadioButton rd2015;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdSoTC;
        private System.Windows.Forms.RadioButton rdMaTenMH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvDSMH;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmViewStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmCaclSUM;
    }
}