namespace danhsachmonhoc
{
    partial class Form_main_delete
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
            this.button_themdsmh = new System.Windows.Forms.Button();
            this.button_dongdsmh = new System.Windows.Forms.Button();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.LoaiTinChi,
            this.SoTiet,
            this.MaNganh,
            this.MaKhoa,
            this.Xoa,
            this.Sua});
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_themdsmh
            // 
            this.button_themdsmh.Location = new System.Drawing.Point(351, 410);
            this.button_themdsmh.Name = "button_themdsmh";
            this.button_themdsmh.Size = new System.Drawing.Size(88, 34);
            this.button_themdsmh.TabIndex = 1;
            this.button_themdsmh.Text = "Thêm";
            this.button_themdsmh.UseVisualStyleBackColor = true;
            this.button_themdsmh.Click += new System.EventHandler(this.button_themdsmh_Click);
            // 
            // button_dongdsmh
            // 
            this.button_dongdsmh.Location = new System.Drawing.Point(700, 410);
            this.button_dongdsmh.Name = "button_dongdsmh";
            this.button_dongdsmh.Size = new System.Drawing.Size(88, 34);
            this.button_dongdsmh.TabIndex = 2;
            this.button_dongdsmh.Text = "Đóng";
            this.button_dongdsmh.UseVisualStyleBackColor = true;
            this.button_dongdsmh.Click += new System.EventHandler(this.button_dongdsmh_Click);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên Môn học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            // 
            // LoaiTinChi
            // 
            this.LoaiTinChi.DataPropertyName = "LoaiTinChi";
            this.LoaiTinChi.HeaderText = "Loại Tín Chỉ";
            this.LoaiTinChi.MinimumWidth = 6;
            this.LoaiTinChi.Name = "LoaiTinChi";
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số Tiết";
            this.SoTiet.MinimumWidth = 6;
            this.SoTiet.Name = "SoTiet";
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Mã Ngành";
            this.MaNganh.MinimumWidth = 6;
            this.MaNganh.Name = "MaNganh";
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_dongdsmh);
            this.Controls.Add(this.button_themdsmh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Danh sách môn học";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_themdsmh;
        private System.Windows.Forms.Button button_dongdsmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
    }
}

