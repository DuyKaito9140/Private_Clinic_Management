namespace QLPMT
{
    partial class QLBaoCaoDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLBaoCaoDoanhThu));
            this.txtNam = new System.Windows.Forms.Label();
            this.TongDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNamBC = new System.Windows.Forms.TextBox();
            this.tbSoLuongBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTongDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbThangBC = new System.Windows.Forms.TextBox();
            this.tbMaBCDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.Label();
            this.dgvBaoCaoDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTTSV = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNam
            // 
            this.txtNam.AutoSize = true;
            this.txtNam.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(54, 199);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(143, 26);
            this.txtNam.TabIndex = 181;
            this.txtNam.Text = "Năm Báo Cáo:";
            // 
            // TongDoanhThu
            // 
            this.TongDoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongDoanhThu.DataPropertyName = "TongDoanhThu";
            this.TongDoanhThu.HeaderText = "Tổng Doanh Thu Của Tháng";
            this.TongDoanhThu.MinimumWidth = 6;
            this.TongDoanhThu.Name = "TongDoanhThu";
            // 
            // SoBenhNhan
            // 
            this.SoBenhNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoBenhNhan.DataPropertyName = "SoBenhNhan";
            this.SoBenhNhan.HeaderText = "Số Lượng Bệnh Nhân Trong Tháng";
            this.SoBenhNhan.MinimumWidth = 6;
            this.SoBenhNhan.Name = "SoBenhNhan";
            this.SoBenhNhan.Width = 127;
            // 
            // NamBaoCao
            // 
            this.NamBaoCao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NamBaoCao.DataPropertyName = "NamBaoCao";
            this.NamBaoCao.HeaderText = "Năm Báo Cáo";
            this.NamBaoCao.MinimumWidth = 6;
            this.NamBaoCao.Name = "NamBaoCao";
            this.NamBaoCao.Width = 84;
            // 
            // ThangBaoCao
            // 
            this.ThangBaoCao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThangBaoCao.DataPropertyName = "ThangBaoCao";
            this.ThangBaoCao.HeaderText = "Tháng Báo Cáo";
            this.ThangBaoCao.MinimumWidth = 6;
            this.ThangBaoCao.Name = "ThangBaoCao";
            this.ThangBaoCao.Width = 84;
            // 
            // MaBCDT
            // 
            this.MaBCDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaBCDT.DataPropertyName = "MaBCDT";
            this.MaBCDT.HeaderText = "Mã BCDT";
            this.MaBCDT.MinimumWidth = 6;
            this.MaBCDT.Name = "MaBCDT";
            this.MaBCDT.Width = 90;
            // 
            // tbNamBC
            // 
            this.tbNamBC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamBC.Location = new System.Drawing.Point(227, 194);
            this.tbNamBC.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamBC.Name = "tbNamBC";
            this.tbNamBC.ReadOnly = true;
            this.tbNamBC.Size = new System.Drawing.Size(217, 31);
            this.tbNamBC.TabIndex = 182;
            // 
            // tbSoLuongBN
            // 
            this.tbSoLuongBN.BackColor = System.Drawing.SystemColors.Control;
            this.tbSoLuongBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongBN.Location = new System.Drawing.Point(693, 101);
            this.tbSoLuongBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuongBN.Name = "tbSoLuongBN";
            this.tbSoLuongBN.ReadOnly = true;
            this.tbSoLuongBN.Size = new System.Drawing.Size(237, 31);
            this.tbSoLuongBN.TabIndex = 179;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(469, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 26);
            this.label7.TabIndex = 178;
            this.label7.Text = "Số Lượng Bệnh Nhân:";
            // 
            // tbTongDT
            // 
            this.tbTongDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTongDT.Location = new System.Drawing.Point(693, 150);
            this.tbTongDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbTongDT.Name = "tbTongDT";
            this.tbTongDT.ReadOnly = true;
            this.tbTongDT.Size = new System.Drawing.Size(237, 31);
            this.tbTongDT.TabIndex = 177;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 176;
            this.label6.Text = "Tổng Doanh Thu:";
            // 
            // tbThangBC
            // 
            this.tbThangBC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThangBC.Location = new System.Drawing.Point(227, 146);
            this.tbThangBC.Margin = new System.Windows.Forms.Padding(4);
            this.tbThangBC.Name = "tbThangBC";
            this.tbThangBC.ReadOnly = true;
            this.tbThangBC.Size = new System.Drawing.Size(217, 31);
            this.tbThangBC.TabIndex = 175;
            // 
            // tbMaBCDT
            // 
            this.tbMaBCDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBCDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaBCDT.Location = new System.Drawing.Point(227, 99);
            this.tbMaBCDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaBCDT.Name = "tbMaBCDT";
            this.tbMaBCDT.ReadOnly = true;
            this.tbMaBCDT.Size = new System.Drawing.Size(217, 31);
            this.tbMaBCDT.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 173;
            this.label1.Text = "Tháng Báo Cáo:";
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(54, 106);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(104, 26);
            this.txtmabn.TabIndex = 172;
            this.txtmabn.Text = "Mã BCDT:";
            // 
            // dgvBaoCaoDoanhThu
            // 
            this.dgvBaoCaoDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBCDT,
            this.ThangBaoCao,
            this.NamBaoCao,
            this.SoBenhNhan,
            this.TongDoanhThu});
            this.dgvBaoCaoDoanhThu.Location = new System.Drawing.Point(10, 309);
            this.dgvBaoCaoDoanhThu.Name = "dgvBaoCaoDoanhThu";
            this.dgvBaoCaoDoanhThu.RowHeadersWidth = 62;
            this.dgvBaoCaoDoanhThu.RowTemplate.Height = 28;
            this.dgvBaoCaoDoanhThu.Size = new System.Drawing.Size(961, 259);
            this.dgvBaoCaoDoanhThu.TabIndex = 167;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(970, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 558);
            this.panel3.TabIndex = 165;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 10);
            this.panel2.TabIndex = 164;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 568);
            this.panel1.TabIndex = 163;
            // 
            // txtTTSV
            // 
            this.txtTTSV.AutoSize = true;
            this.txtTTSV.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTTSV.ForeColor = System.Drawing.Color.Blue;
            this.txtTTSV.Location = new System.Drawing.Point(112, 23);
            this.txtTTSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTTSV.Name = "txtTTSV";
            this.txtTTSV.Size = new System.Drawing.Size(788, 55);
            this.txtTTSV.TabIndex = 183;
            this.txtTTSV.Text = "QUẢN LÝ BÁO CÁO DOANH THU";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.LightYellow;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(153, 253);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThongKe.Size = new System.Drawing.Size(193, 40);
            this.btnThongKe.TabIndex = 186;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightYellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(695, 253);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnThoat.Size = new System.Drawing.Size(174, 40);
            this.btnThoat.TabIndex = 185;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightYellow;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(423, 253);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnLuu.Size = new System.Drawing.Size(181, 40);
            this.btnLuu.TabIndex = 184;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // QLBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTTSV);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.tbNamBC);
            this.Controls.Add(this.tbSoLuongBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTongDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbThangBC);
            this.Controls.Add(this.tbMaBCDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.dgvBaoCaoDoanhThu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG MẠCH TƯ";
            this.Activated += new System.EventHandler(this.QLBaoCaoDoanhThu_Activated);
            this.Load += new System.EventHandler(this.QLBaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBCDT;
        private System.Windows.Forms.TextBox tbNamBC;
        private System.Windows.Forms.TextBox tbSoLuongBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTongDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbThangBC;
        private System.Windows.Forms.TextBox tbMaBCDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.DataGridView dgvBaoCaoDoanhThu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTTSV;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
    }
}