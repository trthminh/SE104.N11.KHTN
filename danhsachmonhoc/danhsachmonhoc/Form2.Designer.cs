namespace danhsachmonhoc
{
    partial class Form2
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
            this.MaMH = new System.Windows.Forms.Label();
            this.TenMH = new System.Windows.Forms.Label();
            this.SoTiet = new System.Windows.Forms.Label();
            this.LoaiTinChi = new System.Windows.Forms.Label();
            this.MaNganh = new System.Windows.Forms.Label();
            this.MaKhoa = new System.Windows.Forms.Label();
            this.textBox_SoTiet = new System.Windows.Forms.TextBox();
            this.button_suadsmh = new System.Windows.Forms.Button();
            this.button_dongsuadsmh = new System.Windows.Forms.Button();
            this.comboBox_upd_khoa = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_tenmh = new System.Windows.Forms.ComboBox();
            this.comboBox_mamh = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_loaitinchi = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_nganh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MaMH
            // 
            this.MaMH.AutoSize = true;
            this.MaMH.Location = new System.Drawing.Point(58, 46);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(80, 16);
            this.MaMH.TabIndex = 0;
            this.MaMH.Text = "Mã Môn học";
            // 
            // TenMH
            // 
            this.TenMH.AutoSize = true;
            this.TenMH.Location = new System.Drawing.Point(58, 127);
            this.TenMH.Name = "TenMH";
            this.TenMH.Size = new System.Drawing.Size(85, 16);
            this.TenMH.TabIndex = 1;
            this.TenMH.Text = "Tên Môn học";
            // 
            // SoTiet
            // 
            this.SoTiet.AutoSize = true;
            this.SoTiet.Location = new System.Drawing.Point(58, 204);
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.Size = new System.Drawing.Size(50, 16);
            this.SoTiet.TabIndex = 2;
            this.SoTiet.Text = "Số Tiết";
            // 
            // LoaiTinChi
            // 
            this.LoaiTinChi.AutoSize = true;
            this.LoaiTinChi.Location = new System.Drawing.Point(423, 46);
            this.LoaiTinChi.Name = "LoaiTinChi";
            this.LoaiTinChi.Size = new System.Drawing.Size(77, 16);
            this.LoaiTinChi.TabIndex = 3;
            this.LoaiTinChi.Text = "Loại Tín Chỉ";
            // 
            // MaNganh
            // 
            this.MaNganh.AutoSize = true;
            this.MaNganh.Location = new System.Drawing.Point(423, 127);
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.Size = new System.Drawing.Size(69, 16);
            this.MaNganh.TabIndex = 4;
            this.MaNganh.Text = "Mã Ngành";
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSize = true;
            this.MaKhoa.Location = new System.Drawing.Point(423, 204);
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Size = new System.Drawing.Size(60, 16);
            this.MaKhoa.TabIndex = 5;
            this.MaKhoa.Text = "Mã Khoa";
            // 
            // textBox_SoTiet
            // 
            this.textBox_SoTiet.Location = new System.Drawing.Point(164, 198);
            this.textBox_SoTiet.Name = "textBox_SoTiet";
            this.textBox_SoTiet.Size = new System.Drawing.Size(212, 22);
            this.textBox_SoTiet.TabIndex = 8;
            // 
            // button_suadsmh
            // 
            this.button_suadsmh.Location = new System.Drawing.Point(334, 260);
            this.button_suadsmh.Name = "button_suadsmh";
            this.button_suadsmh.Size = new System.Drawing.Size(148, 36);
            this.button_suadsmh.TabIndex = 13;
            this.button_suadsmh.Text = "Sửa";
            this.button_suadsmh.UseVisualStyleBackColor = true;
            this.button_suadsmh.Click += new System.EventHandler(this.button_suadsmh_Click);
            // 
            // button_dongsuadsmh
            // 
            this.button_dongsuadsmh.Location = new System.Drawing.Point(634, 311);
            this.button_dongsuadsmh.Name = "button_dongsuadsmh";
            this.button_dongsuadsmh.Size = new System.Drawing.Size(96, 36);
            this.button_dongsuadsmh.TabIndex = 14;
            this.button_dongsuadsmh.Text = "Đóng";
            this.button_dongsuadsmh.UseVisualStyleBackColor = true;
            this.button_dongsuadsmh.Click += new System.EventHandler(this.button_dongsuadsmh_Click);
            // 
            // comboBox_upd_khoa
            // 
            this.comboBox_upd_khoa.FormattingEnabled = true;
            this.comboBox_upd_khoa.Items.AddRange(new object[] {
            "K001",
            "K002",
            "K003",
            "K004",
            "K005",
            "K006"});
            this.comboBox_upd_khoa.Location = new System.Drawing.Point(534, 198);
            this.comboBox_upd_khoa.Name = "comboBox_upd_khoa";
            this.comboBox_upd_khoa.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_khoa.TabIndex = 16;
            // 
            // comboBox_upd_tenmh
            // 
            this.comboBox_upd_tenmh.FormattingEnabled = true;
            this.comboBox_upd_tenmh.Items.AddRange(new object[] {
            "M1",
            "M2",
            "M3",
            "M4",
            "M5"});
            this.comboBox_upd_tenmh.Location = new System.Drawing.Point(164, 122);
            this.comboBox_upd_tenmh.Name = "comboBox_upd_tenmh";
            this.comboBox_upd_tenmh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_tenmh.TabIndex = 18;
            // 
            // comboBox_mamh
            // 
            this.comboBox_mamh.Enabled = false;
            this.comboBox_mamh.FormattingEnabled = true;
            this.comboBox_mamh.Items.AddRange(new object[] {
            "M001",
            "M002",
            "M003",
            "M004",
            "M005"});
            this.comboBox_mamh.Location = new System.Drawing.Point(164, 38);
            this.comboBox_mamh.Name = "comboBox_mamh";
            this.comboBox_mamh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_mamh.TabIndex = 19;
            // 
            // comboBox_upd_loaitinchi
            // 
            this.comboBox_upd_loaitinchi.FormattingEnabled = true;
            this.comboBox_upd_loaitinchi.Items.AddRange(new object[] {
            "LT",
            "TH"});
            this.comboBox_upd_loaitinchi.Location = new System.Drawing.Point(534, 38);
            this.comboBox_upd_loaitinchi.Name = "comboBox_upd_loaitinchi";
            this.comboBox_upd_loaitinchi.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_loaitinchi.TabIndex = 20;
            // 
            // comboBox_upd_nganh
            // 
            this.comboBox_upd_nganh.FormattingEnabled = true;
            this.comboBox_upd_nganh.Items.AddRange(new object[] {
            "N001",
            "N002",
            "N003",
            "N004",
            "N005",
            "N006",
            "N007",
            "N008",
            "N009",
            "N010",
            "N011",
            "N012"});
            this.comboBox_upd_nganh.Location = new System.Drawing.Point(534, 122);
            this.comboBox_upd_nganh.Name = "comboBox_upd_nganh";
            this.comboBox_upd_nganh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_nganh.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.comboBox_upd_nganh);
            this.Controls.Add(this.comboBox_upd_loaitinchi);
            this.Controls.Add(this.comboBox_mamh);
            this.Controls.Add(this.comboBox_upd_tenmh);
            this.Controls.Add(this.comboBox_upd_khoa);
            this.Controls.Add(this.button_dongsuadsmh);
            this.Controls.Add(this.button_suadsmh);
            this.Controls.Add(this.textBox_SoTiet);
            this.Controls.Add(this.MaKhoa);
            this.Controls.Add(this.MaNganh);
            this.Controls.Add(this.LoaiTinChi);
            this.Controls.Add(this.SoTiet);
            this.Controls.Add(this.TenMH);
            this.Controls.Add(this.MaMH);
            this.Name = "Form2";
            this.Text = "Update danh sách môn học";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaMH;
        private System.Windows.Forms.Label TenMH;
        private System.Windows.Forms.Label SoTiet;
        private System.Windows.Forms.Label LoaiTinChi;
        private System.Windows.Forms.Label MaNganh;
        private System.Windows.Forms.Label MaKhoa;
        private System.Windows.Forms.TextBox textBox_SoTiet;
        private System.Windows.Forms.Button button_suadsmh;
        private System.Windows.Forms.Button button_dongsuadsmh;
        private System.Windows.Forms.ComboBox comboBox_upd_khoa;
        private System.Windows.Forms.ComboBox comboBox_upd_tenmh;
        private System.Windows.Forms.ComboBox comboBox_mamh;
        private System.Windows.Forms.ComboBox comboBox_upd_loaitinchi;
        private System.Windows.Forms.ComboBox comboBox_upd_nganh;
    }
}