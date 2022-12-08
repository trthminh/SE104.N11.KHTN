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
    public partial class Form_insert : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True;";
        public Form_insert()
        {
            InitializeComponent();
        }

        private void button_dongthemdsmhmo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_themdsmhmo_Click(object sender, EventArgs e)
        {
            string HocKy, Nam, MaMH;
            string query = "INSERT INTO DSMH_Mo (HocKy,Nam,MaMH) VALUES (@HocKy, @Nam, @MaMH)";

            HocKy = Convert.ToString(comboBox_chonhocky.SelectedItem);
            Nam = Convert.ToString(comboBox_nam.SelectedItem);
            MaMH = textBox_addmamh.Text;

            //MessageBox.Show(HocKy + Nam + MaMH);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HocKy", HocKy);
                command.Parameters.AddWithValue("@Nam", Nam);
                command.Parameters.AddWithValue("@MaMH", MaMH);

                int result = command.ExecuteNonQuery();
               
                if (result > 0)
                {
                    MessageBox.Show("Data Inserted Successfull");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data not Inserted");
                }

                connection.Close();
            }
        }
    }
}
