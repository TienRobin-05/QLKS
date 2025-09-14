
namespace QLKS
{
    partial class ThongTinChiTiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewThongTin = new System.Windows.Forms.DataGridView();
            this.TenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.btnTimKiem, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewThongTin, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Exel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1321, 699);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1091, 95);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(126, 40);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(53, 95);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1032, 38);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1315, 92);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống Kê Doanh Thu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewThongTin
            // 
            this.dataGridViewThongTin.AllowUserToAddRows = false;
            this.dataGridViewThongTin.AllowUserToDeleteRows = false;
            this.dataGridViewThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhach,
            this.Sdt,
            this.Email,
            this.Cccd,
            this.LoaiPhong,
            this.SoPhong,
            this.TenNhanVien,
            this.MaNV,
            this.NgayDat,
            this.NgayTra,
            this.PTTT,
            this.TongTien});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewThongTin, 4);
            this.dataGridViewThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewThongTin.Location = new System.Drawing.Point(3, 141);
            this.dataGridViewThongTin.Name = "dataGridViewThongTin";
            this.dataGridViewThongTin.ReadOnly = true;
            this.dataGridViewThongTin.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridViewThongTin, 2);
            this.dataGridViewThongTin.RowTemplate.Height = 24;
            this.dataGridViewThongTin.Size = new System.Drawing.Size(1315, 524);
            this.dataGridViewThongTin.TabIndex = 3;
            // 
            // TenKhach
            // 
            this.TenKhach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenKhach.HeaderText = "Tên Khách Hàng";
            this.TenKhach.MinimumWidth = 6;
            this.TenKhach.Name = "TenKhach";
            this.TenKhach.ReadOnly = true;
            this.TenKhach.Width = 132;
            // 
            // Sdt
            // 
            this.Sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sdt.HeaderText = "Điện Thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            this.Sdt.Width = 98;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 71;
            // 
            // Cccd
            // 
            this.Cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cccd.HeaderText = "Căn Cước Công Dân";
            this.Cccd.MinimumWidth = 6;
            this.Cccd.Name = "Cccd";
            this.Cccd.ReadOnly = true;
            this.Cccd.Width = 127;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            // 
            // SoPhong
            // 
            this.SoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoPhong.HeaderText = "Số PHòng";
            this.SoPhong.MinimumWidth = 6;
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.ReadOnly = true;
            this.SoPhong.Width = 93;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNhanVien.HeaderText = "Nhân Viên Trực";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            this.TenNhanVien.Width = 99;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 56;
            // 
            // NgayDat
            // 
            this.NgayDat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayDat.HeaderText = "Ngày Đặt Phòng";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.ReadOnly = true;
            this.NgayDat.Width = 129;
            // 
            // NgayTra
            // 
            this.NgayTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayTra.HeaderText = "Ngày Trả Phòng";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            this.NgayTra.Width = 129;
            // 
            // PTTT
            // 
            this.PTTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PTTT.HeaderText = "Trả Bằng";
            this.PTTT.MinimumWidth = 6;
            this.PTTT.Name = "PTTT";
            this.PTTT.ReadOnly = true;
            this.PTTT.Width = 89;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 94;
            // 
            // btn_Exel
            // 
            this.btn_Exel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Exel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exel.Location = new System.Drawing.Point(1091, 670);
            this.btn_Exel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exel.Name = "btn_Exel";
            this.btn_Exel.Size = new System.Drawing.Size(126, 27);
            this.btn_Exel.TabIndex = 4;
            this.btn_Exel.Text = "Xuất Exel";
            this.btn_Exel.UseVisualStyleBackColor = true;
            this.btn_Exel.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1223, 670);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ThongTinChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 699);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongTinChiTiet";
            this.Text = "ThongTinChiTiet";
            this.Load += new System.EventHandler(this.ThongTinChiTiet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btn_Exel;
        private System.Windows.Forms.Button button1;
    }
}