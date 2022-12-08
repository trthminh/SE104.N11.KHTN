namespace danhsachmonhoc_mo
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
            this.HocKy = new System.Windows.Forms.Label();
            this.Nam = new System.Windows.Forms.Label();
            this.MaMH = new System.Windows.Forms.Label();
            this.textBox_addmamh = new System.Windows.Forms.TextBox();
            this.comboBox_chonhocky = new System.Windows.Forms.ComboBox();
            this.button_themdsmhmo = new System.Windows.Forms.Button();
            this.button_dongthemdsmhmo = new System.Windows.Forms.Button();
            this.comboBox_nam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HocKy
            // 
            this.HocKy.AutoSize = true;
            this.HocKy.Location = new System.Drawing.Point(38, 52);
            this.HocKy.Name = "HocKy";
            this.HocKy.Size = new System.Drawing.Size(49, 16);
            this.HocKy.TabIndex = 0;
            this.HocKy.Text = "Học kỳ";
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(38, 122);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(61, 16);
            this.Nam.TabIndex = 1;
            this.Nam.Text = "Năm học";
            // 
            // MaMH
            // 
            this.MaMH.AutoSize = true;
            this.MaMH.Location = new System.Drawing.Point(38, 184);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(80, 16);
            this.MaMH.TabIndex = 2;
            this.MaMH.Text = "Mã Môn học";
            // 
            // textBox_addmamh
            // 
            this.textBox_addmamh.Location = new System.Drawing.Point(136, 181);
            this.textBox_addmamh.Name = "textBox_addmamh";
            this.textBox_addmamh.Size = new System.Drawing.Size(137, 22);
            this.textBox_addmamh.TabIndex = 4;
            // 
            // comboBox_chonhocky
            // 
            this.comboBox_chonhocky.FormattingEnabled = true;
            this.comboBox_chonhocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_chonhocky.Location = new System.Drawing.Point(136, 44);
            this.comboBox_chonhocky.Name = "comboBox_chonhocky";
            this.comboBox_chonhocky.Size = new System.Drawing.Size(137, 24);
            this.comboBox_chonhocky.TabIndex = 6;
            // 
            // button_themdsmhmo
            // 
            this.button_themdsmhmo.Location = new System.Drawing.Point(154, 249);
            this.button_themdsmhmo.Name = "button_themdsmhmo";
            this.button_themdsmhmo.Size = new System.Drawing.Size(100, 32);
            this.button_themdsmhmo.TabIndex = 7;
            this.button_themdsmhmo.Text = "Thêm";
            this.button_themdsmhmo.UseVisualStyleBackColor = true;
            this.button_themdsmhmo.Click += new System.EventHandler(this.button_themdsmhmo_Click);
            // 
            // button_dongthemdsmhmo
            // 
            this.button_dongthemdsmhmo.Location = new System.Drawing.Point(320, 322);
            this.button_dongthemdsmhmo.Name = "button_dongthemdsmhmo";
            this.button_dongthemdsmhmo.Size = new System.Drawing.Size(83, 33);
            this.button_dongthemdsmhmo.TabIndex = 8;
            this.button_dongthemdsmhmo.Text = "Đóng";
            this.button_dongthemdsmhmo.UseVisualStyleBackColor = true;
            this.button_dongthemdsmhmo.Click += new System.EventHandler(this.button_dongthemdsmhmo_Click);
            // 
            // comboBox_nam
            // 
            this.comboBox_nam.FormattingEnabled = true;
            this.comboBox_nam.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.comboBox_nam.Location = new System.Drawing.Point(136, 114);
            this.comboBox_nam.Name = "comboBox_nam";
            this.comboBox_nam.Size = new System.Drawing.Size(137, 24);
            this.comboBox_nam.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 367);
            this.Controls.Add(this.comboBox_nam);
            this.Controls.Add(this.button_dongthemdsmhmo);
            this.Controls.Add(this.button_themdsmhmo);
            this.Controls.Add(this.comboBox_chonhocky);
            this.Controls.Add(this.textBox_addmamh);
            this.Controls.Add(this.MaMH);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.HocKy);
            this.Name = "Form2";
            this.Text = "Thêm môn học mở";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HocKy;
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.Label MaMH;
        private System.Windows.Forms.TextBox textBox_addmamh;
        private System.Windows.Forms.ComboBox comboBox_chonhocky;
        private System.Windows.Forms.Button button_themdsmhmo;
        private System.Windows.Forms.Button button_dongthemdsmhmo;
        private System.Windows.Forms.ComboBox comboBox_nam;
    }
}