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

namespace danhsachmonhoc_mo
{
    public partial class Form_main_delete : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True;";
        public Form_main_delete()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM DSMH_Mo";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource= dt; 
                connection.Close();
            }
        }

        private void button_dongdsmhmo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_themdsmhmo_Click(object sender, EventArgs e)
        {
            Form_insert form_insert_dsmh_mo = new Form_insert();
            form_insert_dsmh_mo.Show();
            load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Xóa")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string hocky = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HocKy"].Value);
                    string nam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nam"].Value);
                    string mamh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);
                    //MessageBox.Show(name_khoa);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM DSMH_Mo WHERE HocKy=@HocKy AND Nam=@Nam AND MaMH=@MaMH";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@HocKy", hocky);
                        command.Parameters.AddWithValue("@Nam", nam);
                        command.Parameters.AddWithValue("@MaMH", mamh);
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
            // code for update

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Sửa")
            {
                string hocky, nam, mamh;
                hocky = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HocKy"].Value);
                nam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nam"].Value);
                mamh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);

                Form_update form_update = new Form_update(hocky, nam, mamh);
                form_update.ShowDialog();
                load_data();

            }
        }

        private void button_chonhockynam_Click(object sender, EventArgs e)
        {
            Form_filter form_filter = new Form_filter();
            form_filter.Show();
            load_data();
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            string HocKy, Nam;
            HocKy = Convert.ToString(comboBox_filter_hk.SelectedItem);
            Nam = Convert.ToString(comboBox_filter_nam.SelectedItem);
            string search = HocKy;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM DSMH_Mo WHERE HocKy='"+comboBox_filter_hk.SelectedItem.ToString()+"' AND Nam='"+comboBox_filter_nam.SelectedItem.ToString()+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                connection.Close();
            }


            

        }
    }
}
