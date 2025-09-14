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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {

            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
        string Nguon = @"Data Source=.;Initial Catalog=QLKS;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;


        private void QuenMK_Load_1(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
        }



        private void btn_XacNhan_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textSDT.Text) || string.IsNullOrWhiteSpace(textTK.Text) || string.IsNullOrWhiteSpace(textMK.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ: Số điện thoại, Tài khoản và Mật khẩu ");
                return;
             }
    
            try
            {
                // ktra sdt có ko

                Lenh = @"SELECT COUNT(*) FROM NhanVien WHERE Sdt = @Sdt AND IsDeleted = 0"; // lấy tổng số dòng trong bảng thỏa mãn đk 

                ThucHien = new SqlCommand(Lenh, KetNoi);
                ThucHien.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = textSDT.Text.Trim();// gán ndung sau khi cắt khoảng trắng đầu cuối

                KetNoi.Open();
                int soLuong = (int)ThucHien.ExecuteScalar();
                KetNoi.Close();

                if (soLuong > 0)
                {
                    // update tk mk
                    Lenh = @"UPDATE NhanVien
                             SET TK = @TK, MK = @MK
                            WHERE Sdt = @Sdt AND IsDeleted = 0";

                    ThucHien = new SqlCommand(Lenh, KetNoi);
                    ThucHien.Parameters.Add("@TK", SqlDbType.NVarChar).Value = textTK.Text.Trim();// gán ndung sau khi cắt khoảng trắng đầu cuối
                    ThucHien.Parameters.Add("@MK", SqlDbType.NVarChar).Value = textMK.Text.Trim();// gán ndung sau khi cắt khoảng trắng đầu cuối
                    ThucHien.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = textSDT.Text.Trim();// gán ndung sau khi cắt khoảng trắng đầu cuối

                    KetNoi.Open();
                    int dongCapNhat = ThucHien.ExecuteNonQuery();
                    KetNoi.Close();

                    if (dongCapNhat > 0)
                        MessageBox.Show("Bạn đổi Tài khoản và Mật khẩu mới thành công");
                    else
                        MessageBox.Show("Lỗi cập nhật, Hãy thử lại");
                }
                else
                {
                    MessageBox.Show("Số điện thoại không trùng, hãy nhập lại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                if (KetNoi.State == ConnectionState.Open)
                    KetNoi.Close();
            }
        }
    }
}
