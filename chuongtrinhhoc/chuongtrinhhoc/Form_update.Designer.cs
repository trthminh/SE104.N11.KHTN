namespace chuongtrinhhoc
{
    partial class Form_update
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
            this.Nam = new System.Windows.Forms.Label();
            this.button_dongthemcthoc = new System.Windows.Forms.Button();
            this.button_upd_cth_done = new System.Windows.Forms.Button();
            this.textBox_upd_ghichu = new System.Windows.Forms.TextBox();
            this.GhiChu = new System.Windows.Forms.Label();
            this.MaMH = new System.Windows.Forms.Label();
            this.HocKy = new System.Windows.Forms.Label();
            this.MaKhoa = new System.Windows.Forms.Label();
            this.MaNganh = new System.Windows.Forms.Label();
            this.comboBox_upd_nganh = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_khoa = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_hocky = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_nam = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_mamh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(438, 55);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(36, 16);
            this.Nam.TabIndex = 26;
            this.Nam.Text = "Năm";
            // 
            // button_dongthemcthoc
            // 
            this.button_dongthemcthoc.Location = new System.Drawing.Point(642, 276);
            this.button_dongthemcthoc.Name = "button_dongthemcthoc";
            this.button_dongthemcthoc.Size = new System.Drawing.Size(93, 44);
            this.button_dongthemcthoc.TabIndex = 25;
            this.button_dongthemcthoc.Text = "Đóng";
            this.button_dongthemcthoc.UseVisualStyleBackColor = true;
            this.button_dongthemcthoc.Click += new System.EventHandler(this.button_dongthemcthoc_Click);
            // 
            // button_upd_cth_done
            // 
            this.button_upd_cth_done.Location = new System.Drawing.Point(324, 276);
            this.button_upd_cth_done.Name = "button_upd_cth_done";
            this.button_upd_cth_done.Size = new System.Drawing.Size(93, 44);
            this.button_upd_cth_done.TabIndex = 24;
            this.button_upd_cth_done.Text = "Xong";
            this.button_upd_cth_done.UseVisualStyleBackColor = true;
            this.button_upd_cth_done.Click += new System.EventHandler(this.button_upd_cth_done_Click);
            // 
            // textBox_upd_ghichu
            // 
            this.textBox_upd_ghichu.Location = new System.Drawing.Point(514, 233);
            this.textBox_upd_ghichu.Name = "textBox_upd_ghichu";
            this.textBox_upd_ghichu.Size = new System.Drawing.Size(212, 22);
            this.textBox_upd_ghichu.TabIndex = 23;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSize = true;
            this.GhiChu.Location = new System.Drawing.Point(438, 239);
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(51, 16);
            this.GhiChu.TabIndex = 18;
            this.GhiChu.Text = "Ghi chú";
            // 
            // MaMH
            // 
            this.MaMH.AutoSize = true;
            this.MaMH.Location = new System.Drawing.Point(438, 146);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(58, 16);
            this.MaMH.TabIndex = 17;
            this.MaMH.Text = "Môn học";
            // 
            // HocKy
            // 
            this.HocKy.AutoSize = true;
            this.HocKy.Location = new System.Drawing.Point(49, 239);
            this.HocKy.Name = "HocKy";
            this.HocKy.Size = new System.Drawing.Size(50, 16);
            this.HocKy.TabIndex = 16;
            this.HocKy.Text = "Học Kỳ";
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSize = true;
            this.MaKhoa.Location = new System.Drawing.Point(49, 146);
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Size = new System.Drawing.Size(38, 16);
            this.MaKhoa.TabIndex = 15;
            this.MaKhoa.Text = "Khoa";
            // 
            // MaNganh
            // 
            this.MaNganh.AutoSize = true;
            this.MaNganh.Location = new System.Drawing.Point(49, 55);
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.Size = new System.Drawing.Size(75, 16);
            this.MaNganh.TabIndex = 14;
            this.MaNganh.Text = "Ngành Học";
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
            this.comboBox_upd_nganh.Location = new System.Drawing.Point(125, 47);
            this.comboBox_upd_nganh.Name = "comboBox_upd_nganh";
            this.comboBox_upd_nganh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_nganh.TabIndex = 28;
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
            this.comboBox_upd_khoa.Location = new System.Drawing.Point(125, 138);
            this.comboBox_upd_khoa.Name = "comboBox_upd_khoa";
            this.comboBox_upd_khoa.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_khoa.TabIndex = 29;
            // 
            // comboBox_upd_hocky
            // 
            this.comboBox_upd_hocky.Enabled = false;
            this.comboBox_upd_hocky.FormattingEnabled = true;
            this.comboBox_upd_hocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_upd_hocky.Location = new System.Drawing.Point(125, 231);
            this.comboBox_upd_hocky.Name = "comboBox_upd_hocky";
            this.comboBox_upd_hocky.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_hocky.TabIndex = 30;
            // 
            // comboBox_upd_nam
            // 
            this.comboBox_upd_nam.Enabled = false;
            this.comboBox_upd_nam.FormattingEnabled = true;
            this.comboBox_upd_nam.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.comboBox_upd_nam.Location = new System.Drawing.Point(514, 52);
            this.comboBox_upd_nam.Name = "comboBox_upd_nam";
            this.comboBox_upd_nam.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_nam.TabIndex = 31;
            // 
            // comboBox_upd_mamh
            // 
            this.comboBox_upd_mamh.Enabled = false;
            this.comboBox_upd_mamh.FormattingEnabled = true;
            this.comboBox_upd_mamh.Items.AddRange(new object[] {
            "M001",
            "M002",
            "M003",
            "M004",
            "M005"});
            this.comboBox_upd_mamh.Location = new System.Drawing.Point(514, 138);
            this.comboBox_upd_mamh.Name = "comboBox_upd_mamh";
            this.comboBox_upd_mamh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_upd_mamh.TabIndex = 32;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 337);
            this.Controls.Add(this.comboBox_upd_mamh);
            this.Controls.Add(this.comboBox_upd_nam);
            this.Controls.Add(this.comboBox_upd_hocky);
            this.Controls.Add(this.comboBox_upd_khoa);
            this.Controls.Add(this.comboBox_upd_nganh);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.button_dongthemcthoc);
            this.Controls.Add(this.button_upd_cth_done);
            this.Controls.Add(this.textBox_upd_ghichu);
            this.Controls.Add(this.GhiChu);
            this.Controls.Add(this.MaMH);
            this.Controls.Add(this.HocKy);
            this.Controls.Add(this.MaKhoa);
            this.Controls.Add(this.MaNganh);
            this.Name = "Form4";
            this.Text = "Sửa chương trình học";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.Button button_dongthemcthoc;
        private System.Windows.Forms.Button button_upd_cth_done;
        private System.Windows.Forms.TextBox textBox_upd_ghichu;
        private System.Windows.Forms.Label GhiChu;
        private System.Windows.Forms.Label MaMH;
        private System.Windows.Forms.Label HocKy;
        private System.Windows.Forms.Label MaKhoa;
        private System.Windows.Forms.Label MaNganh;
        private System.Windows.Forms.ComboBox comboBox_upd_nganh;
        private System.Windows.Forms.ComboBox comboBox_upd_khoa;
        private System.Windows.Forms.ComboBox comboBox_upd_hocky;
        private System.Windows.Forms.ComboBox comboBox_upd_nam;
        private System.Windows.Forms.ComboBox comboBox_upd_mamh;
    }
}