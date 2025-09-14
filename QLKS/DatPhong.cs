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
        private DbHandle db = new DbHandle();
        public DatPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtKhach.Text.Trim();
            string sdt = txtsdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cccd = txtCccd.Text.Trim();

            // Lấy ID từ combobox
            int idNhanVien = (cboMaNV.SelectedValue != null) ? Convert.ToInt32(cboMaNV.SelectedValue) : 0;
            int idLoaiPhong = (cboLoaiPhong.SelectedValue != null) ? Convert.ToInt32(cboLoaiPhong.SelectedValue) : 0;
            int idPhong = (cboSoPhong.SelectedValue != null) ? Convert.ToInt32(cboSoPhong.SelectedValue) : 0;

            // Tách họ và tên
            string[] parts = hoVaTen.Split(' ');
            string ten = parts[parts.Length - 1];
            string hoTenDem = string.Join(" ", parts, 0, parts.Length - 1);

            // 1. Thêm khách mới + lấy ID vừa thêm
            string sqlThemKhach = $@"
                INSERT INTO Khach (HoTenDem, Ten, Sdt, Email, Cccd, IsDeleted) 
                VALUES (N'{hoTenDem}', N'{ten}', '{sdt}', '{email}', '{cccd}', 0);

                SELECT SCOPE_IDENTITY() AS IDKhach;
            ";

            DataTable dt = db.GetData(sqlThemKhach);

            int idKhach = Convert.ToInt32(dt.Rows[0]["IDKhach"]);



            // 2. Thêm vào bảng đặt phòng
            string sqlDatPhong = $@"
                INSERT INTO DatPhong (IDKhach, IDNhanVien, IDPhong, NgayDat, NgayTra, IsDeleted)
                VALUES ({idKhach}, {idNhanVien}, {idPhong}, GETDATE(), DATEADD(DAY, 1, GETDATE()), 0)
            ";
            db.Command(sqlDatPhong);

            // 3. Cập nhật trạng thái phòng thành "Đang thuê"
            string sqlCapNhatPhong = $@"
                UPDATE Phong SET TinhTrang = N'Đang thuê' WHERE IDPhong = {idPhong}
            ";
            db.Command(sqlCapNhatPhong);

            MessageBox.Show("Đặt phòng thành công!");

            HienThi();
        }


        private void HienThi()
        {
            DataTable dt = db.GetData(@"
                SELECT 
                    dp.IDDatPhong,
                    dp.IDKhach,
                    dp.IDNhanVien,
                    dp.IDPhong,
                    p.IDLoaiPhong,
                    ROW_NUMBER() OVER (ORDER BY dp.IDDatPhong) AS STT,
                    k.HoTenDem + ' ' + k.Ten AS HoTen,
                    k.Sdt AS SoDienThoai,
                    k.Email,
                    k.Cccd,
                    nv.MaNV,
                    lp.LoaiPhong,
                    p.SoPhong
                FROM DatPhong dp
                LEFT JOIN Khach k ON dp.IDKhach = k.IDKhach
                LEFT JOIN Phong p ON dp.IDPhong = p.IDPhong
                LEFT JOIN KieuPhong lp ON p.IDLoaiPhong = lp.IDLoaiPhong
                LEFT JOIN NhanVien nv ON dp.IDNhanVien = nv.IDNhanVien
                WHERE dp.IsDeleted = 0;
            ");

            dataGridViewDP.DataSource = dt;

            // Đặt tiêu đề có dấu cho cột
            dataGridViewDP.Columns["STT"].HeaderText = "STT";
            dataGridViewDP.Columns["HoTen"].HeaderText = "Tên Khách";
            dataGridViewDP.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dataGridViewDP.Columns["Email"].HeaderText = "Email";
            dataGridViewDP.Columns["Cccd"].HeaderText = "CCCD";
            dataGridViewDP.Columns["SoPhong"].HeaderText = "Số Phòng";
            dataGridViewDP.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            dataGridViewDP.Columns["MaNV"].HeaderText = "Mã Nhân Viên";

            // Ẩn các cột ID nếu không muốn hiển thị
            dataGridViewDP.Columns["IDDatPhong"].Visible = false;
            dataGridViewDP.Columns["IDKhach"].Visible = false;
            dataGridViewDP.Columns["IDNhanVien"].Visible = false;
            dataGridViewDP.Columns["IDPhong"].Visible = false;
            dataGridViewDP.Columns["IDLoaiPhong"].Visible = false;
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            var danhSachMaNV = db.GetData(@"
                SELECT IDNhanVien, MaNV FROM NhanVien WHERE IsDeleted = 0
            ");
            cboMaNV.DataSource = danhSachMaNV;
            cboMaNV.DisplayMember = "MaNV";      
            cboMaNV.ValueMember = "IDNhanVien";
            HienThi();
            var danhSachLoaiPhong = db.GetData(
                "SELECT IDLoaiPhong, LoaiPhong\r\nFROM KieuPhong;"
                );
            cboLoaiPhong.DataSource = danhSachLoaiPhong;
            cboLoaiPhong.DisplayMember = "LoaiPhong";
            cboLoaiPhong.ValueMember = "IDLoaiPhong";
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiPhong.SelectedValue == null || cboLoaiPhong.SelectedValue is DataRowView)
                return;

            int idLoaiPhong;
            if (!int.TryParse(cboLoaiPhong.SelectedValue.ToString(), out idLoaiPhong))
                return;

            var danhachPhong = db.GetData($@"
                    SELECT IDPhong, SoPhong, TinhTrang
                    FROM Phong
                    WHERE IsDeleted = 0
                      AND IDLoaiPhong = {idLoaiPhong}
                      AND TinhTrang != 'DANG_THUE'
                ");

            cboSoPhong.DataSource = danhachPhong;
            cboSoPhong.DisplayMember = "SoPhong";
            cboSoPhong.ValueMember = "IDPhong";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dataGridViewDP.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần sửa!");
                return;
            }

            // Lấy IDDatPhong từ dòng chọn
            int idDatPhong = Convert.ToInt32(dataGridViewDP.CurrentRow.Cells["IDDatPhong"].Value);

            string hoVaTen = txtKhach.Text.Trim();
            string sdt = txtsdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cccd = txtCccd.Text.Trim();

            // Lấy ID từ combobox
            int idNhanVien = (cboMaNV.SelectedValue != null) ? Convert.ToInt32(cboMaNV.SelectedValue) : 0;
            int idPhongMoi = (cboSoPhong.SelectedValue != null) ? Convert.ToInt32(cboSoPhong.SelectedValue) : 0;

            // Tách họ và tên
            string[] parts = hoVaTen.Split(' ');
            string ten = parts[parts.Length - 1];
            string hoTenDem = string.Join(" ", parts, 0, parts.Length - 1);

            // 1. Lấy IDKhach, IDPhong cũ từ DatPhong
            DataTable dt = db.GetData($@"
                SELECT IDKhach, IDPhong 
                FROM DatPhong 
                WHERE IDDatPhong = {idDatPhong}
            ");
            if (dt.Rows.Count == 0) return;

            int idKhach = Convert.ToInt32(dt.Rows[0]["IDKhach"]);
            int idPhongCu = Convert.ToInt32(dt.Rows[0]["IDPhong"]);

            // 2. Update thông tin khách
            string sqlSuaKhach = $@"
                UPDATE Khach 
                SET HoTenDem = N'{hoTenDem}', Ten = N'{ten}', 
                    Sdt = '{sdt}', Email = '{email}', Cccd = '{cccd}'
                WHERE IDKhach = {idKhach}
            ";
            db.Command(sqlSuaKhach);

            // 3. Update bảng DatPhong
            string sqlSuaDatPhong = $@"
                UPDATE DatPhong 
                SET IDNhanVien = {idNhanVien}, 
                    IDPhong = {idPhongMoi}
                WHERE IDDatPhong = {idDatPhong}
            ";
            db.Command(sqlSuaDatPhong);

            // 4. Nếu đổi phòng thì cập nhật trạng thái phòng
            if (idPhongCu != idPhongMoi)
            {
                // Phòng cũ thành "Trống"
                db.Command($"UPDATE Phong SET TinhTrang = N'Trống' WHERE IDPhong = {idPhongCu}");
                // Phòng mới thành "Đang thuê"
                db.Command($"UPDATE Phong SET TinhTrang = N'Đang thuê' WHERE IDPhong = {idPhongMoi}");
            }

            MessageBox.Show("Sửa thông tin đặt phòng thành công!");
            HienThi();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewDP.Rows[e.RowIndex];

            // Gán dữ liệu vào TextBox
            txtKhach.Text = row.Cells["HoTen"].Value?.ToString();   // cột HoTen (hoặc HoTenDem + Ten)
            txtsdt.Text = row.Cells["SoDienThoai"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtCccd.Text = row.Cells["Cccd"].Value?.ToString();

            // Nếu bạn có cột IDNhanVien, IDLoaiPhong, IDPhong trong DataGridView
            if (row.Cells["IDNhanVien"].Value != null)
                cboMaNV.SelectedValue = Convert.ToInt32(row.Cells["IDNhanVien"].Value);

            if (row.Cells["IDLoaiPhong"].Value != null)
                cboLoaiPhong.SelectedValue = Convert.ToInt32(row.Cells["IDLoaiPhong"].Value);

            if (row.Cells["IDPhong"].Value != null)
                cboSoPhong.SelectedValue = Convert.ToInt32(row.Cells["IDPhong"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDP.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần xóa!");
                return;
            }

            // Hỏi lại người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa bản ghi này?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            // Lấy IDDatPhong và IDPhong từ dòng chọn
            int idDatPhong = Convert.ToInt32(dataGridViewDP.CurrentRow.Cells["IDDatPhong"].Value);
            int idPhong = Convert.ToInt32(dataGridViewDP.CurrentRow.Cells["IDPhong"].Value);

            // 1. Đánh dấu xóa trong DatPhong
            string sqlXoa = $@"
                UPDATE DatPhong
                SET IsDeleted = 1
                WHERE IDDatPhong = {idDatPhong}
            ";
            db.Command(sqlXoa);

            // 2. Cập nhật phòng thành "Trống"
            string sqlPhong = $@"
                UPDATE Phong
                SET TinhTrang = N'Trống'
                WHERE IDPhong = {idPhong}
            ";
            db.Command(sqlPhong);

            MessageBox.Show("Xóa đặt phòng thành công!");

            // 3. Load lại dữ liệu
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = db.GetData($@"
        SELECT 
        dp.IDDatPhong,
        dp.IDKhach,
        dp.IDNhanVien,
        dp.IDPhong,
        p.IDLoaiPhong,
        ROW_NUMBER() OVER (ORDER BY dp.IDDatPhong) AS STT,
        k.HoTenDem + ' ' + k.Ten AS HoTen,
        k.Sdt AS SoDienThoai,
        k.Email,
        k.Cccd,
        nv.MaNV,
        lp.LoaiPhong,
        p.SoPhong
    FROM DatPhong dp
    LEFT JOIN Khach k ON dp.IDKhach = k.IDKhach
    LEFT JOIN Phong p ON dp.IDPhong = p.IDPhong
    LEFT JOIN KieuPhong lp ON p.IDLoaiPhong = lp.IDLoaiPhong
    LEFT JOIN NhanVien nv ON dp.IDNhanVien = nv.IDNhanVien
    WHERE dp.IsDeleted = 0 AND p.SoPhong = {textBoxTK.Text};
");

            dataGridViewDP.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
