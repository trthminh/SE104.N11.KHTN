namespace chuongtrinhhoc
{
    partial class CTHoc
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
            this.button_addcthoc = new System.Windows.Forms.Button();
            this.button_dongcthoc = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.Sua,
            this.MaNganh,
            this.MaKhoa,
            this.HocKy,
            this.Nam,
            this.MaMH,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(1, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_addcthoc
            // 
            this.button_addcthoc.Location = new System.Drawing.Point(328, 390);
            this.button_addcthoc.Name = "button_addcthoc";
            this.button_addcthoc.Size = new System.Drawing.Size(97, 38);
            this.button_addcthoc.TabIndex = 1;
            this.button_addcthoc.Text = "Thêm";
            this.button_addcthoc.UseVisualStyleBackColor = true;
            this.button_addcthoc.Click += new System.EventHandler(this.button_addcthoc_Click);
            // 
            // button_dongcthoc
            // 
            this.button_dongcthoc.Location = new System.Drawing.Point(668, 390);
            this.button_dongcthoc.Name = "button_dongcthoc";
            this.button_dongcthoc.Size = new System.Drawing.Size(97, 38);
            this.button_dongcthoc.TabIndex = 2;
            this.button_dongcthoc.Text = "Đóng";
            this.button_dongcthoc.UseVisualStyleBackColor = true;
            this.button_dongcthoc.Click += new System.EventHandler(this.button_dongcthoc_Click);
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // Sua
            // 
            this.Sua.DataPropertyName = "Sua";
            this.Sua.HeaderText = "Sửa";
            this.Sua.MinimumWidth = 6;
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Ngành Học";
            this.MaNganh.MinimumWidth = 6;
            this.MaNganh.Name = "MaNganh";
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            this.HocKy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Môn Học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // CTHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_dongcthoc);
            this.Controls.Add(this.button_addcthoc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CTHoc";
            this.Text = "Chương trình học";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_addcthoc;
        private System.Windows.Forms.Button button_dongcthoc;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}

