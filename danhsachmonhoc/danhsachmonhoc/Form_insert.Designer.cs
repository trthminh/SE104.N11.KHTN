namespace danhsachmonhoc
{
    partial class Form_insert
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
            this.button_themdsmh = new System.Windows.Forms.Button();
            this.textBox_addSoTiet = new System.Windows.Forms.TextBox();
            this.MaKhoa = new System.Windows.Forms.Label();
            this.MaNganh = new System.Windows.Forms.Label();
            this.LoaiTinChi = new System.Windows.Forms.Label();
            this.SoTiet = new System.Windows.Forms.Label();
            this.TenMH = new System.Windows.Forms.Label();
            this.MaMH = new System.Windows.Forms.Label();
            this.button_dongthemdsmh = new System.Windows.Forms.Button();
            this.comboBox_mamh = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_tenmh = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_loaitinchi = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_nganh = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_khoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_themdsmh
            // 
            this.button_themdsmh.Location = new System.Drawing.Point(341, 313);
            this.button_themdsmh.Name = "button_themdsmh";
            this.button_themdsmh.Size = new System.Drawing.Size(148, 36);
            this.button_themdsmh.TabIndex = 27;
            this.button_themdsmh.Text = "Thêm";
            this.button_themdsmh.UseVisualStyleBackColor = true;
            this.button_themdsmh.Click += new System.EventHandler(this.button_themdsmh_Click);
            // 
            // textBox_addSoTiet
            // 
            this.textBox_addSoTiet.Location = new System.Drawing.Point(170, 230);
            this.textBox_addSoTiet.Name = "textBox_addSoTiet";
            this.textBox_addSoTiet.Size = new System.Drawing.Size(212, 22);
            this.textBox_addSoTiet.TabIndex = 23;
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSize = true;
            this.MaKhoa.Location = new System.Drawing.Point(429, 236);
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Size = new System.Drawing.Size(60, 16);
            this.MaKhoa.TabIndex = 20;
            this.MaKhoa.Text = "Mã Khoa";
            // 
            // MaNganh
            // 
            this.MaNganh.AutoSize = true;
            this.MaNganh.Location = new System.Drawing.Point(429, 159);
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.Size = new System.Drawing.Size(69, 16);
            this.MaNganh.TabIndex = 19;
            this.MaNganh.Text = "Mã Ngành";
            // 
            // LoaiTinChi
            // 
            this.LoaiTinChi.AutoSize = true;
            this.LoaiTinChi.Location = new System.Drawing.Point(429, 78);
            this.LoaiTinChi.Name = "LoaiTinChi";
            this.LoaiTinChi.Size = new System.Drawing.Size(77, 16);
            this.LoaiTinChi.TabIndex = 18;
            this.LoaiTinChi.Text = "Loại Tín Chỉ";
            // 
            // SoTiet
            // 
            this.SoTiet.AutoSize = true;
            this.SoTiet.Location = new System.Drawing.Point(64, 236);
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.Size = new System.Drawing.Size(50, 16);
            this.SoTiet.TabIndex = 17;
            this.SoTiet.Text = "Số Tiết";
            // 
            // TenMH
            // 
            this.TenMH.AutoSize = true;
            this.TenMH.Location = new System.Drawing.Point(64, 159);
            this.TenMH.Name = "TenMH";
            this.TenMH.Size = new System.Drawing.Size(85, 16);
            this.TenMH.TabIndex = 16;
            this.TenMH.Text = "Tên Môn học";
            // 
            // MaMH
            // 
            this.MaMH.AutoSize = true;
            this.MaMH.Location = new System.Drawing.Point(64, 78);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(80, 16);
            this.MaMH.TabIndex = 15;
            this.MaMH.Text = "Mã Môn học";
            // 
            // button_dongthemdsmh
            // 
            this.button_dongthemdsmh.Location = new System.Drawing.Point(661, 394);
            this.button_dongthemdsmh.Name = "button_dongthemdsmh";
            this.button_dongthemdsmh.Size = new System.Drawing.Size(100, 36);
            this.button_dongthemdsmh.TabIndex = 29;
            this.button_dongthemdsmh.Text = "Đóng";
            this.button_dongthemdsmh.UseVisualStyleBackColor = true;
            this.button_dongthemdsmh.Click += new System.EventHandler(this.button_dongthemdsmh_Click);
            // 
            // comboBox_mamh
            // 
            this.comboBox_mamh.FormattingEnabled = true;
            this.comboBox_mamh.Items.AddRange(new object[] {
            "M001",
            "M002",
            "M003",
            "M004",
            "M005"});
            this.comboBox_mamh.Location = new System.Drawing.Point(170, 75);
            this.comboBox_mamh.Name = "comboBox_mamh";
            this.comboBox_mamh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_mamh.TabIndex = 30;
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
            this.comboBox_upd_tenmh.Location = new System.Drawing.Point(170, 151);
            this.comboBox_upd_tenmh.Name = "comboBox_upd_tenmh";
            this.comboBox_upd_tenmh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_tenmh.TabIndex = 31;
            // 
            // comboBox_upd_loaitinchi
            // 
            this.comboBox_upd_loaitinchi.FormattingEnabled = true;
            this.comboBox_upd_loaitinchi.Items.AddRange(new object[] {
            "LT",
            "TH"});
            this.comboBox_upd_loaitinchi.Location = new System.Drawing.Point(540, 75);
            this.comboBox_upd_loaitinchi.Name = "comboBox_upd_loaitinchi";
            this.comboBox_upd_loaitinchi.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_loaitinchi.TabIndex = 32;
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
            this.comboBox_upd_nganh.Location = new System.Drawing.Point(540, 151);
            this.comboBox_upd_nganh.Name = "comboBox_upd_nganh";
            this.comboBox_upd_nganh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_nganh.TabIndex = 33;
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
            this.comboBox_upd_khoa.Location = new System.Drawing.Point(540, 230);
            this.comboBox_upd_khoa.Name = "comboBox_upd_khoa";
            this.comboBox_upd_khoa.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_khoa.TabIndex = 34;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_upd_khoa);
            this.Controls.Add(this.comboBox_upd_nganh);
            this.Controls.Add(this.comboBox_upd_loaitinchi);
            this.Controls.Add(this.comboBox_upd_tenmh);
            this.Controls.Add(this.comboBox_mamh);
            this.Controls.Add(this.button_dongthemdsmh);
            this.Controls.Add(this.button_themdsmh);
            this.Controls.Add(this.textBox_addSoTiet);
            this.Controls.Add(this.MaKhoa);
            this.Controls.Add(this.MaNganh);
            this.Controls.Add(this.LoaiTinChi);
            this.Controls.Add(this.SoTiet);
            this.Controls.Add(this.TenMH);
            this.Controls.Add(this.MaMH);
            this.Name = "Form3";
            this.Text = "Thêm môn học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_themdsmh;
        private System.Windows.Forms.TextBox textBox_addSoTiet;
        private System.Windows.Forms.Label MaKhoa;
        private System.Windows.Forms.Label MaNganh;
        private System.Windows.Forms.Label LoaiTinChi;
        private System.Windows.Forms.Label SoTiet;
        private System.Windows.Forms.Label TenMH;
        private System.Windows.Forms.Label MaMH;
        private System.Windows.Forms.Button button_dongthemdsmh;
        private System.Windows.Forms.ComboBox comboBox_mamh;
        private System.Windows.Forms.ComboBox comboBox_upd_tenmh;
        private System.Windows.Forms.ComboBox comboBox_upd_loaitinchi;
        private System.Windows.Forms.ComboBox comboBox_upd_nganh;
        private System.Windows.Forms.ComboBox comboBox_upd_khoa;
    }
}