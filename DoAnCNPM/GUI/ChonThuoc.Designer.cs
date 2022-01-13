namespace QLPMT
{
    partial class ChonThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonThuoc));
            this.dgvQLThuoc = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTrongKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTTSV = new System.Windows.Forms.Label();
            this.btnChonThuoc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCachDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tbSoLuongTrongKho = new System.Windows.Forms.TextBox();
            this.tbGiaThuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenThuoc = new System.Windows.Forms.TextBox();
            this.tbMaThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.Label();
            this.tbCbDonVi = new System.Windows.Forms.TextBox();
            this.tbdateHanDung = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLThuoc)).BeginInit();
            this.SuspendLayout();
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
            this.dgvQLThuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQLThuoc.Location = new System.Drawing.Point(0, 313);
            this.dgvQLThuoc.Name = "dgvQLThuoc";
            this.dgvQLThuoc.RowHeadersWidth = 62;
            this.dgvQLThuoc.RowTemplate.Height = 28;
            this.dgvQLThuoc.Size = new System.Drawing.Size(902, 249);
            this.dgvQLThuoc.TabIndex = 51;
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
            this.SoLuongTrongKho.HeaderText = "Số Lượng Còn";
            this.SoLuongTrongKho.MinimumWidth = 6;
            this.SoLuongTrongKho.Name = "SoLuongTrongKho";
            this.SoLuongTrongKho.Width = 127;
            // 
            // CachDung
            // 
            this.CachDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CachDung.DataPropertyName = "CachDung";
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            // 
            // txtTTSV
            // 
            this.txtTTSV.AutoSize = true;
            this.txtTTSV.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTSV.ForeColor = System.Drawing.Color.Blue;
            this.txtTTSV.Location = new System.Drawing.Point(244, 18);
            this.txtTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTTSV.Name = "txtTTSV";
            this.txtTTSV.Size = new System.Drawing.Size(390, 61);
            this.txtTTSV.TabIndex = 52;
            this.txtTTSV.Text = "CHỌN THUỐC";
            // 
            // btnChonThuoc
            // 
            this.btnChonThuoc.BackColor = System.Drawing.Color.LightYellow;
            this.btnChonThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonThuoc.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonThuoc.Location = new System.Drawing.Point(268, 260);
            this.btnChonThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonThuoc.Name = "btnChonThuoc";
            this.btnChonThuoc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnChonThuoc.Size = new System.Drawing.Size(150, 40);
            this.btnChonThuoc.TabIndex = 150;
            this.btnChonThuoc.Text = "Chọn";
            this.btnChonThuoc.UseVisualStyleBackColor = false;
            this.btnChonThuoc.Click += new System.EventHandler(this.btnChonThuoc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 26);
            this.label7.TabIndex = 148;
            this.label7.Text = "Hạn Dùng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 146;
            this.label4.Text = "Đơn Vị:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 145;
            this.label5.Text = "Cách Dùng:";
            // 
            // tbCachDung
            // 
            this.tbCachDung.CausesValidation = false;
            this.tbCachDung.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCachDung.Location = new System.Drawing.Point(153, 216);
            this.tbCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.tbCachDung.Name = "tbCachDung";
            this.tbCachDung.ReadOnly = true;
            this.tbCachDung.Size = new System.Drawing.Size(722, 31);
            this.tbCachDung.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 142;
            this.label1.Text = "Số Lượng Còn:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightYellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(480, 260);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThoat.Size = new System.Drawing.Size(150, 40);
            this.btnThoat.TabIndex = 141;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // tbSoLuongTrongKho
            // 
            this.tbSoLuongTrongKho.CausesValidation = false;
            this.tbSoLuongTrongKho.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongTrongKho.Location = new System.Drawing.Point(628, 173);
            this.tbSoLuongTrongKho.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuongTrongKho.Name = "tbSoLuongTrongKho";
            this.tbSoLuongTrongKho.ReadOnly = true;
            this.tbSoLuongTrongKho.Size = new System.Drawing.Size(247, 31);
            this.tbSoLuongTrongKho.TabIndex = 140;
            // 
            // tbGiaThuoc
            // 
            this.tbGiaThuoc.CausesValidation = false;
            this.tbGiaThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaThuoc.Location = new System.Drawing.Point(628, 94);
            this.tbGiaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaThuoc.Name = "tbGiaThuoc";
            this.tbGiaThuoc.ReadOnly = true;
            this.tbGiaThuoc.Size = new System.Drawing.Size(247, 31);
            this.tbGiaThuoc.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 138;
            this.label2.Text = "Giá Thuốc (VNĐ):";
            // 
            // tbTenThuoc
            // 
            this.tbTenThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThuoc.Location = new System.Drawing.Point(153, 133);
            this.tbTenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenThuoc.Name = "tbTenThuoc";
            this.tbTenThuoc.ReadOnly = true;
            this.tbTenThuoc.Size = new System.Drawing.Size(265, 31);
            this.tbTenThuoc.TabIndex = 137;
            // 
            // tbMaThuoc
            // 
            this.tbMaThuoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaThuoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaThuoc.Location = new System.Drawing.Point(153, 94);
            this.tbMaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaThuoc.Name = "tbMaThuoc";
            this.tbMaThuoc.ReadOnly = true;
            this.tbMaThuoc.Size = new System.Drawing.Size(265, 31);
            this.tbMaThuoc.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 135;
            this.label3.Text = "Tên Thuốc:";
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(20, 96);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(111, 26);
            this.txtmabn.TabIndex = 134;
            this.txtmabn.Text = "Mã Thuốc:";
            // 
            // tbCbDonVi
            // 
            this.tbCbDonVi.CausesValidation = false;
            this.tbCbDonVi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCbDonVi.Location = new System.Drawing.Point(628, 132);
            this.tbCbDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.tbCbDonVi.Name = "tbCbDonVi";
            this.tbCbDonVi.ReadOnly = true;
            this.tbCbDonVi.Size = new System.Drawing.Size(247, 31);
            this.tbCbDonVi.TabIndex = 151;
            // 
            // tbdateHanDung
            // 
            this.tbdateHanDung.CausesValidation = false;
            this.tbdateHanDung.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdateHanDung.Location = new System.Drawing.Point(153, 173);
            this.tbdateHanDung.Margin = new System.Windows.Forms.Padding(4);
            this.tbdateHanDung.Name = "tbdateHanDung";
            this.tbdateHanDung.ReadOnly = true;
            this.tbdateHanDung.Size = new System.Drawing.Size(265, 31);
            this.tbdateHanDung.TabIndex = 152;
            // 
            // ChonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(902, 562);
            this.Controls.Add(this.tbdateHanDung);
            this.Controls.Add(this.tbCbDonVi);
            this.Controls.Add(this.btnChonThuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCachDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tbSoLuongTrongKho);
            this.Controls.Add(this.tbGiaThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTenThuoc);
            this.Controls.Add(this.tbMaThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.txtTTSV);
            this.Controls.Add(this.dgvQLThuoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG MẠCH TƯ";
            this.Load += new System.EventHandler(this.ChonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDung;
        private System.Windows.Forms.Label txtTTSV;
        private System.Windows.Forms.Button btnChonThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCachDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbSoLuongTrongKho;
        private System.Windows.Forms.TextBox tbGiaThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenThuoc;
        private System.Windows.Forms.TextBox tbMaThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.TextBox tbCbDonVi;
        private System.Windows.Forms.TextBox tbdateHanDung;
    }
}