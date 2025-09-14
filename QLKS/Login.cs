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

namespace QLKS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select *from NhanVien where Tk='" + tk + "'and Mk='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home f = new Home();
                    f.Show();
                    this.Hide();
                }
                else if(txtMK.Text == ""||txtTK.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
            
        }
        //Thoát Login
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb==DialogResult.OK)
                Application.Exit();
        }
        // Show và Hide Pass
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                
                txtMK.UseSystemPasswordChar = true;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK qmk = new QuenMK();
            qmk.Show();
            this.Hide();
        }
    }
}
