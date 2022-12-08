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
    public partial class Form_filter : Form
    {
        public Form_filter()
        {
            InitializeComponent();
        }

        private void button_dong_filter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_confirm_filter_Click(object sender, EventArgs e)
        {
            string HocKy1, NamHoc1;

            HocKy1 = Convert.ToString(comboBox_filter_hk.SelectedItem);
            NamHoc1 = Convert.ToString(comboBox_filter_nam.SelectedItem);

            // load data

        }
    }
}
