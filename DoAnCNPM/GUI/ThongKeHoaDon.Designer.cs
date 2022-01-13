namespace QLPMT
{
    partial class ThongKeHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeHoaDon));
            this.txtTTSV = new System.Windows.Forms.Label();
            this.dgvNhapHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoLuongBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaBCDT = new System.Windows.Forms.TextBox();
            this.txtmabn = new System.Windows.Forms.Label();
            this.tbTongDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTTSV
            // 
            this.txtTTSV.AutoSize = true;
            this.txtTTSV.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTSV.ForeColor = System.Drawing.Color.Blue;
            this.txtTTSV.Location = new System.Drawing.Point(185, 21);
            this.txtTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTTSV.Name = "txtTTSV";
            this.txtTTSV.Size = new System.Drawing.Size(521, 55);
            this.txtTTSV.TabIndex = 204;
            this.txtTTSV.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // dgvNhapHoaDon
            // 
            this.dgvNhapHoaDon.AllowUserToAddRows = false;
            this.dgvNhapHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaBN,
            this.NgayKham,
            this.TienKham,
            this.TienThuoc});
            this.dgvNhapHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhapHoaDon.Location = new System.Drawing.Point(0, 328);
            this.dgvNhapHoaDon.Name = "dgvNhapHoaDon";
            this.dgvNhapHoaDon.RowHeadersWidth = 62;
            this.dgvNhapHoaDon.RowTemplate.Height = 28;
            this.dgvNhapHoaDon.Size = new System.Drawing.Size(897, 232);
            this.dgvNhapHoaDon.TabIndex = 205;
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
            // NgayKham
            // 
            this.NgayKham.DataPropertyName = "NgayKham";
            this.NgayKham.HeaderText = "Ngày Khám";
            this.NgayKham.MinimumWidth = 6;
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Width = 125;
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
            // tbCbThang
            // 
            this.tbCbThang.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCbThang.FormattingEnabled = true;
            this.tbCbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.tbCbThang.Location = new System.Drawing.Point(148, 153);
            this.tbCbThang.Name = "tbCbThang";
            this.tbCbThang.Size = new System.Drawing.Size(238, 31);
            this.tbCbThang.TabIndex = 211;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 210;
            this.label2.Text = "Tháng:";
            // 
            // tbCbNam
            // 
            this.tbCbNam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCbNam.FormattingEnabled = true;
            this.tbCbNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.tbCbNam.Location = new System.Drawing.Point(148, 202);
            this.tbCbNam.Name = "tbCbNam";
            this.tbCbNam.Size = new System.Drawing.Size(238, 31);
            this.tbCbNam.TabIndex = 213;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 212;
            this.label3.Text = "Năm:";
            // 
            // tbSoLuongBN
            // 
            this.tbSoLuongBN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbSoLuongBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongBN.ForeColor = System.Drawing.Color.Firebrick;
            this.tbSoLuongBN.Location = new System.Drawing.Point(641, 98);
            this.tbSoLuongBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuongBN.Name = "tbSoLuongBN";
            this.tbSoLuongBN.ReadOnly = true;
            this.tbSoLuongBN.Size = new System.Drawing.Size(203, 31);
            this.tbSoLuongBN.TabIndex = 217;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(417, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 26);
            this.label7.TabIndex = 216;
            this.label7.Text = "Số Lượng Bệnh Nhân:";
            // 
            // tbMaBCDT
            // 
            this.tbMaBCDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBCDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaBCDT.Location = new System.Drawing.Point(148, 98);
            this.tbMaBCDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaBCDT.Name = "tbMaBCDT";
            this.tbMaBCDT.Size = new System.Drawing.Size(238, 31);
            this.tbMaBCDT.TabIndex = 215;
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(36, 99);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(104, 26);
            this.txtmabn.TabIndex = 214;
            this.txtmabn.Text = "Mã BCDT:";
            // 
            // tbTongDT
            // 
            this.tbTongDT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbTongDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongDT.ForeColor = System.Drawing.Color.Firebrick;
            this.tbTongDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTongDT.Location = new System.Drawing.Point(641, 154);
            this.tbTongDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbTongDT.Name = "tbTongDT";
            this.tbTongDT.ReadOnly = true;
            this.tbTongDT.Size = new System.Drawing.Size(203, 31);
            this.tbTongDT.TabIndex = 219;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 218;
            this.label6.Text = "Tổng Doanh Thu:";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightYellow;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(268, 259);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnLuu.Size = new System.Drawing.Size(160, 45);
            this.btnLuu.TabIndex = 221;
            this.btnLuu.Text = "Lưu >>";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.BackColor = System.Drawing.Color.LightYellow;
            this.btnTinhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhToan.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhToan.Location = new System.Drawing.Point(73, 259);
            this.btnTinhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTinhToan.Size = new System.Drawing.Size(153, 45);
            this.btnTinhToan.TabIndex = 220;
            this.btnTinhToan.Text = "Tính Toán";
            this.btnTinhToan.UseVisualStyleBackColor = false;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.LightYellow;
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(484, 259);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnrefresh.Size = new System.Drawing.Size(149, 45);
            this.btnrefresh.TabIndex = 222;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightYellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(687, 259);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThoat.Size = new System.Drawing.Size(157, 45);
            this.btnThoat.TabIndex = 223;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(897, 560);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.tbTongDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSoLuongBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMaBCDT);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.tbCbNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCbThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNhapHoaDon);
            this.Controls.Add(this.txtTTSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKeHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG MẠCH TƯ";
            this.Load += new System.EventHandler(this.ThongKeHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTTSV;
        private System.Windows.Forms.DataGridView dgvNhapHoaDon;
        private System.Windows.Forms.ComboBox tbCbThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tbCbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoLuongBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaBCDT;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.TextBox tbTongDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThuoc;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnThoat;
    }
}