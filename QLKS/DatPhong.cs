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
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }
        string Nguon = @"Data Source=.;Initial Catalog=QLKS;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string hoVaTen = txtKhach.Text.Trim();
            string sdt = txtsdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cccd = txtCccd.Text.Trim();

            // Tách họ và tên
            string[] parts = hoVaTen.Split(' ');
            string ten = parts[parts.Length - 1]; // Tên là phần cuối
            string hoTenDem = string.Join(" ", parts, 0, parts.Length - 1); // Họ + tên đệm

            string Lenh = @"INSERT INTO KhachHang
                            (HoTenDem, Ten, Sdt, Email, Cccd)
                            VALUES (@HoTenDem, @Ten, @Sdt, @Email, @Cccd)";

            ThucHien.Parameters.Add("@HoTenDem", SqlDbType.NVarChar).Value = hoTenDem;
            ThucHien.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = ten;
            ThucHien.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = sdt;
            ThucHien.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            ThucHien.Parameters.Add("@Cccd", SqlDbType.NVarChar).Value = cccd;

            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi(); // Gọi hàm hiển thị lại danh sách nếu bạn có DataGridView  
        }
    }
}
