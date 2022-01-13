namespace QLPMT
{
    partial class ThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoaDon));
            this.dgvQLHoaDon = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGiaThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenthuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmaPhieu = new System.Windows.Forms.TextBox();
            this.tbLoaiBenh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHoTenBN = new System.Windows.Forms.TextBox();
            this.tbMaBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.Label();
            this.txtTTSV = new System.Windows.Forms.Label();
            this.tbTienThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSumMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTienKham = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMaHoaDon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhapHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLHoaDon
            // 
            this.dgvQLHoaDon.AllowUserToAddRows = false;
            this.dgvQLHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.HoTen,
            this.MaPhieuKham,
            this.LoaiBenh,
            this.TenThuoc,
            this.GiaThuoc,
            this.SoLuongDung,
            this.MaHD,
            this.TienKham,
            this.TienThuoc});
            this.dgvQLHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQLHoaDon.Location = new System.Drawing.Point(0, 401);
            this.dgvQLHoaDon.Name = "dgvQLHoaDon";
            this.dgvQLHoaDon.RowHeadersWidth = 62;
            this.dgvQLHoaDon.RowTemplate.Height = 28;
            this.dgvQLHoaDon.Size = new System.Drawing.Size(1085, 268);
            this.dgvQLHoaDon.TabIndex = 117;
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
            // GiaThuoc
            // 
            this.GiaThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GiaThuoc.DataPropertyName = "GiaThuoc";
            this.GiaThuoc.HeaderText = "Giá Thuốc";
            this.GiaThuoc.MinimumWidth = 6;
            this.GiaThuoc.Name = "GiaThuoc";
            this.GiaThuoc.Width = 95;
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
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 107;
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
            this.TienThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TienThuoc.DataPropertyName = "TienThuoc";
            this.TienThuoc.HeaderText = "Tiền Thuốc";
            this.TienThuoc.MinimumWidth = 6;
            this.TienThuoc.Name = "TienThuoc";
            // 
            // tbGiaThuoc
            // 
            this.tbGiaThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaThuoc.Location = new System.Drawing.Point(200, 286);
            this.tbGiaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaThuoc.Name = "tbGiaThuoc";
            this.tbGiaThuoc.ReadOnly = true;
            this.tbGiaThuoc.Size = new System.Drawing.Size(281, 31);
            this.tbGiaThuoc.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 155;
            this.label3.Text = "Giá Thuốc:";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(201, 325);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.ReadOnly = true;
            this.tbSoLuong.Size = new System.Drawing.Size(280, 31);
            this.tbSoLuong.TabIndex = 154;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 26);
            this.label4.TabIndex = 153;
            this.label4.Text = "Số Lượng Dùng:";
            // 
            // tbTenthuoc
            // 
            this.tbTenthuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenthuoc.Location = new System.Drawing.Point(201, 247);
            this.tbTenthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenthuoc.Name = "tbTenthuoc";
            this.tbTenthuoc.ReadOnly = true;
            this.tbTenthuoc.Size = new System.Drawing.Size(280, 31);
            this.tbTenthuoc.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 151;
            this.label2.Text = "Tên Thuốc:";
            // 
            // tbmaPhieu
            // 
            this.tbmaPhieu.BackColor = System.Drawing.SystemColors.Control;
            this.tbmaPhieu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmaPhieu.Location = new System.Drawing.Point(200, 163);
            this.tbmaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.tbmaPhieu.Name = "tbmaPhieu";
            this.tbmaPhieu.ReadOnly = true;
            this.tbmaPhieu.Size = new System.Drawing.Size(280, 31);
            this.tbmaPhieu.TabIndex = 150;
            // 
            // tbLoaiBenh
            // 
            this.tbLoaiBenh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoaiBenh.Location = new System.Drawing.Point(201, 208);
            this.tbLoaiBenh.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoaiBenh.Name = "tbLoaiBenh";
            this.tbLoaiBenh.ReadOnly = true;
            this.tbLoaiBenh.Size = new System.Drawing.Size(280, 31);
            this.tbLoaiBenh.TabIndex = 148;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(37, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 149;
            this.label7.Text = "Mã Phiếu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 146;
            this.label5.Text = "Loại Bệnh:";
            // 
            // tbHoTenBN
            // 
            this.tbHoTenBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTenBN.Location = new System.Drawing.Point(200, 123);
            this.tbHoTenBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbHoTenBN.Name = "tbHoTenBN";
            this.tbHoTenBN.ReadOnly = true;
            this.tbHoTenBN.Size = new System.Drawing.Size(280, 31);
            this.tbHoTenBN.TabIndex = 144;
            // 
            // tbMaBN
            // 
            this.tbMaBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaBN.Location = new System.Drawing.Point(200, 84);
            this.tbMaBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaBN.Name = "tbMaBN";
            this.tbMaBN.ReadOnly = true;
            this.tbMaBN.Size = new System.Drawing.Size(280, 31);
            this.tbMaBN.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 142;
            this.label1.Text = "Họ Và Tên:";
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(37, 91);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(155, 26);
            this.txtmabn.TabIndex = 141;
            this.txtmabn.Text = "Mã Bệnh Nhân:";
            // 
            // txtTTSV
            // 
            this.txtTTSV.AutoSize = true;
            this.txtTTSV.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTSV.ForeColor = System.Drawing.Color.Blue;
            this.txtTTSV.Location = new System.Drawing.Point(331, 9);
            this.txtTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTTSV.Name = "txtTTSV";
            this.txtTTSV.Size = new System.Drawing.Size(483, 55);
            this.txtTTSV.TabIndex = 157;
            this.txtTTSV.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // tbTienThuoc
            // 
            this.tbTienThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienThuoc.Location = new System.Drawing.Point(690, 180);
            this.tbTienThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTienThuoc.Name = "tbTienThuoc";
            this.tbTienThuoc.ReadOnly = true;
            this.tbTienThuoc.Size = new System.Drawing.Size(318, 31);
            this.tbTienThuoc.TabIndex = 164;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(527, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 26);
            this.label8.TabIndex = 163;
            this.label8.Text = "Tiền Khám:";
            // 
            // tbSumMoney
            // 
            this.tbSumMoney.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSumMoney.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSumMoney.Location = new System.Drawing.Point(689, 234);
            this.tbSumMoney.Margin = new System.Windows.Forms.Padding(4);
            this.tbSumMoney.Name = "tbSumMoney";
            this.tbSumMoney.ReadOnly = true;
            this.tbSumMoney.Size = new System.Drawing.Size(319, 31);
            this.tbSumMoney.TabIndex = 162;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 26);
            this.label9.TabIndex = 161;
            this.label9.Text = "Tiền Thuốc:";
            // 
            // tbTienKham
            // 
            this.tbTienKham.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienKham.Location = new System.Drawing.Point(690, 136);
            this.tbTienKham.Margin = new System.Windows.Forms.Padding(4);
            this.tbTienKham.Name = "tbTienKham";
            this.tbTienKham.ReadOnly = true;
            this.tbTienKham.Size = new System.Drawing.Size(318, 31);
            this.tbTienKham.TabIndex = 160;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(527, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 26);
            this.label10.TabIndex = 159;
            this.label10.Text = "Mã Hóa Đơn:";
            // 
            // tbMaHoaDon
            // 
            this.tbMaHoaDon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHoaDon.Location = new System.Drawing.Point(689, 90);
            this.tbMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaHoaDon.Name = "tbMaHoaDon";
            this.tbMaHoaDon.ReadOnly = true;
            this.tbMaHoaDon.Size = new System.Drawing.Size(319, 31);
            this.tbMaHoaDon.TabIndex = 158;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(527, 238);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 26);
            this.label11.TabIndex = 165;
            this.label11.Text = "Tổng tiền trả:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightYellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(895, 318);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThoat.Size = new System.Drawing.Size(152, 42);
            this.btnThoat.TabIndex = 168;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightYellow;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(716, 318);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnLuu.Size = new System.Drawing.Size(152, 42);
            this.btnLuu.TabIndex = 167;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhapHoaDon
            // 
            this.btnNhapHoaDon.BackColor = System.Drawing.Color.LightYellow;
            this.btnNhapHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapHoaDon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHoaDon.Location = new System.Drawing.Point(522, 318);
            this.btnNhapHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapHoaDon.Name = "btnNhapHoaDon";
            this.btnNhapHoaDon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnNhapHoaDon.Size = new System.Drawing.Size(168, 42);
            this.btnNhapHoaDon.TabIndex = 166;
            this.btnNhapHoaDon.Text = "Nhập Hóa Đơn";
            this.btnNhapHoaDon.UseVisualStyleBackColor = false;
            this.btnNhapHoaDon.Click += new System.EventHandler(this.btnNhapHoaDon_Click);
            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1085, 669);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnNhapHoaDon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTienThuoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSumMoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTienKham);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbMaHoaDon);
            this.Controls.Add(this.txtTTSV);
            this.Controls.Add(this.tbGiaThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenthuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbmaPhieu);
            this.Controls.Add(this.tbLoaiBenh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbHoTenBN);
            this.Controls.Add(this.tbMaBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.dgvQLHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHoaDon";
            this.Activated += new System.EventHandler(this.ThemHoaDon_Activated);
            this.Load += new System.EventHandler(this.ThemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLHoaDon;
        private System.Windows.Forms.TextBox tbGiaThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenthuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbmaPhieu;
        private System.Windows.Forms.TextBox tbLoaiBenh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHoTenBN;
        private System.Windows.Forms.TextBox tbMaBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.Label txtTTSV;
        private System.Windows.Forms.TextBox tbTienThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSumMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTienKham;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMaHoaDon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThuoc;
    }
}