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
    public partial class ThongTinChiTiet : Form
    {
        public ThongTinChiTiet()
        {
            InitializeComponent();
        }

        string Nguon = @"Data Source=.;Initial Catalog=QLKS;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void ThongTinChiTiet_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            HienThiThongTinChiTiet();
        }

        void HienThiThongTinChiTiet()
        {
            dataGridViewThongTin.Rows.Clear(); 


            Lenh = @"
        SELECT K.HoTenDem, K.Ten, K.Sdt, K.Email, K.Cccd, KP.LoaiPhong, P.SoPhong,
               NV.HoTenDem AS NV_HoTenDem, NV.Ten AS NV_Ten, NV.MaNV,
               DP.NgayDat, DP.NgayTra,
               HD.PhuongThucThanhToan, HD.TongTien
        FROM HoaDon HD
        JOIN DatPhong DP ON HD.IDDatPhong = DP.IDDatPhong
        JOIN Khach K ON DP.IDKhach = K.IDKhach
        JOIN NhanVien NV ON DP.IDNhanVien = NV.IDNhanVien
        JOIN Phong P ON DP.IDPhong = P.IDPhong
        JOIN KieuPhong KP ON P.IDLoaiPhong = KP.IDLoaiPhong";

            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();

            int i = 0;
            while (Doc.Read())
            {
                dataGridViewThongTin.Rows.Add();

                // Gộp Họ tên đầy đủ khách
                dataGridViewThongTin.Rows[i].Cells[0].Value = Doc["HoTenDem"].ToString() + " " + Doc["Ten"].ToString();

                dataGridViewThongTin.Rows[i].Cells[1].Value = Doc["Sdt"].ToString();
                dataGridViewThongTin.Rows[i].Cells[2].Value = Doc["Email"].ToString();
                dataGridViewThongTin.Rows[i].Cells[3].Value = Doc["Cccd"].ToString();
                dataGridViewThongTin.Rows[i].Cells[4].Value = Doc["LoaiPhong"].ToString();
                dataGridViewThongTin.Rows[i].Cells[5].Value = Doc["SoPhong"].ToString();

                // Gộp họ tên nhân viên trực
                dataGridViewThongTin.Rows[i].Cells[6].Value = Doc["NV_HoTenDem"].ToString() + " " + Doc["NV_Ten"].ToString();

                dataGridViewThongTin.Rows[i].Cells[7].Value = Doc["MaNV"].ToString();

                // Format ngày theo kiểu dd/MM/yyyy
                DateTime ngayDat = Convert.ToDateTime(Doc["NgayDat"]);
                DateTime ngayTra = Convert.ToDateTime(Doc["NgayTra"]);
                dataGridViewThongTin.Rows[i].Cells[8].Value = ngayDat.ToString("dd/MM/yyyy");
                dataGridViewThongTin.Rows[i].Cells[9].Value = ngayTra.ToString("dd/MM/yyyy");

                dataGridViewThongTin.Rows[i].Cells[10].Value = Doc["PhuongThucThanhToan"].ToString();
                dataGridViewThongTin.Rows[i].Cells[11].Value = Doc["TongTien"].ToString();

                i++;
            }

            KetNoi.Close();
        }

        void TimKiemTheoTenKhach()
        {
            dataGridViewThongTin.Rows.Clear();

            Lenh = @"
        SELECT K.HoTenDem, K.Ten, K.Sdt, K.Email, K.Cccd, KP.LoaiPhong, P.SoPhong,
               NV.HoTenDem AS NV_HoTenDem, NV.Ten AS NV_Ten, NV.MaNV,
               DP.NgayDat, DP.NgayTra,
               HD.PhuongThucThanhToan, HD.TongTien
        FROM HoaDon HD
        JOIN DatPhong DP ON HD.IDDatPhong = DP.IDDatPhong
        JOIN Khach K ON DP.IDKhach = K.IDKhach
        JOIN NhanVien NV ON DP.IDNhanVien = NV.IDNhanVien
        JOIN Phong P ON DP.IDPhong = P.IDPhong
        JOIN KieuPhong KP ON P.IDLoaiPhong = KP.IDLoaiPhong
        WHERE   (K.HoTenDem + ' ' + K.Ten) LIKE @keyword ";

            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@keyword", SqlDbType.NVarChar).Value = "%" + txtTimKiem.Text.Trim() + "%";

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();

            int i = 0;
            while (Doc.Read())
            {
                dataGridViewThongTin.Rows.Add();

                dataGridViewThongTin.Rows[i].Cells[0].Value = Doc["HoTenDem"].ToString() + " " + Doc["Ten"].ToString();
                dataGridViewThongTin.Rows[i].Cells[1].Value = Doc["Sdt"].ToString();
                dataGridViewThongTin.Rows[i].Cells[2].Value = Doc["Email"].ToString();
                dataGridViewThongTin.Rows[i].Cells[3].Value = Doc["Cccd"].ToString();
                dataGridViewThongTin.Rows[i].Cells[4].Value = Doc["LoaiPhong"].ToString();
                dataGridViewThongTin.Rows[i].Cells[5].Value = Doc["SoPhong"].ToString();
                dataGridViewThongTin.Rows[i].Cells[6].Value = Doc["NV_HoTenDem"].ToString() + " " + Doc["NV_Ten"].ToString();
                dataGridViewThongTin.Rows[i].Cells[7].Value = Doc["MaNV"].ToString();

                DateTime ngayDat = Convert.ToDateTime(Doc["NgayDat"]);
                DateTime ngayTra = Convert.ToDateTime(Doc["NgayTra"]);
                dataGridViewThongTin.Rows[i].Cells[8].Value = ngayDat.ToString("dd/MM/yyyy");
                dataGridViewThongTin.Rows[i].Cells[9].Value = ngayTra.ToString("dd/MM/yyyy");

                dataGridViewThongTin.Rows[i].Cells[10].Value = Doc["PhuongThucThanhToan"].ToString();
                dataGridViewThongTin.Rows[i].Cells[11].Value = Doc["TongTien"].ToString();

                i++;
            }

            KetNoi.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemTheoTenKhach();
        }
    }
}
