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
    public partial class QLNhanVien : Form
    {

        public QLNhanVien()
        {
            InitializeComponent();
        }

        string Nguon = @"Data Source=.;Initial Catalog=QLKS;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
             // Lấy giá trị từ textbox
            string hoVaTen = textBoxTenNV.Text.Trim();

            // Tách họ tên
            string[] parts = hoVaTen.Split(' ');
            string ten = parts[parts.Length - 1]; // Lấy từ cuối là tên
            string hoTenDem = string.Join(" ", parts, 0, parts.Length - 1); // Các phần còn lại là họ + tên đệm
            Lenh = @"INSERT INTO NhanVien
                  (HoTenDem, Ten, MaNV, Sdt)
           VALUES (@HoTenDem,@Ten,@MaNV,@Sdt)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@HoTenDem", SqlDbType.NVarChar).Value = hoTenDem;
            ThucHien.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = ten;
            ThucHien.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = textBoxMaNV.Text;
            ThucHien.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = textBoxSDTNV.Text;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        void HienThi()
        {
            dataGridViewQLNV.Rows.Clear();
            Lenh = @"SELECT IDNhanVien, HoTenDem, Ten, MaNV, Sdt
         FROM NhanVien
         WHERE IsDeleted = 0";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridViewQLNV.Rows.Add();
                dataGridViewQLNV.Rows[i].Cells[0].Value = Doc[0];
                dataGridViewQLNV.Rows[i].Cells[1].Value = Doc[1];
                dataGridViewQLNV.Rows[i].Cells[2].Value = Doc[2];
                dataGridViewQLNV.Rows[i].Cells[3].Value = Doc[3];
                dataGridViewQLNV.Rows[i].Cells[4].Value = Doc[4];
                i++;
            }
            KetNoi.Close();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            HienThi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ textbox
            string hoVaTen = textBoxTenNV.Text.Trim();

            // Tách họ tên
            string[] parts = hoVaTen.Split(' ');
            string ten = parts[parts.Length - 1]; // Lấy từ cuối là tên
            string hoTenDem = string.Join(" ", parts, 0, parts.Length - 1); // Các phần còn lại là họ + tên đệm
            Lenh = @"UPDATE NhanVien
SET          HoTenDem = @HoTenDem, Ten = @Ten, MaNV = @MaNV, Sdt = @Sdt
WHERE  (IDNhanVien = @Original_IDNhanVien)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@HoTenDem", SqlDbType.NVarChar).Value = hoTenDem;
            ThucHien.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = ten;
            ThucHien.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = textBoxMaNV.Text;
            ThucHien.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = textBoxSDTNV.Text;
            ThucHien.Parameters.Add("@Original_IDNhanVien", SqlDbType.Int).Value = dataGridViewQLNV.CurrentRow.Cells[0].Value;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void dataGridViewQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var hoTenDem = dataGridViewQLNV.CurrentRow.Cells[1].Value.ToString();
            var ten = dataGridViewQLNV.CurrentRow.Cells[2].Value.ToString();

            // Nối HoTenDem + Ten vào 1 textbox
            textBoxTenNV.Text = string.IsNullOrEmpty(hoTenDem) ? ten : hoTenDem + " " + ten;

            // Nếu muốn, bạn cũng có thể điền các textbox khác
            textBoxMaNV.Text = dataGridViewQLNV.CurrentRow.Cells[3].Value.ToString();
            textBoxSDTNV.Text = dataGridViewQLNV.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            Lenh = @"UPDATE NhanVien
                    SET IsDeleted = 1
                    WHERE IDNhanVien = @Original_IDNhanVien;";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@Original_IDNhanVien", SqlDbType.Int).Value = dataGridViewQLNV.CurrentRow.Cells[0].Value;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }
    }
}
