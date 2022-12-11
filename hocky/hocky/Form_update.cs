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
    public partial class Form_update : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True";
        string HocKy1, Nam1, NgBatDau1, NgKetThuc1, HanDongHP1;

        private void button_nkt_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox2.Show();
        }

        private void buttonhanthuhp_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_ngaykt.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar4_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_hanthuhp.Text = monthCalendar4.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_nbd.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void button_xacnhan_Click(object sender, EventArgs e)
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

        private void button_xngroup3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void button_chonnbd_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox1.Show();
        }

        private void button_upd_data_Click(object sender, EventArgs e)
        {
            HocKy1 = numericUpDown2.Value.ToString();
            Nam1 = numericUpDown1.Value.ToString();
            NgBatDau1 = textBox_nbd.Text;
            NgKetThuc1 = textBox_ngaykt.Text;
            HanDongHP1 = textBox_hanthuhp.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE HOCKY SET NgBatDau=@NgBatDau, NgKetThuc=@NgKetThuc, HanDongHP=@HanDongHP WHERE HocKy=@HocKy AND Nam=@Nam";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HocKy", HocKy1);
                command.Parameters.AddWithValue("@Nam", Nam1);
                command.Parameters.AddWithValue("@NgBatDau", NgBatDau1);
                command.Parameters.AddWithValue("@NgKetThuc", NgKetThuc1);
                command.Parameters.AddWithValue("@HanDongHP", HanDongHP1);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công, vui lòng thử lại");
                }

                connection.Close();
            }
        }

        private void Form_update_Load(object sender, EventArgs e)
        {
            numericUpDown2.Value = Convert.ToInt64(HocKy1);
            numericUpDown1.Value= Convert.ToInt64(Nam1);
            textBox_nbd.Text = NgBatDau1;
            textBox_ngaykt.Text = NgKetThuc1;
            textBox_hanthuhp.Text = HanDongHP1;
        }

        public Form_update(string HocKy, string Nam, string NgBatDau, string NgKetThuc, string HanDongHP)
        {
            InitializeComponent();
            HocKy1= HocKy;
            Nam1= Nam;
            NgBatDau1= NgBatDau;
            NgKetThuc1= NgKetThuc;
            HanDongHP1= HanDongHP;
            groupBox1.Hide();
            groupBox2.Hide(); 
            groupBox3.Hide();
        }
    }
}
