using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPMT
{   
    public partial class DashBoard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public DashBoard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home f1 = new UC_Home();
            AddControlsToPanel(f1);
            UC_TraBN f2 = new UC_TraBN();
            AddControlsToPanel(f2);
            UC_HoaDon f3 = new UC_HoaDon();
            AddControlsToPanel(f3);
            UC_PhieuKham f4 = new UC_PhieuKham();
            AddControlsToPanel(f4);
            UC_DanhSachBN f5 = new UC_DanhSachBN();
            AddControlsToPanel(f5);
            UC_BCDoanhThu f6 = new UC_BCDoanhThu();
            AddControlsToPanel(f6);
            UC_QLThuoc f7 = new UC_QLThuoc();
            AddControlsToPanel(f7);
            UC_LichKham f8 = new UC_LichKham();
            AddControlsToPanel(f8);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                //panelControls.Width = panelControls.Width - 10;
                //panelControls.Location = new Point(219, 140);
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                //panelControls.Width = panelControls.Width + 10;
                panelLeft.Width = panelLeft.Width - 10;               
                //panelControls.Location = new Point(59, 140);
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;                   
                    this.Refresh();
                }
            }
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            UC_Home f1 = new UC_Home();
            AddControlsToPanel(f1);
            lbuser.Text = Content.TKten;
            lbquyen.Text = Content.TKQuyen;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void moveSidePanel(Control btn)
        {
            //panelSide.Top = btn.Top;
            //panelSide.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.Hour+":"+dt.Minute+":"+dt.Second;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home f1 = new UC_Home();
            AddControlsToPanel(f1);
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHoaDon);
            UC_HoaDon f3 = new UC_HoaDon();
            AddControlsToPanel(f3);
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBenhNhan);
            UC_TraBN f2 = new UC_TraBN();
            AddControlsToPanel(f2);
            
        }

        public void btnPhieuKham_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPhieuKham);
            UC_PhieuKham f4= new UC_PhieuKham();
            AddControlsToPanel(f4);

        }

        private void btnDSKham_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDSKham);
            UC_DanhSachBN f5= new UC_DanhSachBN();
            AddControlsToPanel(c: f5);
        }

        private void btnBCDoanhThu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBCDoanhThu);
            UC_BCDoanhThu f6 = new UC_BCDoanhThu();
            AddControlsToPanel(f6);

        }

        private void btnBCThuoc_Click(object sender, EventArgs e)
        {

            moveSidePanel(btnQLThuoc);
            UC_QLThuoc f7 = new UC_QLThuoc();
            AddControlsToPanel(f7);
        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnLich);
            UC_LichKham f8 = new UC_LichKham();
            AddControlsToPanel(f8);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Content.TKten = "";
                Content.suaMaBc = "Admin";
                Logins logins = new Logins();
                logins.Show();
                this.Hide();
            }
        }
    }
}
