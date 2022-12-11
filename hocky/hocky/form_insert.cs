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
    public partial class form_insert : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True;";
        public form_insert()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_nbd.Text=monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox1.Show();
        }

        private void button_close_calendar_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            textBox_nbd.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_ngaykt.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void buttonhanthuhp_Click(object sender, EventArgs e)
        {
            groupBox3.Show();
            groupBox1.Hide();
            groupBox2.Hide();
            
            
        }

        private void button_nkt_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox2.Show();
        }

        private void button_xngroup3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void button_xn_group2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();

        }

        private void monthCalendar4_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_hanthuhp.Text = monthCalendar4.SelectionRange.Start.ToShortDateString();
        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            string HocKy, Nam, NgBatDau, NgKetThuc, HanDongHP;
            string query = "INSERT INTO HOCKY (HocKy,Nam,NgBatDau,NgKetThuc, HanDongHP) VALUES (@HocKy, @Nam, @NgBatDau, @NgKetThuc, @HanDongHP)";

            //HocKy = Convert.ToString(comboBox_hocky.SelectedItem);
            //Nam = Convert.ToString(comboBox_nam.SelectedItem);
            HocKy = numericUpDown2.Value.ToString();
            Nam = numericUpDown1.Value.ToString();
            NgBatDau = textBox_nbd.Text;
            NgKetThuc = textBox_ngaykt.Text;
            HanDongHP = textBox_hanthuhp.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HocKy", HocKy);
                command.Parameters.AddWithValue("@Nam", Nam);
                command.Parameters.AddWithValue("@NgBatDau", NgBatDau);
                command.Parameters.AddWithValue("@NgKetThuc", NgKetThuc);
                command.Parameters.AddWithValue("@HanDongHP", HanDongHP);
                var setDateFormat = new SqlCommand("set dateformat dmy", connection);
                setDateFormat.ExecuteNonQuery();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thành công, vui lòng thử lại");
                }

                connection.Close();
            }
        }
    }
}
