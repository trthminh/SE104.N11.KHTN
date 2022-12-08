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

namespace chuongtrinhhoc
{
    public partial class Form_update : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True";

        string HocKy1, MaNganh1, MaKhoa1, Nam1, GhiChu1, MaMH1;

        private void button_upd_cth_done_Click(object sender, EventArgs e)
        {
            MaNganh1 = Convert.ToString(comboBox_upd_nganh.SelectedItem);
            MaKhoa1 = Convert.ToString(comboBox_upd_khoa.SelectedItem);
            HocKy1 = Convert.ToString(comboBox_upd_hocky.SelectedItem);
            Nam1 = Convert.ToString(comboBox_upd_nam.SelectedItem);
            MaMH1 = Convert.ToString(comboBox_upd_mamh.SelectedItem);
            GhiChu1 = textBox_upd_ghichu.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE CTHOC SET MaNganh=@MaNganh, MaKhoa=@MaKhoa, GhiChu=@GhiChu WHERE MaMH=@MaMH AND HocKy=@HocKy AND Nam=@Nam ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMH", MaMH1);
                command.Parameters.AddWithValue("@HocKy", HocKy1);
                command.Parameters.AddWithValue("@Nam", Nam1);
                command.Parameters.AddWithValue("@GhiChu", GhiChu1);
                command.Parameters.AddWithValue("@MaNganh", MaNganh1);
                command.Parameters.AddWithValue("@MaKhoa", MaKhoa1);
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

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox_upd_nganh.SelectedItem= MaNganh1;
            comboBox_upd_khoa.SelectedItem = MaKhoa1;
            textBox_upd_ghichu.Text = GhiChu1;
            comboBox_upd_hocky.SelectedItem= HocKy1;
            comboBox_upd_nam.SelectedItem = Nam1;
            comboBox_upd_mamh.SelectedText= MaMH1;
            //comboBox_upd_mamh.SelectedItem = MaMH1;
        }
        public Form_update(string HocKy, string Nam, string MaMH, string MaNganh, string MaKhoa, string GhiChu)
        {
            InitializeComponent();
            MaNganh1 = MaNganh;
            MaKhoa1= MaKhoa;
            HocKy1= HocKy;
            Nam1= Nam;
            GhiChu1= GhiChu;
            MaMH1= MaMH;
        }

        private void button_dongthemcthoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
