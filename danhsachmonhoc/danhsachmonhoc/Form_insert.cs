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
    public partial class Form_insert : Form
    {
        string connectionString = @"Data Source=minh\minhtt;Initial Catalog=DKMHandTHUHP;Integrated Security=True;";
        public Form_insert()
        {
            InitializeComponent();
        }

        private void button_dongthemdsmh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_themdsmh_Click(object sender, EventArgs e)
        {
            string MaMH1, TenMH1, LoaiTinChi1, SoTiet1, MaNganh1, MaKhoa1;
            string query = "INSERT INTO DSMH (MaMH,TenMH,LoaiTinChi,SoTiet, MaNganh, MaKhoa) VALUES (@MaMH, @TenMH, @LoaiTinChi, @SoTiet, @MaNganh, @MaKhoa)";

            MaMH1 = Convert.ToString(comboBox_mamh.SelectedItem);
            TenMH1 = Convert.ToString(comboBox_upd_tenmh.SelectedItem);
            LoaiTinChi1 = Convert.ToString(comboBox_upd_loaitinchi.SelectedItem);
            SoTiet1 = textBox_addSoTiet.Text;
            MaNganh1 = Convert.ToString(comboBox_upd_nganh.SelectedItem);
            MaKhoa1 = Convert.ToString(comboBox_upd_khoa.SelectedItem);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
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
