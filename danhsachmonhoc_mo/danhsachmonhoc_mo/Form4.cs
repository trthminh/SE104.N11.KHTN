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

namespace danhsachmonhoc_mo
{
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True;";
        string HocKy, Nam, MaMH;

        private void button_ok_Click(object sender, EventArgs e)
        {
            HocKy = Convert.ToString(comboBox_hocky.SelectedItem);
            Nam = Convert.ToString(comboBox_nam.SelectedItem);
            MaMH = textBox_mamh.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE DSMH_Mo SET HocKy=@HocKy, Nam=@Nam, MaMH=@MaMH";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HocKy", HocKy);
                command.Parameters.AddWithValue("@Nam", Nam);
                command.Parameters.AddWithValue("@MaMH", MaMH);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Updated Successfull");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data not Updated");
                }

                connection.Close();
            }
        }

        public Form4(string hocky1, string nam1, string mamh1)
        {
            InitializeComponent();
            HocKy = hocky1;
            Nam = nam1;
            MaMH = mamh1;
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
