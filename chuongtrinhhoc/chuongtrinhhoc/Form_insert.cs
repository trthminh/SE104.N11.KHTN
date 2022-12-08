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

namespace chuongtrinhhoc
{
    public partial class Form_insert : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True;";
        public Form_insert()
        {
            InitializeComponent();
        }

        private void button_dongthemcthoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add1cthoc_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CTHOC (MaNganh,MaKhoa,HocKy,Nam,MaMH, GhiChu) VALUES (@MaNganh, @MaKhoa, @HocKy, @Nam,@MaMH, @GhiChu)";
            string MaNganh = Convert.ToString(comboBox_add_nganh.SelectedItem);
            string MaKhoa = Convert.ToString(comboBox_add_khoa.SelectedItem);
            string HocKy = Convert.ToString(comboBox_add_hocky.SelectedItem);
            string Nam = Convert.ToString(comboBox_add_nam.SelectedItem);
            string MaMH = Convert.ToString(comboBox_add_mamh.SelectedItem);
            string GhiChu = textBox_add_ghichucthoc.Text;

            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command= new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNganh", MaNganh);
                command.Parameters.AddWithValue("@MaKhoa", MaKhoa);
                command.Parameters.AddWithValue("@HocKy", HocKy);
                command.Parameters.AddWithValue("@Nam", Nam);
                command.Parameters.AddWithValue("@MaMH", MaMH);
                command.Parameters.AddWithValue("@GhiChu", GhiChu);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data inserted successfull!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data not inserted");
                }
                connection.Close();
            }
        }
    }
}
