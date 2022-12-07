namespace chuongtrinhhoc
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
            this.MaNganh = new System.Windows.Forms.Label();
            this.MaKhoa = new System.Windows.Forms.Label();
            this.HocKy = new System.Windows.Forms.Label();
            this.MaMH = new System.Windows.Forms.Label();
            this.GhiChu = new System.Windows.Forms.Label();
            this.textBox_add_ghichucthoc = new System.Windows.Forms.TextBox();
            this.button_add1cthoc = new System.Windows.Forms.Button();
            this.button_dongthemcthoc = new System.Windows.Forms.Button();
            this.Nam = new System.Windows.Forms.Label();
            this.comboBox_add_nam = new System.Windows.Forms.ComboBox();
            this.comboBox_add_nganh = new System.Windows.Forms.ComboBox();
            this.comboBox_add_khoa = new System.Windows.Forms.ComboBox();
            this.comboBox_add_hocky = new System.Windows.Forms.ComboBox();
            this.comboBox_add_mamh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MaNganh
            // 
            this.MaNganh.AutoSize = true;
            this.MaNganh.Location = new System.Drawing.Point(79, 48);
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.Size = new System.Drawing.Size(75, 16);
            this.MaNganh.TabIndex = 0;
            this.MaNganh.Text = "Ngành Học";
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSize = true;
            this.MaKhoa.Location = new System.Drawing.Point(79, 139);
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Size = new System.Drawing.Size(38, 16);
            this.MaKhoa.TabIndex = 1;
            this.MaKhoa.Text = "Khoa";
            // 
            // HocKy
            // 
            this.HocKy.AutoSize = true;
            this.HocKy.Location = new System.Drawing.Point(79, 232);
            this.HocKy.Name = "HocKy";
            this.HocKy.Size = new System.Drawing.Size(50, 16);
            this.HocKy.TabIndex = 2;
            this.HocKy.Text = "Học Kỳ";
            // 
            // MaMH
            // 
            this.MaMH.AutoSize = true;
            this.MaMH.Location = new System.Drawing.Point(468, 139);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(58, 16);
            this.MaMH.TabIndex = 3;
            this.MaMH.Text = "Môn học";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSize = true;
            this.GhiChu.Location = new System.Drawing.Point(468, 232);
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(51, 16);
            this.GhiChu.TabIndex = 4;
            this.GhiChu.Text = "Ghi chú";
            // 
            // textBox_add_ghichucthoc
            // 
            this.textBox_add_ghichucthoc.Location = new System.Drawing.Point(544, 226);
            this.textBox_add_ghichucthoc.Name = "textBox_add_ghichucthoc";
            this.textBox_add_ghichucthoc.Size = new System.Drawing.Size(212, 22);
            this.textBox_add_ghichucthoc.TabIndex = 9;
            // 
            // button_add1cthoc
            // 
            this.button_add1cthoc.Location = new System.Drawing.Point(354, 269);
            this.button_add1cthoc.Name = "button_add1cthoc";
            this.button_add1cthoc.Size = new System.Drawing.Size(93, 44);
            this.button_add1cthoc.TabIndex = 10;
            this.button_add1cthoc.Text = "Thêm";
            this.button_add1cthoc.UseVisualStyleBackColor = true;
            this.button_add1cthoc.Click += new System.EventHandler(this.button_add1cthoc_Click);
            // 
            // button_dongthemcthoc
            // 
            this.button_dongthemcthoc.Location = new System.Drawing.Point(672, 269);
            this.button_dongthemcthoc.Name = "button_dongthemcthoc";
            this.button_dongthemcthoc.Size = new System.Drawing.Size(93, 44);
            this.button_dongthemcthoc.TabIndex = 11;
            this.button_dongthemcthoc.Text = "Đóng";
            this.button_dongthemcthoc.UseVisualStyleBackColor = true;
            this.button_dongthemcthoc.Click += new System.EventHandler(this.button_dongthemcthoc_Click);
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(468, 48);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(36, 16);
            this.Nam.TabIndex = 12;
            this.Nam.Text = "Năm";
            // 
            // comboBox_add_nam
            // 
            this.comboBox_add_nam.FormattingEnabled = true;
            this.comboBox_add_nam.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.comboBox_add_nam.Location = new System.Drawing.Point(544, 42);
            this.comboBox_add_nam.Name = "comboBox_add_nam";
            this.comboBox_add_nam.Size = new System.Drawing.Size(212, 24);
            this.comboBox_add_nam.TabIndex = 13;
            // 
            // comboBox_add_nganh
            // 
            this.comboBox_add_nganh.FormattingEnabled = true;
            this.comboBox_add_nganh.Items.AddRange(new object[] {
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
            this.comboBox_add_nganh.Location = new System.Drawing.Point(155, 40);
            this.comboBox_add_nganh.Name = "comboBox_add_nganh";
            this.comboBox_add_nganh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_add_nganh.TabIndex = 14;
            // 
            // comboBox_add_khoa
            // 
            this.comboBox_add_khoa.FormattingEnabled = true;
            this.comboBox_add_khoa.Items.AddRange(new object[] {
            "K001",
            "K002",
            "K003",
            "K004",
            "K005",
            "K006"});
            this.comboBox_add_khoa.Location = new System.Drawing.Point(155, 136);
            this.comboBox_add_khoa.Name = "comboBox_add_khoa";
            this.comboBox_add_khoa.Size = new System.Drawing.Size(212, 24);
            this.comboBox_add_khoa.TabIndex = 15;
            // 
            // comboBox_add_hocky
            // 
            this.comboBox_add_hocky.FormattingEnabled = true;
            this.comboBox_add_hocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_add_hocky.Location = new System.Drawing.Point(155, 224);
            this.comboBox_add_hocky.Name = "comboBox_add_hocky";
            this.comboBox_add_hocky.Size = new System.Drawing.Size(212, 24);
            this.comboBox_add_hocky.TabIndex = 16;
            // 
            // comboBox_add_mamh
            // 
            this.comboBox_add_mamh.FormattingEnabled = true;
            this.comboBox_add_mamh.Items.AddRange(new object[] {
            "M001",
            "M002",
            "M003",
            "M004",
            "M005"});
            this.comboBox_add_mamh.Location = new System.Drawing.Point(544, 131);
            this.comboBox_add_mamh.Name = "comboBox_add_mamh";
            this.comboBox_add_mamh.Size = new System.Drawing.Size(212, 24);
            this.comboBox_add_mamh.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.comboBox_add_mamh);
            this.Controls.Add(this.comboBox_add_hocky);
            this.Controls.Add(this.comboBox_add_khoa);
            this.Controls.Add(this.comboBox_add_nganh);
            this.Controls.Add(this.comboBox_add_nam);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.button_dongthemcthoc);
            this.Controls.Add(this.button_add1cthoc);
            this.Controls.Add(this.textBox_add_ghichucthoc);
            this.Controls.Add(this.GhiChu);
            this.Controls.Add(this.MaMH);
            this.Controls.Add(this.HocKy);
            this.Controls.Add(this.MaKhoa);
            this.Controls.Add(this.MaNganh);
            this.Name = "Form2";
            this.Text = "Thêm chương trình học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaNganh;
        private System.Windows.Forms.Label MaKhoa;
        private System.Windows.Forms.Label HocKy;
        private System.Windows.Forms.Label MaMH;
        private System.Windows.Forms.Label GhiChu;
        private System.Windows.Forms.TextBox textBox_add_ghichucthoc;
        private System.Windows.Forms.Button button_add1cthoc;
        private System.Windows.Forms.Button button_dongthemcthoc;
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.ComboBox comboBox_add_nam;
        private System.Windows.Forms.ComboBox comboBox_add_nganh;
        private System.Windows.Forms.ComboBox comboBox_add_khoa;
        private System.Windows.Forms.ComboBox comboBox_add_hocky;
        private System.Windows.Forms.ComboBox comboBox_add_mamh;
    }
}