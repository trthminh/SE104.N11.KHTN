namespace hocky
{
    partial class hocky
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
            this.button_add = new System.Windows.Forms.Button();
            this.HocKy1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanDongHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HocKy1,
            this.Nam,
            this.NgBatDau,
            this.NgKetThuc,
            this.HanDongHP,
            this.Sua});
            this.dataGridView1.Location = new System.Drawing.Point(55, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(317, 421);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(103, 34);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // HocKy1
            // 
            this.HocKy1.DataPropertyName = "HocKy";
            this.HocKy1.HeaderText = "Học Kỳ";
            this.HocKy1.MinimumWidth = 6;
            this.HocKy1.Name = "HocKy1";
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            // 
            // NgBatDau
            // 
            this.NgBatDau.DataPropertyName = "NgBatDau";
            this.NgBatDau.HeaderText = "Ngày bắt đầu";
            this.NgBatDau.MinimumWidth = 6;
            this.NgBatDau.Name = "NgBatDau";
            // 
            // NgKetThuc
            // 
            this.NgKetThuc.DataPropertyName = "NgKetThuc";
            this.NgKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgKetThuc.MinimumWidth = 6;
            this.NgKetThuc.Name = "NgKetThuc";
            // 
            // HanDongHP
            // 
            this.HanDongHP.DataPropertyName = "HanDongHP";
            this.HanDongHP.HeaderText = "Hạn Đóng Học Phí";
            this.HanDongHP.MinimumWidth = 6;
            this.HanDongHP.Name = "HanDongHP";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin các học kỳ";
            // 
            // hocky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "hocky";
            this.Text = "Học Kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanDongHP;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.Label label1;
    }
}

