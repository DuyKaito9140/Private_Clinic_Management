namespace QLPMT
{
    partial class QLBaoCaoThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLBaoCaoThuoc));
            this.dgvBCThuoc = new System.Windows.Forms.DataGridView();
            this.MaBaoCaoThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDaDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTTSV = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tbNamBaoTh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSoLuongThuocDaDung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbThangBCTh = new System.Windows.Forms.TextBox();
            this.tbMaBCTh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBCThuoc
            // 
            this.dgvBCThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBaoCaoThuoc,
            this.ThangBaoCao,
            this.NamBaoCao,
            this.SoLuongDaDung});
            this.dgvBCThuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBCThuoc.Location = new System.Drawing.Point(0, 402);
            this.dgvBCThuoc.Name = "dgvBCThuoc";
            this.dgvBCThuoc.RowHeadersWidth = 62;
            this.dgvBCThuoc.RowTemplate.Height = 28;
            this.dgvBCThuoc.Size = new System.Drawing.Size(859, 251);
            this.dgvBCThuoc.TabIndex = 51;
            // 
            // MaBaoCaoThuoc
            // 
            this.MaBaoCaoThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaBaoCaoThuoc.DataPropertyName = "MaBaoCaoThuoc";
            this.MaBaoCaoThuoc.HeaderText = "Mã BC Thuốc";
            this.MaBaoCaoThuoc.MinimumWidth = 6;
            this.MaBaoCaoThuoc.Name = "MaBaoCaoThuoc";
            this.MaBaoCaoThuoc.Width = 112;
            // 
            // ThangBaoCao
            // 
            this.ThangBaoCao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThangBaoCao.DataPropertyName = "ThangBaoCao";
            this.ThangBaoCao.HeaderText = "Tháng Báo Cáo";
            this.ThangBaoCao.MinimumWidth = 6;
            this.ThangBaoCao.Name = "ThangBaoCao";
            this.ThangBaoCao.Width = 102;
            // 
            // NamBaoCao
            // 
            this.NamBaoCao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NamBaoCao.DataPropertyName = "NamBaoCao";
            this.NamBaoCao.HeaderText = "Năm Báo Cáo";
            this.NamBaoCao.MinimumWidth = 6;
            this.NamBaoCao.Name = "NamBaoCao";
            this.NamBaoCao.Width = 91;
            // 
            // SoLuongDaDung
            // 
            this.SoLuongDaDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongDaDung.DataPropertyName = "SoLuongDaDung";
            this.SoLuongDaDung.HeaderText = "Số Lượng Đã Dùng";
            this.SoLuongDaDung.MinimumWidth = 6;
            this.SoLuongDaDung.Name = "SoLuongDaDung";
            // 
            // txtTTSV
            // 
            this.txtTTSV.AutoSize = true;
            this.txtTTSV.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTSV.ForeColor = System.Drawing.Color.Blue;
            this.txtTTSV.Location = new System.Drawing.Point(104, 24);
            this.txtTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTTSV.Name = "txtTTSV";
            this.txtTTSV.Size = new System.Drawing.Size(666, 55);
            this.txtTTSV.TabIndex = 124;
            this.txtTTSV.Text = "BÁO CÁO SỬ DỤNG THUỐC";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.LightYellow;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(114, 329);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThongKe.Size = new System.Drawing.Size(157, 40);
            this.btnThongKe.TabIndex = 189;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightYellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(587, 329);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThoat.Size = new System.Drawing.Size(147, 40);
            this.btnThoat.TabIndex = 188;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightYellow;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(345, 329);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnLuu.Size = new System.Drawing.Size(159, 40);
            this.btnLuu.TabIndex = 187;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbNamBaoTh
            // 
            this.tbNamBaoTh.BackColor = System.Drawing.SystemColors.Control;
            this.tbNamBaoTh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamBaoTh.Location = new System.Drawing.Point(587, 150);
            this.tbNamBaoTh.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamBaoTh.Name = "tbNamBaoTh";
            this.tbNamBaoTh.ReadOnly = true;
            this.tbNamBaoTh.Size = new System.Drawing.Size(240, 31);
            this.tbNamBaoTh.TabIndex = 197;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(421, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 26);
            this.label7.TabIndex = 196;
            this.label7.Text = "Năm Báo Cáo:";
            // 
            // tbSoLuongThuocDaDung
            // 
            this.tbSoLuongThuocDaDung.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongThuocDaDung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbSoLuongThuocDaDung.Location = new System.Drawing.Point(41, 225);
            this.tbSoLuongThuocDaDung.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuongThuocDaDung.Multiline = true;
            this.tbSoLuongThuocDaDung.Name = "tbSoLuongThuocDaDung";
            this.tbSoLuongThuocDaDung.ReadOnly = true;
            this.tbSoLuongThuocDaDung.Size = new System.Drawing.Size(794, 84);
            this.tbSoLuongThuocDaDung.TabIndex = 195;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 26);
            this.label6.TabIndex = 194;
            this.label6.Text = "Số Lượng Thuốc Đã Dùng:";
            // 
            // tbThangBCTh
            // 
            this.tbThangBCTh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThangBCTh.Location = new System.Drawing.Point(587, 102);
            this.tbThangBCTh.Margin = new System.Windows.Forms.Padding(4);
            this.tbThangBCTh.Name = "tbThangBCTh";
            this.tbThangBCTh.ReadOnly = true;
            this.tbThangBCTh.Size = new System.Drawing.Size(240, 31);
            this.tbThangBCTh.TabIndex = 193;
            // 
            // tbMaBCTh
            // 
            this.tbMaBCTh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBCTh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaBCTh.Location = new System.Drawing.Point(185, 102);
            this.tbMaBCTh.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaBCTh.Name = "tbMaBCTh";
            this.tbMaBCTh.ReadOnly = true;
            this.tbMaBCTh.Size = new System.Drawing.Size(217, 31);
            this.tbMaBCTh.TabIndex = 192;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 191;
            this.label1.Text = "Tháng Báo Cáo:";
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(36, 102);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(141, 26);
            this.txtmabn.TabIndex = 190;
            this.txtmabn.Text = "Mã BC Thuốc:";
            // 
            // QLBaoCaoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(859, 653);
            this.Controls.Add(this.tbNamBaoTh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSoLuongThuocDaDung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbThangBCTh);
            this.Controls.Add(this.tbMaBCTh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTTSV);
            this.Controls.Add(this.dgvBCThuoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLBaoCaoThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG MẠCH TƯ";
            this.Activated += new System.EventHandler(this.QLBaoCaoThuoc_Activated);
            this.Load += new System.EventHandler(this.QLBaoCaoThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBCThuoc;
        private System.Windows.Forms.Label txtTTSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaoCaoThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDaDung;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox tbNamBaoTh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSoLuongThuocDaDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbThangBCTh;
        private System.Windows.Forms.TextBox tbMaBCTh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtmabn;
    }
}