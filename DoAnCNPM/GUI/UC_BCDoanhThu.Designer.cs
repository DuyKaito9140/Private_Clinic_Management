
namespace QLPMT
{
    partial class UC_BCDoanhThu
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
            this.dgvBaoCaoDoanhThu = new System.Windows.Forms.DataGridView();
            this.MaBCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQLBCDT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.tbSoLuongBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTongDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbThangBC = new System.Windows.Forms.TextBox();
            this.tbMaBCDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmabn = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbNamBC = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 560);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 10);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(971, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 550);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(961, 43);
            this.panel4.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(349, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 36);
            this.label9.TabIndex = 5;
            this.label9.Text = "BÁO CÁO DOANH THU";
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
            this.dgvBaoCaoDoanhThu.Location = new System.Drawing.Point(10, 289);
            this.dgvBaoCaoDoanhThu.Name = "dgvBaoCaoDoanhThu";
            this.dgvBaoCaoDoanhThu.RowHeadersWidth = 62;
            this.dgvBaoCaoDoanhThu.RowTemplate.Height = 28;
            this.dgvBaoCaoDoanhThu.Size = new System.Drawing.Size(961, 259);
            this.dgvBaoCaoDoanhThu.TabIndex = 49;
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
            // ThangBaoCao
            // 
            this.ThangBaoCao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThangBaoCao.DataPropertyName = "ThangBaoCao";
            this.ThangBaoCao.HeaderText = "Tháng Báo Cáo";
            this.ThangBaoCao.MinimumWidth = 6;
            this.ThangBaoCao.Name = "ThangBaoCao";
            this.ThangBaoCao.Width = 84;
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
            // SoBenhNhan
            // 
            this.SoBenhNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoBenhNhan.DataPropertyName = "SoBenhNhan";
            this.SoBenhNhan.HeaderText = "Số Lượng Bệnh Nhân Trong Tháng";
            this.SoBenhNhan.MinimumWidth = 6;
            this.SoBenhNhan.Name = "SoBenhNhan";
            this.SoBenhNhan.Width = 127;
            // 
            // TongDoanhThu
            // 
            this.TongDoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongDoanhThu.DataPropertyName = "TongDoanhThu";
            this.TongDoanhThu.HeaderText = "Tổng Doanh Thu Của Tháng";
            this.TongDoanhThu.MinimumWidth = 6;
            this.TongDoanhThu.Name = "TongDoanhThu";
            // 
            // btnQLBCDT
            // 
            this.btnQLBCDT.BackColor = System.Drawing.Color.LightYellow;
            this.btnQLBCDT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLBCDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBCDT.Location = new System.Drawing.Point(59, 229);
            this.btnQLBCDT.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLBCDT.Name = "btnQLBCDT";
            this.btnQLBCDT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnQLBCDT.Size = new System.Drawing.Size(265, 40);
            this.btnQLBCDT.TabIndex = 148;
            this.btnQLBCDT.Text = "Quản Lý Báo Cáo Doanh Thu";
            this.btnQLBCDT.UseVisualStyleBackColor = false;
            this.btnQLBCDT.Click += new System.EventHandler(this.btnQLBCDT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 151;
            this.label3.Text = "Nhập từ khóa:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.Info;
            this.btnTim.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(855, 232);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 35);
            this.btnTim.TabIndex = 150;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txbsearch
            // 
            this.txbsearch.BackColor = System.Drawing.SystemColors.Info;
            this.txbsearch.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsearch.Location = new System.Drawing.Point(566, 232);
            this.txbsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbsearch.Name = "txbsearch";
            this.txbsearch.Size = new System.Drawing.Size(273, 34);
            this.txbsearch.TabIndex = 149;
            // 
            // tbSoLuongBN
            // 
            this.tbSoLuongBN.BackColor = System.Drawing.SystemColors.Control;
            this.tbSoLuongBN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongBN.Location = new System.Drawing.Point(680, 81);
            this.tbSoLuongBN.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuongBN.Name = "tbSoLuongBN";
            this.tbSoLuongBN.ReadOnly = true;
            this.tbSoLuongBN.Size = new System.Drawing.Size(250, 31);
            this.tbSoLuongBN.TabIndex = 159;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(469, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 26);
            this.label7.TabIndex = 158;
            this.label7.Text = "Số Lượng Bệnh Nhân:";
            // 
            // tbTongDT
            // 
            this.tbTongDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTongDT.Location = new System.Drawing.Point(680, 125);
            this.tbTongDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbTongDT.Name = "tbTongDT";
            this.tbTongDT.ReadOnly = true;
            this.tbTongDT.Size = new System.Drawing.Size(250, 31);
            this.tbTongDT.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 156;
            this.label6.Text = "Tổng Doanh Thu:";
            // 
            // tbThangBC
            // 
            this.tbThangBC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThangBC.Location = new System.Drawing.Point(209, 125);
            this.tbThangBC.Margin = new System.Windows.Forms.Padding(4);
            this.tbThangBC.Name = "tbThangBC";
            this.tbThangBC.ReadOnly = true;
            this.tbThangBC.Size = new System.Drawing.Size(225, 31);
            this.tbThangBC.TabIndex = 155;
            // 
            // tbMaBCDT
            // 
            this.tbMaBCDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBCDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMaBCDT.Location = new System.Drawing.Point(209, 78);
            this.tbMaBCDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaBCDT.Name = "tbMaBCDT";
            this.tbMaBCDT.ReadOnly = true;
            this.tbMaBCDT.Size = new System.Drawing.Size(225, 31);
            this.tbMaBCDT.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 153;
            this.label1.Text = "Tháng Báo Cáo:";
            // 
            // txtmabn
            // 
            this.txtmabn.AutoSize = true;
            this.txtmabn.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmabn.Location = new System.Drawing.Point(54, 85);
            this.txtmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtmabn.Name = "txtmabn";
            this.txtmabn.Size = new System.Drawing.Size(104, 26);
            this.txtmabn.TabIndex = 152;
            this.txtmabn.Text = "Mã BCDT:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightYellow;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(345, 229);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnRefresh.Size = new System.Drawing.Size(89, 37);
            this.btnRefresh.TabIndex = 160;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbNamBC
            // 
            this.tbNamBC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamBC.Location = new System.Drawing.Point(209, 173);
            this.tbNamBC.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamBC.Name = "tbNamBC";
            this.tbNamBC.ReadOnly = true;
            this.tbNamBC.Size = new System.Drawing.Size(225, 31);
            this.tbNamBC.TabIndex = 162;
            // 
            // txtNam
            // 
            this.txtNam.AutoSize = true;
            this.txtNam.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(54, 178);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(143, 26);
            this.txtNam.TabIndex = 161;
            this.txtNam.Text = "Năm Báo Cáo:";
            // 
            // UC_BCDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.tbNamBC);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbSoLuongBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTongDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbThangBC);
            this.Controls.Add(this.tbMaBCDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmabn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txbsearch);
            this.Controls.Add(this.btnQLBCDT);
            this.Controls.Add(this.dgvBaoCaoDoanhThu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_BCDoanhThu";
            this.Size = new System.Drawing.Size(981, 560);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvBaoCaoDoanhThu;
        private System.Windows.Forms.Button btnQLBCDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txbsearch;
        private System.Windows.Forms.TextBox tbSoLuongBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTongDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbThangBC;
        private System.Windows.Forms.TextBox tbMaBCDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtmabn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBCDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDoanhThu;
        private System.Windows.Forms.TextBox tbNamBC;
        private System.Windows.Forms.Label txtNam;
    }
}
