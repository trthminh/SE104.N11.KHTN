namespace hocky
{
    partial class form_insert
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nbd = new System.Windows.Forms.TextBox();
            this.button_chonnbd = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button_xacnhan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_nkt = new System.Windows.Forms.Button();
            this.textBox_ngaykt = new System.Windows.Forms.TextBox();
            this.buttonhanthuhp = new System.Windows.Forms.Button();
            this.textBox_hanthuhp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.button_xn_group2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.monthCalendar4 = new System.Windows.Forms.MonthCalendar();
            this.button_xngroup3 = new System.Windows.Forms.Button();
            this.button_add_data = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hạn đóng học phí";
            // 
            // textBox_nbd
            // 
            this.textBox_nbd.Enabled = false;
            this.textBox_nbd.Location = new System.Drawing.Point(206, 133);
            this.textBox_nbd.Name = "textBox_nbd";
            this.textBox_nbd.Size = new System.Drawing.Size(139, 22);
            this.textBox_nbd.TabIndex = 8;
            // 
            // button_chonnbd
            // 
            this.button_chonnbd.Location = new System.Drawing.Point(398, 127);
            this.button_chonnbd.Name = "button_chonnbd";
            this.button_chonnbd.Size = new System.Drawing.Size(100, 28);
            this.button_chonnbd.TabIndex = 9;
            this.button_chonnbd.Text = "Chọn ngày";
            this.button_chonnbd.UseVisualStyleBackColor = true;
            this.button_chonnbd.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(33, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // button_xacnhan
            // 
            this.button_xacnhan.Location = new System.Drawing.Point(120, 251);
            this.button_xacnhan.Name = "button_xacnhan";
            this.button_xacnhan.Size = new System.Drawing.Size(106, 32);
            this.button_xacnhan.TabIndex = 11;
            this.button_xacnhan.Text = "Xác nhận";
            this.button_xacnhan.UseVisualStyleBackColor = true;
            this.button_xacnhan.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.button_xacnhan);
            this.groupBox1.Location = new System.Drawing.Point(565, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 302);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày bắt đầu";
            // 
            // button_nkt
            // 
            this.button_nkt.Location = new System.Drawing.Point(398, 224);
            this.button_nkt.Name = "button_nkt";
            this.button_nkt.Size = new System.Drawing.Size(100, 28);
            this.button_nkt.TabIndex = 14;
            this.button_nkt.Text = "Chọn ngày";
            this.button_nkt.UseVisualStyleBackColor = true;
            this.button_nkt.Click += new System.EventHandler(this.button_nkt_Click);
            // 
            // textBox_ngaykt
            // 
            this.textBox_ngaykt.Enabled = false;
            this.textBox_ngaykt.Location = new System.Drawing.Point(206, 230);
            this.textBox_ngaykt.Name = "textBox_ngaykt";
            this.textBox_ngaykt.Size = new System.Drawing.Size(139, 22);
            this.textBox_ngaykt.TabIndex = 13;
            // 
            // buttonhanthuhp
            // 
            this.buttonhanthuhp.Location = new System.Drawing.Point(398, 311);
            this.buttonhanthuhp.Name = "buttonhanthuhp";
            this.buttonhanthuhp.Size = new System.Drawing.Size(100, 28);
            this.buttonhanthuhp.TabIndex = 16;
            this.buttonhanthuhp.Text = "Chọn ngày";
            this.buttonhanthuhp.UseVisualStyleBackColor = true;
            this.buttonhanthuhp.Click += new System.EventHandler(this.buttonhanthuhp_Click);
            // 
            // textBox_hanthuhp
            // 
            this.textBox_hanthuhp.Enabled = false;
            this.textBox_hanthuhp.Location = new System.Drawing.Point(206, 317);
            this.textBox_hanthuhp.Name = "textBox_hanthuhp";
            this.textBox_hanthuhp.Size = new System.Drawing.Size(139, 22);
            this.textBox_hanthuhp.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Controls.Add(this.button_xn_group2);
            this.groupBox2.Location = new System.Drawing.Point(571, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 302);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày kết thúc";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(33, 18);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 10;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // button_xn_group2
            // 
            this.button_xn_group2.Location = new System.Drawing.Point(120, 251);
            this.button_xn_group2.Name = "button_xn_group2";
            this.button_xn_group2.Size = new System.Drawing.Size(106, 32);
            this.button_xn_group2.TabIndex = 11;
            this.button_xn_group2.Text = "Xác nhận";
            this.button_xn_group2.UseVisualStyleBackColor = true;
            this.button_xn_group2.Click += new System.EventHandler(this.button_xn_group2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monthCalendar4);
            this.groupBox3.Controls.Add(this.button_xngroup3);
            this.groupBox3.Location = new System.Drawing.Point(577, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 302);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hạn đóng học phí";
            // 
            // monthCalendar4
            // 
            this.monthCalendar4.Location = new System.Drawing.Point(33, 18);
            this.monthCalendar4.Name = "monthCalendar4";
            this.monthCalendar4.TabIndex = 10;
            this.monthCalendar4.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar4_DateChanged);
            // 
            // button_xngroup3
            // 
            this.button_xngroup3.Location = new System.Drawing.Point(120, 251);
            this.button_xngroup3.Name = "button_xngroup3";
            this.button_xngroup3.Size = new System.Drawing.Size(106, 32);
            this.button_xngroup3.TabIndex = 11;
            this.button_xngroup3.Text = "Xác nhận";
            this.button_xngroup3.UseVisualStyleBackColor = true;
            this.button_xngroup3.Click += new System.EventHandler(this.button_xngroup3_Click);
            // 
            // button_add_data
            // 
            this.button_add_data.Location = new System.Drawing.Point(362, 369);
            this.button_add_data.Name = "button_add_data";
            this.button_add_data.Size = new System.Drawing.Size(107, 32);
            this.button_add_data.TabIndex = 18;
            this.button_add_data.Text = "Thêm";
            this.button_add_data.UseVisualStyleBackColor = true;
            this.button_add_data.Click += new System.EventHandler(this.button_add_data_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(598, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(139, 22);
            this.numericUpDown1.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(206, 38);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(139, 22);
            this.numericUpDown2.TabIndex = 38;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // form_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 414);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_add_data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonhanthuhp);
            this.Controls.Add(this.textBox_hanthuhp);
            this.Controls.Add(this.button_nkt);
            this.Controls.Add(this.textBox_ngaykt);
            this.Controls.Add(this.button_chonnbd);
            this.Controls.Add(this.textBox_nbd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_insert";
            this.Text = "Thêm học kỳ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nbd;
        private System.Windows.Forms.Button button_chonnbd;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button_xacnhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button button_xn_group2;
        private System.Windows.Forms.Button button_nkt;
        private System.Windows.Forms.TextBox textBox_ngaykt;
        private System.Windows.Forms.Button buttonhanthuhp;
        private System.Windows.Forms.TextBox textBox_hanthuhp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar4;
        private System.Windows.Forms.Button button_xngroup3;
        private System.Windows.Forms.Button button_add_data;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}