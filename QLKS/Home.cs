using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            QLPhong p = new QLPhong();
            p.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            QLNhanVien nv = new QLNhanVien();
            nv.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
