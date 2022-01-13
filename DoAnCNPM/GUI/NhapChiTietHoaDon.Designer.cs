namespace QLPMT
{
    partial class NhapChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapChiTietHoaDon));
            this.dgvNhapHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTienThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTienKham = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbHoTenBN = new System.Windows.Forms.TextBox();
            this.tbMaBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.Label();
            this.tbTenthuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGiaThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTTSV = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tbMaHoaDon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhapHoaDon
            // 
            this.dgvNhapHoaDon.AllowUserToAddRows = false;
            this.dgvNhapHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaBN,
            this.TienKham,
            this.TienThuoc});
            this.dgvNhapHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhapHoaDon.Location = new System.Drawing.Point(0, 351);
            this.dgvNhapHoaDon.Name = "dgvNhapHoaDon";
            this.dgvNhapHoaDon.RowHeadersWidth = 62;
            this.dgvNhapHoaDon.RowTemplate.Height = 28;
            this.dgvNhapHoaDon.Size = new System.Drawing.Size(1017, 280);
            this.dgvNhapHoaDon.TabIndex = 118;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 107;
            // 
            // MaBN
            // 
            this.MaBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã Bệnh Nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            this.MaBN.Width = 120;
            // 
            // TienKham
            // 
            this.TienKham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TienKham.DataPropertyName = "TienKham";
            this.TienKham.HeaderText = "Tiền Khám";
            this.TienKham.MinimumWidth = 6;
            this.TienKham.Name = "TienKham";
            this.TienKham.Width = 97;
            // 
            // TienThuoc
            // 
            this.TienThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienThuoc.DataPropertyName = "TienThuoc";
            this.TienThuoc.HeaderText = "Tiền Thuốc";
            this.TienThuoc.MinimumWidth = 6;
            this.TienThuoc.Name = "TienThuoc";
            // 
            // tbTienThuoc
            // 
            this.tbTienThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienThuoc.Location = new System.Drawing.Point(692, 206);
            this.tbTienThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTienThuoc.Name = "tbTienThuoc";
            this.tbTienThuoc.ReadOnly = true;
            this.tbTienThuoc.Size = new System.Drawing.Size(261, 31);
            this.tbTienThuoc.TabIndex = 170;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 26);
            this.label8.TabIndex = 169;
            this.label8.Text = "Tiền Khám:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(528, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 26);
            this.label9.TabIndex = 168;
            this.label9.Text = "Tiền Thuốc:";
            // 
            // tbTienKham
            // 
            this.tbTienKham.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienKham.Location = new System.Drawing.Point(691, 152);
            this.tbTienKham.Margin = new System.Windows.Forms.Padding(4);
            this.tbTienKham.Name = "tbTienKham";
            this.tbTienKham.ReadOnly = true;
            this.tbTienKham.Size = new System.Drawing.Size(262, 31);
            this.tbTienKham.TabIndex = 167;
            this.tbTienKham.Text = "50000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(528, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 26);
            this.label10.TabIndex = 166;
            this.label10.Text = "Mã Hóa Đơn:";
            // 
            // tbHoTenBN
            // 
            this.tbHoTenBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTenBN.Location = new System.Drawing.Point(209, 152);
            this.tbHoTenBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbHoTenBN.Name = "tbHoTenBN";
            this.tbHoTenBN.ReadOnly = true;
            this.tbHoTenBN.Size = new System.Drawing.Size(263, 31);
            this.tbHoTenBN.TabIndex = 174;
            // 
            // tbMaBN
            // 
            this.tbMaBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaBN.Location = new System.Drawing.Point(208, 102);
            this.tbMaBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaBN.Name = "tbMaBN";
            this.tbMaBN.ReadOnly = true;
            this.tbMaBN.Size = new System.Drawing.Size(264, 31);
            this.tbMaBN.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 172;
            this.label1.Text = "Họ Và Tên:";
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(45, 103);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(155, 26);
            this.txtmabn.TabIndex = 171;
            this.txtmabn.Text = "Mã Bệnh Nhân:";
            // 
            // tbTenthuoc
            // 
            this.tbTenthuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenthuoc.Location = new System.Drawing.Point(210, 236);
            this.tbTenthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenthuoc.Name = "tbTenthuoc";
            this.tbTenthuoc.ReadOnly = true;
            this.tbTenthuoc.Size = new System.Drawing.Size(262, 31);
            this.tbTenthuoc.TabIndex = 176;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 175;
            this.label2.Text = "Tên Thuốc:";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(210, 281);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.ReadOnly = true;
            this.tbSoLuong.Size = new System.Drawing.Size(262, 31);
            this.tbSoLuong.TabIndex = 178;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 26);
            this.label4.TabIndex = 177;
            this.label4.Text = "Số Lượng Dùng:";
            // 
            // tbGiaThuoc
            // 
            this.tbGiaThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaThuoc.Location = new System.Drawing.Point(209, 196);
            this.tbGiaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaThuoc.Name = "tbGiaThuoc";
            this.tbGiaThuoc.ReadOnly = true;
            this.tbGiaThuoc.Size = new System.Drawing.Size(263, 31);
            this.tbGiaThuoc.TabIndex = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 179;
            this.label3.Text = "Giá Thuốc:";
            // 
            // txtTTSV
            // 
            this.txtTTSV.AutoSize = true;
            this.txtTTSV.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTSV.ForeColor = System.Drawing.Color.Blue;
            this.txtTTSV.Location = new System.Drawing.Point(298, 26);
            this.txtTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTTSV.Name = "txtTTSV";
            this.txtTTSV.Size = new System.Drawing.Size(394, 55);
            this.txtTTSV.TabIndex = 181;
            this.txtTTSV.Text = "NHẬP HÓA ĐƠN";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightYellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(790, 270);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThoat.Size = new System.Drawing.Size(163, 42);
            this.btnThoat.TabIndex = 183;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightYellow;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(568, 270);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnLuu.Size = new System.Drawing.Size(176, 42);
            this.btnLuu.TabIndex = 182;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbMaHoaDon
            // 
            this.tbMaHoaDon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbMaHoaDon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHoaDon.Location = new System.Drawing.Point(691, 100);
            this.tbMaHoaDon.Name = "tbMaHoaDon";
            this.tbMaHoaDon.Size = new System.Drawing.Size(262, 31);
            this.tbMaHoaDon.TabIndex = 184;
            // 
            // NhapChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1017, 631);
            this.Controls.Add(this.tbMaHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTTSV);
            this.Controls.Add(this.tbGiaThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenthuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHoTenBN);
            this.Controls.Add(this.tbMaBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.tbTienThuoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTienKham);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvNhapHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhapChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG MẠCH TƯ";
            this.Load += new System.EventHandler(this.NhapChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThuoc;
        private System.Windows.Forms.TextBox tbTienThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTienKham;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbHoTenBN;
        private System.Windows.Forms.TextBox tbMaBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.TextBox tbTenthuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGiaThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTTSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox tbMaHoaDon;
    }
}