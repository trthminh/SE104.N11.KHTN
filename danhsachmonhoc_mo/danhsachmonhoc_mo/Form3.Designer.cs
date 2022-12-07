namespace danhsachmonhoc_mo
{
    partial class Form3
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
            this.comboBox_filter_hk = new System.Windows.Forms.ComboBox();
            this.comboBox_filter_nam = new System.Windows.Forms.ComboBox();
            this.button_confirm_filter = new System.Windows.Forms.Button();
            this.button_dong_filter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // comboBox_filter_hk
            // 
            this.comboBox_filter_hk.FormattingEnabled = true;
            this.comboBox_filter_hk.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_filter_hk.Location = new System.Drawing.Point(197, 49);
            this.comboBox_filter_hk.Name = "comboBox_filter_hk";
            this.comboBox_filter_hk.Size = new System.Drawing.Size(149, 24);
            this.comboBox_filter_hk.TabIndex = 2;
            // 
            // comboBox_filter_nam
            // 
            this.comboBox_filter_nam.FormattingEnabled = true;
            this.comboBox_filter_nam.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.comboBox_filter_nam.Location = new System.Drawing.Point(197, 142);
            this.comboBox_filter_nam.Name = "comboBox_filter_nam";
            this.comboBox_filter_nam.Size = new System.Drawing.Size(149, 24);
            this.comboBox_filter_nam.TabIndex = 3;
            // 
            // button_confirm_filter
            // 
            this.button_confirm_filter.Location = new System.Drawing.Point(226, 206);
            this.button_confirm_filter.Name = "button_confirm_filter";
            this.button_confirm_filter.Size = new System.Drawing.Size(76, 31);
            this.button_confirm_filter.TabIndex = 4;
            this.button_confirm_filter.Text = "OK";
            this.button_confirm_filter.UseVisualStyleBackColor = true;
            this.button_confirm_filter.Click += new System.EventHandler(this.button_confirm_filter_Click);
            // 
            // button_dong_filter
            // 
            this.button_dong_filter.Location = new System.Drawing.Point(411, 206);
            this.button_dong_filter.Name = "button_dong_filter";
            this.button_dong_filter.Size = new System.Drawing.Size(76, 31);
            this.button_dong_filter.TabIndex = 5;
            this.button_dong_filter.Text = "Đóng";
            this.button_dong_filter.UseVisualStyleBackColor = true;
            this.button_dong_filter.Click += new System.EventHandler(this.button_dong_filter_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 270);
            this.Controls.Add(this.button_dong_filter);
            this.Controls.Add(this.button_confirm_filter);
            this.Controls.Add(this.comboBox_filter_nam);
            this.Controls.Add(this.comboBox_filter_hk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Chọn học kỳ / Năm học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_filter_hk;
        private System.Windows.Forms.ComboBox comboBox_filter_nam;
        private System.Windows.Forms.Button button_confirm_filter;
        private System.Windows.Forms.Button button_dong_filter;
    }
}