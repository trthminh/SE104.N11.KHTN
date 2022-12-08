using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace danhsachmonhoc
{
    public partial class Form_main_delete : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True;";
        public Form_main_delete()
        {
            InitializeComponent();
        }

        private void load_data()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DSMH", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                connection.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Xóa")
            {
                DialogResult confirm = MessageBox.Show("Bạn có thật sự muốn xóa nó?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string MaMH = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM DSMH WHERE MaMH=@MaMH";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MaMH", MaMH);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Deleted Successfull");
                        }
                        else
                        {
                            MessageBox.Show("Data not Deleted");
                        }

                        connection.Close();
                    }
                    load_data();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Sửa")
            {
                string mamh, tenmh, loaitinchi, sotiet, manganh, makhoa;
                mamh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);
                tenmh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["TenMH"].Value);
                loaitinchi = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["LoaiTinChi"].Value);
                sotiet = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["SoTiet"].Value);
                manganh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaNganh"].Value);
                makhoa = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaKhoa"].Value);

                Form_update form_update = new Form_update(mamh, tenmh, loaitinchi, sotiet, manganh, makhoa);
                form_update.ShowDialog();
                load_data();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_themdsmh_Click(object sender, EventArgs e)
        {
            Form_insert form_insert = new Form_insert();
            form_insert.ShowDialog();
            load_data();

        }

        private void button_dongdsmh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
