namespace QLKS
{
    partial class QLNhanVien
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
            this.tableLayoutPanelQLNV = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanelbtn_NV = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dataGridViewQLNV = new System.Windows.Forms.DataGridView();
            this.textBoxTenNV = new System.Windows.Forms.TextBox();
            this.textBoxSDTNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelQLNV.SuspendLayout();
            this.tableLayoutPanelbtn_NV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelQLNV
            // 
            this.tableLayoutPanelQLNV.ColumnCount = 4;
            this.tableLayoutPanelQLNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelQLNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQLNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelQLNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelQLNV.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelQLNV.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanelQLNV.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanelQLNV.Controls.Add(this.tableLayoutPanelbtn_NV, 2, 4);
            this.tableLayoutPanelQLNV.Controls.Add(this.dataGridViewQLNV, 0, 5);
            this.tableLayoutPanelQLNV.Controls.Add(this.textBoxTenNV, 2, 2);
            this.tableLayoutPanelQLNV.Controls.Add(this.textBoxSDTNV, 2, 3);
            this.tableLayoutPanelQLNV.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanelQLNV.Controls.Add(this.textBoxMaNV, 2, 1);
            this.tableLayoutPanelQLNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQLNV.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelQLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelQLNV.Name = "tableLayoutPanelQLNV";
            this.tableLayoutPanelQLNV.RowCount = 6;
            this.tableLayoutPanelQLNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanelQLNV.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQLNV.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQLNV.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQLNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanelQLNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanelQLNV.Size = new System.Drawing.Size(1356, 580);
            this.tableLayoutPanelQLNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanelQLNV.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1350, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanelbtn_NV
            // 
            this.tableLayoutPanelbtn_NV.ColumnCount = 4;
            this.tableLayoutPanelbtn_NV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelbtn_NV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelbtn_NV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelbtn_NV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelbtn_NV.Controls.Add(this.btn_Them, 0, 0);
            this.tableLayoutPanelbtn_NV.Controls.Add(this.btn_Sua, 1, 0);
            this.tableLayoutPanelbtn_NV.Controls.Add(this.btn_Xoa, 2, 0);
            this.tableLayoutPanelbtn_NV.Controls.Add(this.btn_Thoat, 3, 0);
            this.tableLayoutPanelbtn_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelbtn_NV.Location = new System.Drawing.Point(409, 228);
            this.tableLayoutPanelbtn_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelbtn_NV.Name = "tableLayoutPanelbtn_NV";
            this.tableLayoutPanelbtn_NV.RowCount = 1;
            this.tableLayoutPanelbtn_NV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelbtn_NV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanelbtn_NV.Size = new System.Drawing.Size(807, 68);
            this.tableLayoutPanelbtn_NV.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(3, 2);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(195, 64);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(204, 2);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(195, 64);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(405, 2);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(195, 64);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(606, 2);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(198, 64);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQLNV
            // 
            this.dataGridViewQLNV.AllowUserToAddRows = false;
            this.dataGridViewQLNV.AllowUserToDeleteRows = false;
            this.dataGridViewQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNV,
            this.HoTenDem,
            this.Ten,
            this.MaNV,
            this.SDT});
            this.tableLayoutPanelQLNV.SetColumnSpan(this.dataGridViewQLNV, 4);
            this.dataGridViewQLNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQLNV.Location = new System.Drawing.Point(3, 300);
            this.dataGridViewQLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewQLNV.Name = "dataGridViewQLNV";
            this.dataGridViewQLNV.ReadOnly = true;
            this.dataGridViewQLNV.RowTemplate.Height = 28;
            this.dataGridViewQLNV.Size = new System.Drawing.Size(1350, 278);
            this.dataGridViewQLNV.TabIndex = 4;
            this.dataGridViewQLNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQLNV_CellClick);
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTenNV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenNV.Location = new System.Drawing.Point(409, 152);
            this.textBoxTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.Size = new System.Drawing.Size(807, 34);
            this.textBoxTenNV.TabIndex = 5;
            // 
            // textBoxSDTNV
            // 
            this.textBoxSDTNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSDTNV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSDTNV.Location = new System.Drawing.Point(409, 190);
            this.textBoxSDTNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSDTNV.Name = "textBoxSDTNV";
            this.textBoxSDTNV.Size = new System.Drawing.Size(807, 34);
            this.textBoxSDTNV.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã nhân viên: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMaNV.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNV.Location = new System.Drawing.Point(409, 114);
            this.textBoxMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(807, 34);
            this.textBoxMaNV.TabIndex = 8;
            // 
            // IDNV
            // 
            this.IDNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDNV.HeaderText = "STT";
            this.IDNV.Name = "IDNV";
            this.IDNV.ReadOnly = true;
            this.IDNV.Width = 60;
            // 
            // HoTenDem
            // 
            this.HoTenDem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoTenDem.HeaderText = "Họ Tên Đệm";
            this.HoTenDem.Name = "HoTenDem";
            this.HoTenDem.ReadOnly = true;
            this.HoTenDem.Width = 113;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 58;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 122;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 123;
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 580);
            this.Controls.Add(this.tableLayoutPanelQLNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            this.tableLayoutPanelQLNV.ResumeLayout(false);
            this.tableLayoutPanelQLNV.PerformLayout();
            this.tableLayoutPanelbtn_NV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQLNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelbtn_NV;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView dataGridViewQLNV;
        private System.Windows.Forms.TextBox textBoxTenNV;
        private System.Windows.Forms.TextBox textBoxSDTNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}