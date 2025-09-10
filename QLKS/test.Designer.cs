
namespace QLKS
{
    partial class test
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textLoaiPhong = new System.Windows.Forms.TextBox();
            this.textBoxGiaTien = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_KP_Xoa = new System.Windows.Forms.Button();
            this.btn_KP_Thoat = new System.Windows.Forms.Button();
            this.btn_KP_Them = new System.Windows.Forms.Button();
            this.btn_KP_Sua = new System.Windows.Forms.Button();
            this.dataGridViewKP = new System.Windows.Forms.DataGridView();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKP)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.629629F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.14815F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textLoaiPhong, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxGiaTien, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewKP, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 3);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(660, 55);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kiểu Phòng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Loại Phòng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giá Tiền";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textLoaiPhong
            // 
            this.textLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLoaiPhong.Location = new System.Drawing.Point(225, 58);
            this.textLoaiPhong.Name = "textLoaiPhong";
            this.textLoaiPhong.Size = new System.Drawing.Size(438, 22);
            this.textLoaiPhong.TabIndex = 3;
            // 
            // textBoxGiaTien
            // 
            this.textBoxGiaTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGiaTien.Location = new System.Drawing.Point(225, 86);
            this.textBoxGiaTien.Name = "textBoxGiaTien";
            this.textBoxGiaTien.Size = new System.Drawing.Size(438, 22);
            this.textBoxGiaTien.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_KP_Xoa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_KP_Thoat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_KP_Them, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_KP_Sua, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(225, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 46);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_KP_Xoa
            // 
            this.btn_KP_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KP_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KP_Xoa.Location = new System.Drawing.Point(221, 3);
            this.btn_KP_Xoa.Name = "btn_KP_Xoa";
            this.btn_KP_Xoa.Size = new System.Drawing.Size(103, 40);
            this.btn_KP_Xoa.TabIndex = 4;
            this.btn_KP_Xoa.Text = "Xóa";
            this.btn_KP_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_KP_Thoat
            // 
            this.btn_KP_Thoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KP_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KP_Thoat.Location = new System.Drawing.Point(330, 3);
            this.btn_KP_Thoat.Name = "btn_KP_Thoat";
            this.btn_KP_Thoat.Size = new System.Drawing.Size(105, 40);
            this.btn_KP_Thoat.TabIndex = 3;
            this.btn_KP_Thoat.Text = "Thoát";
            this.btn_KP_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_KP_Them
            // 
            this.btn_KP_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KP_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KP_Them.Location = new System.Drawing.Point(3, 3);
            this.btn_KP_Them.Name = "btn_KP_Them";
            this.btn_KP_Them.Size = new System.Drawing.Size(103, 40);
            this.btn_KP_Them.TabIndex = 2;
            this.btn_KP_Them.Text = "Thêm";
            this.btn_KP_Them.UseVisualStyleBackColor = true;
            // 
            // btn_KP_Sua
            // 
            this.btn_KP_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KP_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KP_Sua.Location = new System.Drawing.Point(112, 3);
            this.btn_KP_Sua.Name = "btn_KP_Sua";
            this.btn_KP_Sua.Size = new System.Drawing.Size(103, 40);
            this.btn_KP_Sua.TabIndex = 1;
            this.btn_KP_Sua.Text = "Sửa";
            this.btn_KP_Sua.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKP
            // 
            this.dataGridViewKP.AllowUserToAddRows = false;
            this.dataGridViewKP.AllowUserToDeleteRows = false;
            this.dataGridViewKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiPhong,
            this.GiaTien});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridViewKP, 4);
            this.dataGridViewKP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKP.Location = new System.Drawing.Point(3, 166);
            this.dataGridViewKP.Name = "dataGridViewKP";
            this.dataGridViewKP.ReadOnly = true;
            this.dataGridViewKP.RowHeadersWidth = 51;
            this.dataGridViewKP.RowTemplate.Height = 24;
            this.dataGridViewKP.Size = new System.Drawing.Size(794, 281);
            this.dataGridViewKP.TabIndex = 6;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            this.LoaiPhong.Width = 109;
            // 
            // GiaTien
            // 
            this.GiaTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GiaTien.HeaderText = "Giá TIền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 91;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "test";
            this.Text = "test";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textLoaiPhong;
        private System.Windows.Forms.TextBox textBoxGiaTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_KP_Xoa;
        private System.Windows.Forms.Button btn_KP_Thoat;
        private System.Windows.Forms.Button btn_KP_Them;
        private System.Windows.Forms.Button btn_KP_Sua;
        private System.Windows.Forms.DataGridView dataGridViewKP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
    }
}