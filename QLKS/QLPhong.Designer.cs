namespace QLKS
{
    partial class QLPhong
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
            this.tableLayoutPanelQLP = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanelbtn_NV = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.textBoxLoaiPhong = new System.Windows.Forms.TextBox();
            this.textBoxTinhTrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGiaTien = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelQLP.SuspendLayout();
            this.tableLayoutPanelbtn_NV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelQLP
            // 
            this.tableLayoutPanelQLP.ColumnCount = 4;
            this.tableLayoutPanelQLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelQLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelQLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelQLP.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelQLP.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanelQLP.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanelQLP.Controls.Add(this.tableLayoutPanelbtn_NV, 2, 5);
            this.tableLayoutPanelQLP.Controls.Add(this.textBoxLoaiPhong, 2, 2);
            this.tableLayoutPanelQLP.Controls.Add(this.textBoxTinhTrang, 2, 3);
            this.tableLayoutPanelQLP.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanelQLP.Controls.Add(this.textBoxSoPhong, 2, 1);
            this.tableLayoutPanelQLP.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanelQLP.Controls.Add(this.textBoxGiaTien, 2, 4);
            this.tableLayoutPanelQLP.Controls.Add(this.dataGridView1, 0, 6);
            this.tableLayoutPanelQLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQLP.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelQLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelQLP.Name = "tableLayoutPanelQLP";
            this.tableLayoutPanelQLP.RowCount = 7;
            this.tableLayoutPanelQLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanelQLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelQLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanelQLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanelQLP.Size = new System.Drawing.Size(1336, 734);
            this.tableLayoutPanelQLP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanelQLP.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1330, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng: ";
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
            this.tableLayoutPanelbtn_NV.Location = new System.Drawing.Point(403, 266);
            this.tableLayoutPanelbtn_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelbtn_NV.Name = "tableLayoutPanelbtn_NV";
            this.tableLayoutPanelbtn_NV.RowCount = 1;
            this.tableLayoutPanelbtn_NV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelbtn_NV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanelbtn_NV.Size = new System.Drawing.Size(795, 68);
            this.tableLayoutPanelbtn_NV.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(3, 2);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(192, 64);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(201, 2);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(192, 64);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(399, 2);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(192, 64);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(597, 2);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(195, 64);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // textBoxLoaiPhong
            // 
            this.textBoxLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoaiPhong.Location = new System.Drawing.Point(403, 152);
            this.textBoxLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoaiPhong.Name = "textBoxLoaiPhong";
            this.textBoxLoaiPhong.Size = new System.Drawing.Size(795, 34);
            this.textBoxLoaiPhong.TabIndex = 5;
            // 
            // textBoxTinhTrang
            // 
            this.textBoxTinhTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTinhTrang.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTinhTrang.Location = new System.Drawing.Point(403, 190);
            this.textBoxTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTinhTrang.Name = "textBoxTinhTrang";
            this.textBoxTinhTrang.Size = new System.Drawing.Size(795, 34);
            this.textBoxTinhTrang.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số phòng: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSoPhong
            // 
            this.textBoxSoPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSoPhong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoPhong.Location = new System.Drawing.Point(403, 114);
            this.textBoxSoPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoPhong.Name = "textBoxSoPhong";
            this.textBoxSoPhong.Size = new System.Drawing.Size(795, 34);
            this.textBoxSoPhong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá tiền: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxGiaTien
            // 
            this.textBoxGiaTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGiaTien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaTien.Location = new System.Drawing.Point(403, 228);
            this.textBoxGiaTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGiaTien.Name = "textBoxGiaTien";
            this.textBoxGiaTien.Size = new System.Drawing.Size(795, 34);
            this.textBoxGiaTien.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPhong,
            this.SoPhong,
            this.LoaiPhong,
            this.TinhTrang,
            this.GiaTien});
            this.tableLayoutPanelQLP.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 394);
            this.dataGridView1.TabIndex = 11;
            // 
            // IDPhong
            // 
            this.IDPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDPhong.HeaderText = "STT";
            this.IDPhong.Name = "IDPhong";
            this.IDPhong.ReadOnly = true;
            this.IDPhong.Width = 60;
            // 
            // SoPhong
            // 
            this.SoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.ReadOnly = true;
            this.SoPhong.Width = 95;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            this.LoaiPhong.Width = 105;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 103;
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 87;
            // 
            // QLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 734);
            this.Controls.Add(this.tableLayoutPanelQLP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLPhong";
            this.Text = "QLPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelQLP.ResumeLayout(false);
            this.tableLayoutPanelQLP.PerformLayout();
            this.tableLayoutPanelbtn_NV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQLP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelbtn_NV;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox textBoxLoaiPhong;
        private System.Windows.Forms.TextBox textBoxTinhTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGiaTien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;

    }
}