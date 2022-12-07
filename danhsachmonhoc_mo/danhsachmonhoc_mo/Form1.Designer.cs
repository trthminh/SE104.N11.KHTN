namespace danhsachmonhoc_mo
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_themdsmhmo = new System.Windows.Forms.Button();
            this.button_dongdsmhmo = new System.Windows.Forms.Button();
            this.comboBox_filter_hk = new System.Windows.Forms.ComboBox();
            this.comboBox_filter_nam = new System.Windows.Forms.ComboBox();
            this.HocKy1 = new System.Windows.Forms.Label();
            this.Nam1 = new System.Windows.Forms.Label();
            this.button_filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HocKy,
            this.Nam,
            this.MaMH,
            this.Xoa});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // HocKy
            // 
            this.HocKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            this.HocKy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // button_themdsmhmo
            // 
            this.button_themdsmhmo.Location = new System.Drawing.Point(327, 395);
            this.button_themdsmhmo.Name = "button_themdsmhmo";
            this.button_themdsmhmo.Size = new System.Drawing.Size(117, 43);
            this.button_themdsmhmo.TabIndex = 2;
            this.button_themdsmhmo.Text = "Thêm";
            this.button_themdsmhmo.UseVisualStyleBackColor = true;
            this.button_themdsmhmo.Click += new System.EventHandler(this.button_themdsmhmo_Click);
            // 
            // button_dongdsmhmo
            // 
            this.button_dongdsmhmo.Location = new System.Drawing.Point(637, 395);
            this.button_dongdsmhmo.Name = "button_dongdsmhmo";
            this.button_dongdsmhmo.Size = new System.Drawing.Size(117, 43);
            this.button_dongdsmhmo.TabIndex = 3;
            this.button_dongdsmhmo.Text = "Đóng";
            this.button_dongdsmhmo.UseVisualStyleBackColor = true;
            this.button_dongdsmhmo.Click += new System.EventHandler(this.button_dongdsmhmo_Click);
            // 
            // comboBox_filter_hk
            // 
            this.comboBox_filter_hk.FormattingEnabled = true;
            this.comboBox_filter_hk.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_filter_hk.Location = new System.Drawing.Point(107, 50);
            this.comboBox_filter_hk.Name = "comboBox_filter_hk";
            this.comboBox_filter_hk.Size = new System.Drawing.Size(128, 24);
            this.comboBox_filter_hk.TabIndex = 4;
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
            this.comboBox_filter_nam.Location = new System.Drawing.Point(394, 50);
            this.comboBox_filter_nam.Name = "comboBox_filter_nam";
            this.comboBox_filter_nam.Size = new System.Drawing.Size(128, 24);
            this.comboBox_filter_nam.TabIndex = 5;
            // 
            // HocKy1
            // 
            this.HocKy1.AutoSize = true;
            this.HocKy1.Location = new System.Drawing.Point(35, 58);
            this.HocKy1.Name = "HocKy1";
            this.HocKy1.Size = new System.Drawing.Size(50, 16);
            this.HocKy1.TabIndex = 6;
            this.HocKy1.Text = "Học Kỳ";
            // 
            // Nam1
            // 
            this.Nam1.AutoSize = true;
            this.Nam1.Location = new System.Drawing.Point(303, 58);
            this.Nam1.Name = "Nam1";
            this.Nam1.Size = new System.Drawing.Size(64, 16);
            this.Nam1.TabIndex = 7;
            this.Nam1.Text = "Năm Học";
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(604, 53);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(72, 27);
            this.button_filter.TabIndex = 8;
            this.button_filter.Text = "Lọc";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.Nam1);
            this.Controls.Add(this.HocKy1);
            this.Controls.Add(this.comboBox_filter_nam);
            this.Controls.Add(this.comboBox_filter_hk);
            this.Controls.Add(this.button_dongdsmhmo);
            this.Controls.Add(this.button_themdsmhmo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Danh sách môn học mở";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_themdsmhmo;
        private System.Windows.Forms.Button button_dongdsmhmo;
        private System.Windows.Forms.ComboBox comboBox_filter_hk;
        private System.Windows.Forms.ComboBox comboBox_filter_nam;
        private System.Windows.Forms.Label HocKy1;
        private System.Windows.Forms.Label Nam1;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}

