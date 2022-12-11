using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hocky
{
    public partial class hocky : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True;";
        public hocky()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM HOCKY", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_insert insert = new form_insert();
            insert.ShowDialog();

            load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string HocKy, Nam, NgBatDau, NgKetThuc, HanDongHP;
            HocKy = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HocKy1"].Value);
            Nam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nam"].Value);
            NgBatDau = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NgBatDau"].Value);
            NgKetThuc = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NgKetThuc"].Value);
            HanDongHP = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HanDongHP"].Value);

            Form_update form_update = new Form_update(HocKy, Nam, NgBatDau, NgKetThuc, HanDongHP);
            form_update.ShowDialog();
            load_data();
        }
    }
}

