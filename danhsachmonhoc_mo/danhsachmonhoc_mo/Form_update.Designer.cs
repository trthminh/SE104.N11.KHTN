namespace danhsachmonhoc_mo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_hocky = new System.Windows.Forms.ComboBox();
            this.comboBox_nam = new System.Windows.Forms.ComboBox();
            this.textBox_mamh = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "MaMH";
            // 
            // comboBox_hocky
            // 
            this.comboBox_hocky.FormattingEnabled = true;
            this.comboBox_hocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_hocky.Location = new System.Drawing.Point(147, 27);
            this.comboBox_hocky.Name = "comboBox_hocky";
            this.comboBox_hocky.Size = new System.Drawing.Size(205, 24);
            this.comboBox_hocky.TabIndex = 3;
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
            this.comboBox_nam.Location = new System.Drawing.Point(147, 98);
            this.comboBox_nam.Name = "comboBox_nam";
            this.comboBox_nam.Size = new System.Drawing.Size(205, 24);
            this.comboBox_nam.TabIndex = 4;
            // 
            // textBox_mamh
            // 
            this.textBox_mamh.Location = new System.Drawing.Point(147, 169);
            this.textBox_mamh.Name = "textBox_mamh";
            this.textBox_mamh.Size = new System.Drawing.Size(205, 22);
            this.textBox_mamh.TabIndex = 5;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(204, 228);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(87, 31);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(432, 228);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(87, 31);
            this.button_thoat.TabIndex = 7;
            this.button_thoat.Text = "Đóng";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 271);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_mamh);
            this.Controls.Add(this.comboBox_nam);
            this.Controls.Add(this.comboBox_hocky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Sửa danh sách môn học đang mở";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_hocky;
        private System.Windows.Forms.ComboBox comboBox_nam;
        private System.Windows.Forms.TextBox textBox_mamh;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_thoat;
    }
}