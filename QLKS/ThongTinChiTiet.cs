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
using ClosedXML.Excel;

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

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView has any rows
            if (dataGridViewThongTin.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel Workbook|*.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                var ws = wb.Worksheets.Add("NhanVien");

                                // ===== Thêm tiêu đề "THỐNG KÊ" =====
                                // Ghi chữ tiêu đề vào ô A1
                                ws.Cell(1, 1).Value = "THỐNG KÊ DOANH THU";
                                // Gộp các ô tiêu đề trải dài hết số cột của DataGridView
                                ws.Range(1, 1, 1, dataGridViewThongTin.Columns.Count).Merge();
                                // Căn giữa, in đậm, tăng cỡ chữ
                                var titleRange = ws.Range(1, 1, 1, dataGridViewThongTin.Columns.Count);
                                titleRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                titleRange.Style.Font.Bold = true;
                                titleRange.Style.Font.FontSize = 16;

                                // ===== Ghi header bắt đầu từ hàng 2 =====
                                for (int i = 0; i < dataGridViewThongTin.Columns.Count; i++)
                                {
                                    ws.Cell(2, i + 1).Value = dataGridViewThongTin.Columns[i].HeaderText;
                                }

                                // ===== Ghi dữ liệu bắt đầu từ hàng 3 =====
                                for (int i = 0; i < dataGridViewThongTin.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataGridViewThongTin.Columns.Count; j++)
                                    {
                                        ws.Cell(i + 3, j + 1).Value = dataGridViewThongTin.Rows[i].Cells[j].Value?.ToString();
                                    }
                                }

                                // ===== Thêm border cho toàn bộ bảng (bao gồm header + dữ liệu) =====
                                var range = ws.Range(2, 1, dataGridViewThongTin.Rows.Count + 2, dataGridViewThongTin.Columns.Count);
                                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                                // Tự động co giãn cột
                                ws.Columns().AdjustToContents();

                                wb.SaveAs(sfd.FileName);
                                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
