
namespace QLPMT
{
    partial class UC_QLThuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvQLThuoc = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTrongKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbSoLuongTrongKho = new System.Windows.Forms.TextBox();
            this.tbGiaThuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenThuoc = new System.Windows.Forms.TextBox();
            this.tbMaThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbCachDung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCbDonVi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbdateHanDung = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBcThuoc = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 560);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(971, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 550);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(961, 43);
            this.panel4.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(395, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 33);
            this.label9.TabIndex = 5;
            this.label9.Text = "QUẢN LÝ THUỐC";
            // 
            // dgvQLThuoc
            // 
            this.dgvQLThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.HanSuDung,
            this.DonVi,
            this.GiaThuoc,
            this.SoLuongTrongKho,
            this.CachDung});
            this.dgvQLThuoc.Location = new System.Drawing.Point(10, 296);
            this.dgvQLThuoc.Name = "dgvQLThuoc";
            this.dgvQLThuoc.RowHeadersWidth = 62;
            this.dgvQLThuoc.RowTemplate.Height = 28;
            this.dgvQLThuoc.Size = new System.Drawing.Size(961, 257);
            this.dgvQLThuoc.TabIndex = 50;
            // 
            // MaThuoc
            // 
            this.MaThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            // 
            // TenThuoc
            // 
            this.TenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 106;
            // 
            // HanSuDung
            // 
            this.HanSuDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HanSuDung.DataPropertyName = "HanSuDung";
            this.HanSuDung.HeaderText = "Hạn Dùng";
            this.HanSuDung.MinimumWidth = 6;
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.Width = 101;
            // 
            // DonVi
            // 
            this.DonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 79;
            // 
            // GiaThuoc
            // 
            this.GiaThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GiaThuoc.DataPropertyName = "GiaThuoc";
            this.GiaThuoc.HeaderText = "Giá Thuốc";
            this.GiaThuoc.MinimumWidth = 6;
            this.GiaThuoc.Name = "GiaThuoc";
            this.GiaThuoc.Width = 103;
            // 
            // SoLuongTrongKho
            // 
            this.SoLuongTrongKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuongTrongKho.DataPropertyName = "SoLuongTrongKho";
            this.SoLuongTrongKho.HeaderText = "Số Lượng";
            this.SoLuongTrongKho.MinimumWidth = 6;
            this.SoLuongTrongKho.Name = "SoLuongTrongKho";
            this.SoLuongTrongKho.Width = 98;
            // 
            // CachDung
            // 
            this.CachDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CachDung.DataPropertyName = "CachDung";
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightYellow;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(281, 243);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnCapNhat.Size = new System.Drawing.Size(120, 40);
            this.btnCapNhat.TabIndex = 123;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 121;
            this.label1.Text = "Số Lượng Trong Kho:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(775, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 120;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightYellow;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(162, 243);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnXoa.Size = new System.Drawing.Size(111, 40);
            this.btnXoa.TabIndex = 119;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbSoLuongTrongKho
            // 
            this.tbSoLuongTrongKho.CausesValidation = false;
            this.tbSoLuongTrongKho.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongTrongKho.Location = new System.Drawing.Point(664, 153);
            this.tbSoLuongTrongKho.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuongTrongKho.Name = "tbSoLuongTrongKho";
            this.tbSoLuongTrongKho.Size = new System.Drawing.Size(274, 31);
            this.tbSoLuongTrongKho.TabIndex = 118;
            // 
            // tbGiaThuoc
            // 
            this.tbGiaThuoc.CausesValidation = false;
            this.tbGiaThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaThuoc.Location = new System.Drawing.Point(664, 71);
            this.tbGiaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaThuoc.Name = "tbGiaThuoc";
            this.tbGiaThuoc.Size = new System.Drawing.Size(274, 31);
            this.tbGiaThuoc.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 115;
            this.label2.Text = "Giá Thuốc (VNĐ):";
            // 
            // tbTenThuoc
            // 
            this.tbTenThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThuoc.Location = new System.Drawing.Point(155, 113);
            this.tbTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenThuoc.Name = "tbTenThuoc";
            this.tbTenThuoc.Size = new System.Drawing.Size(296, 31);
            this.tbTenThuoc.TabIndex = 113;
            // 
            // tbMaThuoc
            // 
            this.tbMaThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaThuoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaThuoc.Location = new System.Drawing.Point(155, 74);
            this.tbMaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaThuoc.Name = "tbMaThuoc";
            this.tbMaThuoc.Size = new System.Drawing.Size(296, 31);
            this.tbMaThuoc.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 111;
            this.label3.Text = "Tên Thuốc:";
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(36, 76);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(111, 26);
            this.txtmabn.TabIndex = 110;
            this.txtmabn.Text = "Mã Thuốc:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightYellow;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(41, 243);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThem.Size = new System.Drawing.Size(113, 40);
            this.btnThem.TabIndex = 109;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbCachDung
            // 
            this.tbCachDung.CausesValidation = false;
            this.tbCachDung.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCachDung.Location = new System.Drawing.Point(155, 196);
            this.tbCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.tbCachDung.Name = "tbCachDung";
            this.tbCachDung.Size = new System.Drawing.Size(783, 31);
            this.tbCachDung.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 127;
            this.label5.Text = "Cách Dùng:";
            // 
            // tbCbDonVi
            // 
            this.tbCbDonVi.CausesValidation = false;
            this.tbCbDonVi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCbDonVi.FormattingEnabled = true;
            this.tbCbDonVi.Items.AddRange(new object[] {
            "Viên",
            "Vĩ",
            "Chai"});
            this.tbCbDonVi.Location = new System.Drawing.Point(664, 110);
            this.tbCbDonVi.Name = "tbCbDonVi";
            this.tbCbDonVi.Size = new System.Drawing.Size(274, 31);
            this.tbCbDonVi.TabIndex = 129;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 128;
            this.label4.Text = "Đơn Vị:";
            // 
            // tbdateHanDung
            // 
            this.tbdateHanDung.CausesValidation = false;
            this.tbdateHanDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdateHanDung.Location = new System.Drawing.Point(155, 154);
            this.tbdateHanDung.Margin = new System.Windows.Forms.Padding(4);
            this.tbdateHanDung.Name = "tbdateHanDung";
            this.tbdateHanDung.Size = new System.Drawing.Size(296, 30);
            this.tbdateHanDung.TabIndex = 131;
            this.tbdateHanDung.Value = new System.DateTime(2020, 12, 5, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 130;
            this.label7.Text = "Hạn Dùng:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.Info;
            this.btnTim.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(880, 246);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(58, 35);
            this.btnTim.TabIndex = 133;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txbsearch
            // 
            this.txbsearch.BackColor = System.Drawing.SystemColors.Info;
            this.txbsearch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsearch.Location = new System.Drawing.Point(664, 246);
            this.txbsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbsearch.Name = "txbsearch";
            this.txbsearch.Size = new System.Drawing.Size(209, 34);
            this.txbsearch.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 134;
            this.label6.Text = "Nhập từ khóa:";
            // 
            // btnBcThuoc
            // 
            this.btnBcThuoc.BackColor = System.Drawing.Color.LightYellow;
            this.btnBcThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBcThuoc.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBcThuoc.Location = new System.Drawing.Point(409, 243);
            this.btnBcThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnBcThuoc.Name = "btnBcThuoc";
            this.btnBcThuoc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnBcThuoc.Size = new System.Drawing.Size(120, 40);
            this.btnBcThuoc.TabIndex = 135;
            this.btnBcThuoc.Text = "BC Thuốc";
            this.btnBcThuoc.UseVisualStyleBackColor = false;
            this.btnBcThuoc.Click += new System.EventHandler(this.btnBcThuoc_Click);
            // 
            // UC_QLThuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.btnBcThuoc);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txbsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbdateHanDung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCbDonVi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCachDung);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tbSoLuongTrongKho);
            this.Controls.Add(this.tbGiaThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTenThuoc);
            this.Controls.Add(this.tbMaThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvQLThuoc);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_QLThuoc";
            this.Size = new System.Drawing.Size(981, 560);
            this.Load += new System.EventHandler(this.UC_QLThuoc_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvQLThuoc;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbSoLuongTrongKho;
        private System.Windows.Forms.TextBox tbGiaThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenThuoc;
        private System.Windows.Forms.TextBox tbMaThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbCachDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbCbDonVi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tbdateHanDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txbsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBcThuoc;
    }
}
