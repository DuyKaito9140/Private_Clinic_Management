namespace QLPMT
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.dgvSignIn = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameAdmin = new System.Windows.Forms.TextBox();
            this.tbpassAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCaptCha = new System.Windows.Forms.TextBox();
            this.tbNhapCap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNhaplaiMK = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignIn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSignIn
            // 
            this.dgvSignIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSignIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password});
            this.dgvSignIn.Location = new System.Drawing.Point(-16, 577);
            this.dgvSignIn.Name = "dgvSignIn";
            this.dgvSignIn.RowHeadersWidth = 62;
            this.dgvSignIn.RowTemplate.Height = 28;
            this.dgvSignIn.Size = new System.Drawing.Size(332, 97);
            this.dgvSignIn.TabIndex = 247;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 102;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(240, 593);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 50);
            this.button1.TabIndex = 249;
            this.button1.Text = "Đăng Ký";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbusername.Location = new System.Drawing.Point(352, 60);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(359, 34);
            this.tbusername.TabIndex = 253;
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbpass.Location = new System.Drawing.Point(352, 118);
            this.tbpass.Margin = new System.Windows.Forms.Padding(4);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(359, 34);
            this.tbpass.TabIndex = 252;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(72, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 28);
            this.label3.TabIndex = 251;
            this.label3.Text = "Tên Đăng Nhập Mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(72, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 250;
            this.label2.Text = "Mật Khẩu Mới:";
            // 
            // tbNameAdmin
            // 
            this.tbNameAdmin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbNameAdmin.Location = new System.Drawing.Point(352, 69);
            this.tbNameAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameAdmin.Name = "tbNameAdmin";
            this.tbNameAdmin.Size = new System.Drawing.Size(359, 34);
            this.tbNameAdmin.TabIndex = 257;
            // 
            // tbpassAdmin
            // 
            this.tbpassAdmin.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbpassAdmin.Location = new System.Drawing.Point(352, 122);
            this.tbpassAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.tbpassAdmin.Name = "tbpassAdmin";
            this.tbpassAdmin.PasswordChar = '*';
            this.tbpassAdmin.Size = new System.Drawing.Size(359, 34);
            this.tbpassAdmin.TabIndex = 256;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 255;
            this.label1.Text = "Tên Đăng Nhập Admin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(72, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 28);
            this.label4.TabIndex = 254;
            this.label4.Text = "Mật Khẩu Admin:";
            // 
            // tbCaptCha
            // 
            this.tbCaptCha.Font = new System.Drawing.Font("Edwardian Script ITC", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCaptCha.ForeColor = System.Drawing.Color.Firebrick;
            this.tbCaptCha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbCaptCha.Location = new System.Drawing.Point(609, 176);
            this.tbCaptCha.Margin = new System.Windows.Forms.Padding(4);
            this.tbCaptCha.Name = "tbCaptCha";
            this.tbCaptCha.Size = new System.Drawing.Size(102, 58);
            this.tbCaptCha.TabIndex = 258;
            this.tbCaptCha.Text = "2107";
            // 
            // tbNhapCap
            // 
            this.tbNhapCap.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapCap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbNhapCap.Location = new System.Drawing.Point(352, 200);
            this.tbNhapCap.Margin = new System.Windows.Forms.Padding(4);
            this.tbNhapCap.Name = "tbNhapCap";
            this.tbNhapCap.Size = new System.Drawing.Size(238, 34);
            this.tbNhapCap.TabIndex = 259;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(72, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 28);
            this.label5.TabIndex = 260;
            this.label5.Text = "Nhập Mã Captcha:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Blue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(555, 593);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(199, 50);
            this.btnThoat.TabIndex = 261;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNhapCap);
            this.groupBox1.Controls.Add(this.tbpassAdmin);
            this.groupBox1.Controls.Add(this.tbCaptCha);
            this.groupBox1.Controls.Add(this.tbNameAdmin);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(89, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 252);
            this.groupBox1.TabIndex = 262;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xác thực tài khoản Admin";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aqua;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbNhaplaiMK);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbusername);
            this.groupBox2.Controls.Add(this.tbpass);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(86, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 234);
            this.groupBox2.TabIndex = 263;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(72, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 28);
            this.label6.TabIndex = 254;
            this.label6.Text = "Nhập Lại Mật Khẩu:";
            // 
            // tbNhaplaiMK
            // 
            this.tbNhaplaiMK.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhaplaiMK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbNhaplaiMK.Location = new System.Drawing.Point(352, 172);
            this.tbNhaplaiMK.Margin = new System.Windows.Forms.Padding(4);
            this.tbNhaplaiMK.Name = "tbNhaplaiMK";
            this.tbNhaplaiMK.PasswordChar = '*';
            this.tbNhaplaiMK.Size = new System.Drawing.Size(359, 34);
            this.tbNhaplaiMK.TabIndex = 255;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 670);
            this.pictureBox1.TabIndex = 264;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSignIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG MẠCH TƯ";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignIn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSignIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameAdmin;
        private System.Windows.Forms.TextBox tbpassAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCaptCha;
        private System.Windows.Forms.TextBox tbNhapCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNhaplaiMK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}