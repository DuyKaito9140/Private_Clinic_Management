namespace QLPMT
{
    partial class QLPhieuKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPhieuKham));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvPhieuKham = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTTSV = new System.Windows.Forms.Label();
            this.tbMaPhieu = new System.Windows.Forms.TextBox();
            this.tbLoaiBenh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTrieuChung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHoTenBN = new System.Windows.Forms.TextBox();
            this.tbMaBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.Label();
            this.tbCachDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMathuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPhieuKham = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightYellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(814, 341);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThoat.Size = new System.Drawing.Size(161, 40);
            this.btnThoat.TabIndex = 119;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightYellow;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(462, 341);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnLuu.Size = new System.Drawing.Size(163, 40);
            this.btnLuu.TabIndex = 118;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvPhieuKham
            // 
            this.dgvPhieuKham.AllowUserToAddRows = false;
            this.dgvPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.HoTen,
            this.MaPhieuKham,
            this.TrieuChung,
            this.LoaiBenh,
            this.TenThuoc,
            this.CachDung,
            this.SoLuongDung,
            this.NgayKham,
            this.GioKham,
            this.MaHD});
            this.dgvPhieuKham.Location = new System.Drawing.Point(12, 396);
            this.dgvPhieuKham.Name = "dgvPhieuKham";
            this.dgvPhieuKham.RowHeadersWidth = 62;
            this.dgvPhieuKham.RowTemplate.Height = 28;
            this.dgvPhieuKham.Size = new System.Drawing.Size(1008, 257);
            this.dgvPhieuKham.TabIndex = 116;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1022, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 643);
            this.panel3.TabIndex = 115;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 10);
            this.panel2.TabIndex = 114;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 653);
            this.panel1.TabIndex = 113;
            // 
            // txtTTSV
            // 
            this.txtTTSV.AutoSize = true;
            this.txtTTSV.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTSV.ForeColor = System.Drawing.Color.Blue;
            this.txtTTSV.Location = new System.Drawing.Point(103, 72);
            this.txtTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTTSV.Name = "txtTTSV";
            this.txtTTSV.Size = new System.Drawing.Size(848, 55);
            this.txtTTSV.TabIndex = 123;
            this.txtTTSV.Text = "QUẢN LÝ THÔNG TIN KHÁM BỆNH";
            // 
            // tbMaPhieu
            // 
            this.tbMaPhieu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbMaPhieu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaPhieu.Location = new System.Drawing.Point(678, 282);
            this.tbMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaPhieu.Name = "tbMaPhieu";
            this.tbMaPhieu.Size = new System.Drawing.Size(297, 31);
            this.tbMaPhieu.TabIndex = 133;
            // 
            // tbLoaiBenh
            // 
            this.tbLoaiBenh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoaiBenh.Location = new System.Drawing.Point(202, 282);
            this.tbLoaiBenh.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoaiBenh.Name = "tbLoaiBenh";
            this.tbLoaiBenh.ReadOnly = true;
            this.tbLoaiBenh.Size = new System.Drawing.Size(280, 31);
            this.tbLoaiBenh.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(507, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 132;
            this.label7.Text = "Mã Phiếu:";
            // 
            // tbTrieuChung
            // 
            this.tbTrieuChung.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrieuChung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTrieuChung.Location = new System.Drawing.Point(202, 232);
            this.tbTrieuChung.Margin = new System.Windows.Forms.Padding(4);
            this.tbTrieuChung.Name = "tbTrieuChung";
            this.tbTrieuChung.ReadOnly = true;
            this.tbTrieuChung.Size = new System.Drawing.Size(280, 31);
            this.tbTrieuChung.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 129;
            this.label5.Text = "Loại Bệnh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 128;
            this.label6.Text = "Triệu Chứng:";
            // 
            // tbHoTenBN
            // 
            this.tbHoTenBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTenBN.Location = new System.Drawing.Point(202, 183);
            this.tbHoTenBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbHoTenBN.Name = "tbHoTenBN";
            this.tbHoTenBN.ReadOnly = true;
            this.tbHoTenBN.Size = new System.Drawing.Size(280, 31);
            this.tbHoTenBN.TabIndex = 127;
            // 
            // tbMaBN
            // 
            this.tbMaBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaBN.Location = new System.Drawing.Point(202, 131);
            this.tbMaBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaBN.Name = "tbMaBN";
            this.tbMaBN.ReadOnly = true;
            this.tbMaBN.Size = new System.Drawing.Size(280, 31);
            this.tbMaBN.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 125;
            this.label1.Text = "Họ Và Tên:";
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(39, 132);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(155, 26);
            this.txtmabn.TabIndex = 124;
            this.txtmabn.Text = "Mã Bệnh Nhân:";
            // 
            // tbCachDung
            // 
            this.tbCachDung.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCachDung.Location = new System.Drawing.Point(678, 183);
            this.tbCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.tbCachDung.Name = "tbCachDung";
            this.tbCachDung.ReadOnly = true;
            this.tbCachDung.Size = new System.Drawing.Size(298, 31);
            this.tbCachDung.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 139;
            this.label3.Text = "Cách Dùng:";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(678, 232);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.ReadOnly = true;
            this.tbSoLuong.Size = new System.Drawing.Size(297, 31);
            this.tbSoLuong.TabIndex = 137;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 26);
            this.label4.TabIndex = 136;
            this.label4.Text = "Số Lượng Dùng:";
            // 
            // tbMathuoc
            // 
            this.tbMathuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMathuoc.Location = new System.Drawing.Point(678, 131);
            this.tbMathuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbMathuoc.Name = "tbMathuoc";
            this.tbMathuoc.ReadOnly = true;
            this.tbMathuoc.Size = new System.Drawing.Size(297, 31);
            this.tbMathuoc.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 134;
            this.label2.Text = "Mã Thuốc:";
            // 
            // btnPhieuKham
            // 
            this.btnPhieuKham.BackColor = System.Drawing.Color.LightYellow;
            this.btnPhieuKham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhieuKham.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuKham.Location = new System.Drawing.Point(67, 340);
            this.btnPhieuKham.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhieuKham.Name = "btnPhieuKham";
            this.btnPhieuKham.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnPhieuKham.Size = new System.Drawing.Size(189, 40);
            this.btnPhieuKham.TabIndex = 147;
            this.btnPhieuKham.Text = "Nhập Phiếu Khám";
            this.btnPhieuKham.UseVisualStyleBackColor = false;
            this.btnPhieuKham.Click += new System.EventHandler(this.btnPhieuKham_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.LightYellow;
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Location = new System.Drawing.Point(275, 340);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnHoaDon.Size = new System.Drawing.Size(172, 40);
            this.btnHoaDon.TabIndex = 148;
            this.btnHoaDon.Text = "Nhập Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightYellow;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(642, 341);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnRefresh.Size = new System.Drawing.Size(155, 42);
            this.btnRefresh.TabIndex = 170;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên BN";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 62;
            // 
            // MaPhieuKham
            // 
            this.MaPhieuKham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaPhieuKham.DataPropertyName = "MaPhieuKham";
            this.MaPhieuKham.HeaderText = "Mã Phiếu";
            this.MaPhieuKham.MinimumWidth = 6;
            this.MaPhieuKham.Name = "MaPhieuKham";
            this.MaPhieuKham.Width = 89;
            // 
            // TrieuChung
            // 
            this.TrieuChung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrieuChung.DataPropertyName = "TrieuChung";
            this.TrieuChung.HeaderText = "Triệu Chứng";
            this.TrieuChung.MinimumWidth = 6;
            this.TrieuChung.Name = "TrieuChung";
            this.TrieuChung.Width = 106;
            // 
            // LoaiBenh
            // 
            this.LoaiBenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoaiBenh.DataPropertyName = "LoaiBenh";
            this.LoaiBenh.HeaderText = "Loại Bệnh";
            this.LoaiBenh.MinimumWidth = 6;
            this.LoaiBenh.Name = "LoaiBenh";
            this.LoaiBenh.Width = 93;
            // 
            // TenThuoc
            // 
            this.TenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 98;
            // 
            // CachDung
            // 
            this.CachDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CachDung.DataPropertyName = "CachDung";
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            this.CachDung.Width = 99;
            // 
            // SoLuongDung
            // 
            this.SoLuongDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuongDung.DataPropertyName = "SoLuongDung";
            this.SoLuongDung.HeaderText = "Số Lượng";
            this.SoLuongDung.MinimumWidth = 6;
            this.SoLuongDung.Name = "SoLuongDung";
            this.SoLuongDung.Width = 91;
            // 
            // NgayKham
            // 
            this.NgayKham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayKham.DataPropertyName = "NgayKham";
            this.NgayKham.HeaderText = "Ngày Khám";
            this.NgayKham.MinimumWidth = 6;
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Width = 101;
            // 
            // GioKham
            // 
            this.GioKham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GioKham.DataPropertyName = "GioKham";
            this.GioKham.HeaderText = "Giờ Khám";
            this.GioKham.MinimumWidth = 6;
            this.GioKham.Name = "GioKham";
            this.GioKham.Width = 91;
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
            // QLPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnPhieuKham);
            this.Controls.Add(this.tbCachDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMathuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaPhieu);
            this.Controls.Add(this.tbLoaiBenh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTrieuChung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHoTenBN);
            this.Controls.Add(this.tbMaBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.txtTTSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvPhieuKham);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLPhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG MẠCH TƯ";
            this.Activated += new System.EventHandler(this.QLPhieuKham_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QLPhieuKham_FormClosed);
            this.Load += new System.EventHandler(this.QLPhieuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvPhieuKham;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTTSV;
        private System.Windows.Forms.TextBox tbMaPhieu;
        private System.Windows.Forms.TextBox tbLoaiBenh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTrieuChung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbHoTenBN;
        private System.Windows.Forms.TextBox tbMaBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.TextBox tbCachDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMathuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPhieuKham;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
    }
}