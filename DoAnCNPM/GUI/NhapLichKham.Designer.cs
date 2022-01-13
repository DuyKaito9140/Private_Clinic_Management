namespace QLPMT
{
    partial class NhapLichKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapLichKham));
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.GioDatLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDatLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMaLich = new System.Windows.Forms.TextBox();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDSLich = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGioDat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbmabn = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.txtmabn = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonBN = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTTSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLich)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 26);
            this.label9.TabIndex = 199;
            this.label9.Text = "Mã Lịch:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightYellow;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(308, 244);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnXoa.Size = new System.Drawing.Size(165, 45);
            this.btnXoa.TabIndex = 192;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Aqua;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(1007, 10);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 575);
            this.panel11.TabIndex = 179;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(10, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1007, 10);
            this.panel14.TabIndex = 178;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 585);
            this.panel12.TabIndex = 177;
            // 
            // GioDatLich
            // 
            this.GioDatLich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioDatLich.DataPropertyName = "GioDatLich";
            this.GioDatLich.HeaderText = "Giờ Đặt Lịch";
            this.GioDatLich.MinimumWidth = 6;
            this.GioDatLich.Name = "GioDatLich";
            // 
            // NgayDatLich
            // 
            this.NgayDatLich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayDatLich.DataPropertyName = "NgayDatLich";
            this.NgayDatLich.HeaderText = "Ngày Đặt Lịch";
            this.NgayDatLich.MinimumWidth = 6;
            this.NgayDatLich.Name = "NgayDatLich";
            this.NgayDatLich.Width = 92;
            // 
            // MaLich
            // 
            this.MaLich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaLich.DataPropertyName = "MaLich";
            this.MaLich.HeaderText = "Mã Lịch";
            this.MaLich.MinimumWidth = 6;
            this.MaLich.Name = "MaLich";
            this.MaLich.Width = 80;
            // 
            // Sdt
            // 
            this.Sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số Điện Thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 117;
            // 
            // tbMaLich
            // 
            this.tbMaLich.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLich.Location = new System.Drawing.Point(679, 105);
            this.tbMaLich.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaLich.Name = "tbMaLich";
            this.tbMaLich.Size = new System.Drawing.Size(305, 31);
            this.tbMaLich.TabIndex = 198;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 78;
            // 
            // dgvDSLich
            // 
            this.dgvDSLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.HoTen,
            this.Sdt,
            this.MaLich,
            this.NgayDatLich,
            this.GioDatLich});
            this.dgvDSLich.Location = new System.Drawing.Point(8, 312);
            this.dgvDSLich.Name = "dgvDSLich";
            this.dgvDSLich.RowHeadersWidth = 62;
            this.dgvDSLich.RowTemplate.Height = 28;
            this.dgvDSLich.Size = new System.Drawing.Size(999, 274);
            this.dgvDSLich.TabIndex = 181;
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
            // tbNgayDat
            // 
            this.tbNgayDat.CausesValidation = false;
            this.tbNgayDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgayDat.Location = new System.Drawing.Point(679, 148);
            this.tbNgayDat.Margin = new System.Windows.Forms.Padding(4);
            this.tbNgayDat.Name = "tbNgayDat";
            this.tbNgayDat.Size = new System.Drawing.Size(305, 30);
            this.tbNgayDat.TabIndex = 194;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 26);
            this.label7.TabIndex = 191;
            this.label7.Text = "Ngày Đã Đặt:";
            // 
            // tbGioDat
            // 
            this.tbGioDat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGioDat.Location = new System.Drawing.Point(679, 193);
            this.tbGioDat.Margin = new System.Windows.Forms.Padding(4);
            this.tbGioDat.Name = "tbGioDat";
            this.tbGioDat.Size = new System.Drawing.Size(305, 31);
            this.tbGioDat.TabIndex = 190;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 188;
            this.label2.Text = "Giờ Đặt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 26);
            this.label4.TabIndex = 187;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // tbhoten
            // 
            this.tbhoten.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhoten.Location = new System.Drawing.Point(204, 144);
            this.tbhoten.Margin = new System.Windows.Forms.Padding(4);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.ReadOnly = true;
            this.tbhoten.Size = new System.Drawing.Size(303, 31);
            this.tbhoten.TabIndex = 186;
            // 
            // tbmabn
            // 
            this.tbmabn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmabn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbmabn.Location = new System.Drawing.Point(204, 100);
            this.tbmabn.Margin = new System.Windows.Forms.Padding(4);
            this.tbmabn.Name = "tbmabn";
            this.tbmabn.ReadOnly = true;
            this.tbmabn.Size = new System.Drawing.Size(224, 31);
            this.tbmabn.TabIndex = 185;
            // 
            // tbsdt
            // 
            this.tbsdt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsdt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbsdt.Location = new System.Drawing.Point(204, 189);
            this.tbsdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.ReadOnly = true;
            this.tbsdt.Size = new System.Drawing.Size(303, 31);
            this.tbsdt.TabIndex = 189;
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(39, 100);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(155, 26);
            this.txtmabn.TabIndex = 183;
            this.txtmabn.Text = "Mã Bệnh Nhân:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightYellow;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(103, 244);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(165, 45);
            this.btnThem.TabIndex = 182;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 184;
            this.label1.Text = "Họ Và Tên:";
            // 
            // btnChonBN
            // 
            this.btnChonBN.BackColor = System.Drawing.Color.LightYellow;
            this.btnChonBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonBN.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonBN.Location = new System.Drawing.Point(436, 99);
            this.btnChonBN.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonBN.Name = "btnChonBN";
            this.btnChonBN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnChonBN.Size = new System.Drawing.Size(71, 37);
            this.btnChonBN.TabIndex = 200;
            this.btnChonBN.Text = "Chọn BN";
            this.btnChonBN.UseVisualStyleBackColor = false;
            this.btnChonBN.Click += new System.EventHandler(this.btnChonBN_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightYellow;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(516, 244);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnCapNhat.Size = new System.Drawing.Size(166, 45);
            this.btnCapNhat.TabIndex = 201;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightYellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(727, 244);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThoat.Size = new System.Drawing.Size(169, 45);
            this.btnThoat.TabIndex = 202;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTTSV
            // 
            this.txtTTSV.AutoSize = true;
            this.txtTTSV.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTSV.ForeColor = System.Drawing.Color.Blue;
            this.txtTTSV.Location = new System.Drawing.Point(229, 28);
            this.txtTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTTSV.Name = "txtTTSV";
            this.txtTTSV.Size = new System.Drawing.Size(548, 55);
            this.txtTTSV.TabIndex = 203;
            this.txtTTSV.Text = "QUẢN LÝ LỊCH KHÁM";
            // 
            // NhapLichKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1017, 585);
            this.Controls.Add(this.txtTTSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnChonBN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.tbMaLich);
            this.Controls.Add(this.dgvDSLich);
            this.Controls.Add(this.tbNgayDat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbGioDat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbhoten);
            this.Controls.Add(this.tbmabn);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhapLichKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG MẠCH TƯ";
            this.Activated += new System.EventHandler(this.NhapLichKham_Activated);
            this.Load += new System.EventHandler(this.NhapLichKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioDatLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDatLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.TextBox tbMaLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridView dgvDSLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DateTimePicker tbNgayDat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGioDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.TextBox tbmabn;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonBN;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label txtTTSV;
    }
}