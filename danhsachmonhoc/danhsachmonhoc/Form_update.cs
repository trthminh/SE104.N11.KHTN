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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace danhsachmonhoc
{
    public partial class Form_update : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True";
        string MaMH1, TenMH1, LoaiTinChi1, SoTiet1, MaNganh1, MaKhoa1;

        private void button_suadsmh_Click(object sender, EventArgs e)
        {
            MaMH1 = Convert.ToString(comboBox_mamh.SelectedItem);
            TenMH1 = Convert.ToString(comboBox_upd_tenmh.SelectedItem);
            LoaiTinChi1 = Convert.ToString(comboBox_upd_loaitinchi.SelectedItem);
            SoTiet1 = textBox_SoTiet.Text;
            MaNganh1 = Convert.ToString(comboBox_upd_nganh.SelectedItem);
            MaKhoa1 = Convert.ToString(comboBox_upd_khoa.SelectedItem);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE DSMH SET TenMH=@TenMH, LoaiTinChi=@LoaiTinChi, SoTiet=@SoTiet, MaNganh=@MaNganh, MaKhoa=@MaKhoa WHERE MaMH=@MaMH";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMH", MaMH1);
                command.Parameters.AddWithValue("@TenMH", TenMH1);
                command.Parameters.AddWithValue("@LoaiTinChi", LoaiTinChi1);
                command.Parameters.AddWithValue("@SoTiet", SoTiet1);
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

        public Form_update(string MaMH, string TenMH, string LoaiTinChi, string SoTiet, string MaNganh, string MaKhoa)
        {
            InitializeComponent();
            MaMH1 = MaMH;
            TenMH1 = TenMH;
            LoaiTinChi1 = LoaiTinChi;
            SoTiet1 = SoTiet;
            MaNganh1 = MaNganh;
            MaKhoa1 = MaKhoa;
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox_mamh.SelectedText = MaMH1;
            comboBox_upd_tenmh.SelectedItem = TenMH1;
            comboBox_upd_loaitinchi.SelectedText = LoaiTinChi1;
            textBox_SoTiet.Text = SoTiet1;
            comboBox_upd_nganh.SelectedItem = MaNganh1;
            comboBox_upd_khoa.SelectedItem = MaKhoa1;
        }


        private void button_dongsuadsmh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
