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
    public partial class QLPhong : Form
    {
        public QLPhong()
        {
            InitializeComponent();
        }

        string Nguon = @"Data Source=.;Initial Catalog=QLKS;Integrated Security=True";
        string Lenh = @"";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader Doc;

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewKP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void HienThiKP()
        {
            dataGridViewKP.Rows.Clear();
            Lenh = @"SELECT IDLoaiPhong, LoaiPhong, GiaTien
            FROM     KieuPhong";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();

            //KetNoi.Open();
            //Doc = ThucHien.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(Doc);
            //KetNoi.Close();

            //dataGridViewQLP.DataSource = dt;
            //dataGridViewQLP.Columns[0].Visible = false;

            int i = 0;
            while (Doc.Read())
            {
                dataGridViewKP.Rows.Add();
                dataGridViewKP.Rows[i].Cells[0].Value = Doc[0];
                dataGridViewKP.Rows[i].Cells[1].Value = Doc[1];
                dataGridViewKP.Rows[i].Cells[2].Value = Doc[2];
                dataGridViewKP.Columns[0].Visible = false;
                i++;
            }
            KetNoi.Close();
        }

        void HienThi()
        {
            dataGridViewQLP.Rows.Clear();
            Lenh = @"SELECT Phong.IDPhong, Phong.SoPhong, Phong.TinhTrang, KieuPhong.LoaiPhong, KieuPhong.GiaTien
FROM     Phong INNER JOIN
                  KieuPhong ON Phong.IDLoaiPhong = KieuPhong.IDLoaiPhong";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                dataGridViewQLP.Rows.Add();
                dataGridViewQLP.Rows[i].Cells[0].Value = Doc[0];
                dataGridViewQLP.Rows[i].Cells[1].Value = Doc[1];
                dataGridViewQLP.Rows[i].Cells[2].Value = Doc[2];
                dataGridViewQLP.Rows[i].Cells[3].Value = Doc[3];
                dataGridViewQLP.Rows[i].Cells[4].Value = Doc[4];
                dataGridViewQLP.Columns[0].Visible = false;
                i++;
            }
            KetNoi.Close();
        }
        private void QLPhong_Load(object sender, EventArgs e)
        {
            KetNoi = new SqlConnection(Nguon);
            comboBoxLoaiPhong.Items.Clear();
            comboBoxTinhTrang.Items.Clear();
            comboBoxTinhTrang.Items.Add("Trống");
            comboBoxTinhTrang.Items.Add("Bảo trì");
            Lenh = @"SELECT LoaiPhong, GiaTien
                    FROM     KieuPhong";
            ThucHien = new SqlCommand(Lenh, KetNoi);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                comboBoxLoaiPhong.Items.Add(Doc[0]);
                i++;
            }
            KetNoi.Close();
            HienThiKP();
            HienThi();
           
        }

        private void btn_KP_Them_Click(object sender, EventArgs e)
        {
            Lenh = @"INSERT INTO KieuPhong
                  (LoaiPhong, GiaTien)
            VALUES (@LoaiPhong,@GiaTien)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@GiaTien", SqlDbType.Decimal).Value = Convert.ToDecimal(textBoxGiaTien.Text);
            ThucHien.Parameters.Add("@LoaiPhong", SqlDbType.NVarChar).Value = textLoaiPhong.Text;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThiKP();
        }

        private void btn_KP_Sua_Click(object sender, EventArgs e)
        {
            Lenh = @"UPDATE KieuPhong
                        SET          LoaiPhong = @LoaiPhong, GiaTien = @GiaTien
                        WHERE  (IDLoaiPhong = @Original_IDLoaiPhong)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@GiaTien", SqlDbType.Decimal).Value = Convert.ToDecimal(textBoxGiaTien.Text);
            ThucHien.Parameters.Add("@LoaiPhong", SqlDbType.NVarChar).Value = textLoaiPhong.Text;
            ThucHien.Parameters.Add("@Original_IDLoaiPhong", SqlDbType.Int).Value = dataGridViewKP.CurrentRow.Cells[0].Value;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThiKP();
        }

        private void dataGridViewKP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textLoaiPhong.Text = dataGridViewKP.CurrentRow.Cells[1].Value.ToString();
            textBoxGiaTien.Text = dataGridViewKP.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_KP_Xoa_Click(object sender, EventArgs e)
        {
            Lenh = @"DELETE FROM KieuPhong
                     WHERE  (IDLoaiPhong = @Original_IDLoaiPhong)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@Original_IDLoaiPhong", SqlDbType.Int).Value = dataGridViewKP.CurrentRow.Cells[0].Value;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThiKP();
        }
        int ID_LoaiPhong;
        private void comboBoxLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lenh = @"SELECT IDLoaiPhong, GiaTien
                     FROM     KieuPhong
                     WHERE  (LoaiPhong = @Phong)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@Phong", SqlDbType.NVarChar).Value = comboBoxLoaiPhong.Text;
            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();
            while (Doc.Read())
            {
                lbGiaTien.Text = "Giá Tiền: " + Doc["GiaTien"].ToString() + " VND/Đêm";
                ID_LoaiPhong = Convert.ToInt32(Doc["IDLoaiPhong"]);
            }
            KetNoi.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Lenh = @"INSERT INTO Phong
                  (SoPhong, IDLoaiPhong, TinhTrang)
                    VALUES (@SoPhong,@IDLoaiPhong,@TinhTrang)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@SoPhong", SqlDbType.Int).Value = int.Parse(textSoPhong.Text);
            ThucHien.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = comboBoxTinhTrang.SelectedItem.ToString();
            ThucHien.Parameters.Add("@IDLoaiPhong", SqlDbType.Int).Value = ID_LoaiPhong;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Lenh = @"UPDATE Phong
                     SET          SoPhong = @SoPhong, IDLoaiPhong = @IDLoaiPhong, TinhTrang = @TinhTrang
                     WHERE  (IDPhong = @Original_IDPhong)";
            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@SoPhong", SqlDbType.Int).Value = int.Parse(textSoPhong.Text);
            ThucHien.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = comboBoxTinhTrang.SelectedItem.ToString();
            ThucHien.Parameters.Add("@IDLoaiPhong", SqlDbType.Int).Value = ID_LoaiPhong;
            ThucHien.Parameters.Add("@Original_IDPhong", SqlDbType.Int).Value = dataGridViewQLP.CurrentRow.Cells[0].Value;
            KetNoi.Open();
            ThucHien.ExecuteNonQuery();
            KetNoi.Close();
            HienThi();
        }

        private void dataGridViewQLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxLoaiPhong.Text = dataGridViewQLP.CurrentRow.Cells[3].Value.ToString();
            textSoPhong.Text = dataGridViewQLP.CurrentRow.Cells[1].Value.ToString();
            comboBoxTinhTrang.Text = dataGridViewQLP.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // 1. lấy ID phòng được chọn
            if (dataGridViewQLP.CurrentRow == null)  // chưa chọn dòng
            {
                MessageBox.Show("Hãy chọn phòng cần xóa.");
                return;
            }

            object cellValue = dataGridViewQLP.CurrentRow.Cells["IDPhong"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int idPhong))
            {
                MessageBox.Show("ID phòng không hợp lệ.");
                return;
            }

            // 2. Hỏi người dùng có chắc chắn xóa không
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?",
                                "Xác nhận xóa",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // 3. Thực hiện xóa trong database
            string connStr = "Data Source=.;Initial Catalog=QLKS;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Phong WHERE IDPhong = @id", conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idPhong;
                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    // 4. Thông báo kết quả
                    MessageBox.Show(rows > 0 ? "Xóa thành công!" : "Không tìm thấy phòng để xóa.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
            HienThi();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // lấy giá trị số phòng cần tìm
            string soPhongCanTim = textBoxTK.Text.Trim();

            // nếu người dùng không nhập gì -> hiển thị toàn bộ
            if (string.IsNullOrWhiteSpace(soPhongCanTim))
            {
                HienThi();
                return;
            }

            dataGridViewQLP.Rows.Clear();

            // lay du lieu tu sql
            Lenh = @"SELECT Phong.IDPhong, Phong.SoPhong, Phong.TinhTrang,
                    KieuPhong.LoaiPhong, KieuPhong.GiaTien
             FROM Phong
             INNER JOIN KieuPhong ON Phong.IDLoaiPhong = KieuPhong.IDLoaiPhong
             WHERE Phong.SoPhong = @SoPhong";   // tìm chính xác

            ThucHien = new SqlCommand(Lenh, KetNoi);
            ThucHien.Parameters.Add("@SoPhong", SqlDbType.Int).Value = int.Parse(soPhongCanTim);

            KetNoi.Open();
            Doc = ThucHien.ExecuteReader();

            int i = 0;
            while (Doc.Read())
            {
                dataGridViewQLP.Rows.Add();
                dataGridViewQLP.Rows[i].Cells[0].Value = Doc[0];
                dataGridViewQLP.Rows[i].Cells[1].Value = Doc[1];
                dataGridViewQLP.Rows[i].Cells[2].Value = Doc[2];
                dataGridViewQLP.Rows[i].Cells[3].Value = Doc[3];
                dataGridViewQLP.Rows[i].Cells[4].Value = Doc[4];
                dataGridViewQLP.Columns[0].Visible = false;
                i++;
            }
            KetNoi.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_KP_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
