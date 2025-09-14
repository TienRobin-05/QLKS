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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        string Nguon = @"Data Source=.;Initial Catalog=QLKS;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        int currentIDDatPhong = 0;
        decimal currentGiaTien = 0;
        DateTime ngayDat;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);

            // thêm dsach thanh toán vào cbbox 
            comboBoxPTTT.Items.Clear();
            comboBoxPTTT.Items.Add("Tiền mặt");
            comboBoxPTTT.Items.Add("Chuyển khoản");
            comboBoxPTTT.Items.Add("Thẻ ngân hàng");

            HienThiPhongDangThue();
        }

        void HienThiPhongDangThue()
        {
            dataGridView1.Rows.Clear();
            Lenh = @"
                SELECT dp.IDDatPhong, k.HoTenDem + ' ' + k.Ten AS HoTenKhach, 
                       p.SoPhong, dp.NgayDat, kp.GiaTien
                FROM DatPhong dp
                INNER JOIN Khach k ON dp.IDKhach = k.IDKhach
                INNER JOIN Phong p ON dp.IDPhong = p.IDPhong
                INNER JOIN KieuPhong kp ON p.IDLoaiPhong = kp.IDLoaiPhong
                WHERE p.TinhTrang = N'Đang thuê' AND dp.IsDeleted = 0";

            ThucHien = new SqlCommand(Lenh, KetNoi);
            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();

            int i = 0;
            while (Doc.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Doc["IDDatPhong"];
                dataGridView1.Rows[i].Cells[1].Value = Doc["HoTenKhach"];
                dataGridView1.Rows[i].Cells[2].Value = Doc["SoPhong"];
                dataGridView1.Rows[i].Cells[3].Value = Doc["NgayDat"];
                dataGridView1.Rows[i].Cells[4].Value = Doc["GiaTien"];
                dataGridView1.Columns[0].Visible = false;  // ẩn cột ID đặt phòng
                i++;
            }
            KetNoi.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ng dùng click vào 1 ô datagridv 
            if (e.RowIndex >= 0)
            {
                txtTenKhach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); // gán khách
                txtSoPhong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); // gán số phòng
                txtNgayDat.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value).ToString("dd/MM/yyyy");
                currentGiaTien = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value); // lưu giá tiền
                currentIDDatPhong = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); // lưu ID
                ngayDat = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value); // lưu ngày đặt
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soNgay = (DateTime.Now - ngayDat).Days;   // ngày thuê = ngày hiện tại - ngày đặt
            if (soNgay == 0) soNgay = 1;  // nếu cùng 1 ngày, tính là 1 ngày

            decimal tongTien = soNgay * currentGiaTien; // tổng tiền = số ngày * giá tiền 1 ngày
            lbTongTien.Text = tongTien.ToString("N0") + " VND"; // hiện tổng tiền dạng VND
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIDDatPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng/phòng");
                return; // thoát ch chọn
            }
            if (comboBoxPTTT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán");
                return; // ch chọn thoát
            }

            KetNoi.Open();
            SqlTransaction tran = KetNoi.BeginTransaction();
            try
            {
                // 1. update NgayTra
                Lenh = @"UPDATE DatPhong SET NgayTra = @NgayTra WHERE IDDatPhong = @IDDatPhong";
                ThucHien = new SqlCommand(Lenh, KetNoi, tran);
                ThucHien.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = DateTime.Now;
                ThucHien.Parameters.Add("@IDDatPhong", SqlDbType.Int).Value = currentIDDatPhong;
                ThucHien.ExecuteNonQuery();

                // 2. update trạng thái phòng
                Lenh = @"UPDATE Phong 
                         SET TinhTrang = N'Trống'
                         WHERE IDPhong = (SELECT IDPhong FROM DatPhong WHERE IDDatPhong = @IDDatPhong)";
                ThucHien = new SqlCommand(Lenh, KetNoi, tran);
                ThucHien.Parameters.Add("@IDDatPhong", SqlDbType.Int).Value = currentIDDatPhong;
                ThucHien.ExecuteNonQuery();

                // 3. insert hóa đơn
                decimal tongTien = decimal.Parse(lbTongTien.Text.Replace(" VND", "").Replace(",", ""));
                Lenh = @"INSERT INTO HoaDon(IDDatPhong, TongTien, PhuongThucThanhToan, IsDeleted)
                         VALUES(@IDDatPhong, @TongTien, @PTTT)";
                ThucHien = new SqlCommand(Lenh, KetNoi, tran);
                ThucHien.Parameters.Add("@IDDatPhong", SqlDbType.Int).Value = currentIDDatPhong;
                ThucHien.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = tongTien;
                ThucHien.Parameters.Add("@PTTT", SqlDbType.NVarChar).Value = comboBoxPTTT.Text;
                ThucHien.ExecuteNonQuery();

                tran.Commit();
                MessageBox.Show("Thanh toán thành công!");
                KetNoi.Close();

                HienThiPhongDangThue();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                KetNoi.Close();
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
