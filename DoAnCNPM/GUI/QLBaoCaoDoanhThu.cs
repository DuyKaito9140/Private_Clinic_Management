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
    public partial class QLBaoCaoDoanhThu : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public QLBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        public void LoadQLDT()
        {
            var listDT = from dt in dbe.BAOCAODOANHTHUs
                         select new
                         {
                             MaBCDT = dt.MaBCDT,
                             ThangBaoCao = dt.ThangBaoCao,
                             NamBaoCao = dt.NamBaoCao,
                             SoBenhNhan = dt.SoBenhNhan,
                             TongDoanhThu = dt.TongDoanhThu
                         };
            dgvBaoCaoDoanhThu.DataSource = listDT.ToList();

            //DataBindings thông tin bệnh nhân
            CheckBindingDT();
        }

        public void CheckBindingDT()
        {
            tbMaBCDT.DataBindings.Clear();
            tbMaBCDT.DataBindings.Add(new Binding("Text", dgvBaoCaoDoanhThu.DataSource, "MaBCDT"));
            tbThangBC.DataBindings.Clear();
            tbThangBC.DataBindings.Add(new Binding("Text", dgvBaoCaoDoanhThu.DataSource, "ThangBaoCao"));
            tbNamBC.DataBindings.Clear();
            tbNamBC.DataBindings.Add(new Binding("Text", dgvBaoCaoDoanhThu.DataSource, "NamBaoCao"));
            tbSoLuongBN.DataBindings.Clear();
            tbSoLuongBN.DataBindings.Add(new Binding("Text", dgvBaoCaoDoanhThu.DataSource, "SoBenhNhan"));
            tbTongDT.DataBindings.Clear();
            tbTongDT.DataBindings.Add(new Binding("Text", dgvBaoCaoDoanhThu.DataSource, "TongDoanhThu"));
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeHoaDon f1 = new ThongKeHoaDon();
            tbMaBCDT.ReadOnly = false;
            f1.Show();
        }

        private void QLBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadQLDT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            tbMaBCDT.ReadOnly = false;
            this.Hide();
        }

        private void QLBaoCaoDoanhThu_Activated(object sender, EventArgs e)
        {
            if(Content.feel == "ThongKeXong")
            {
                tbMaBCDT.Text = Content.DMaBCDT;
                tbThangBC.Text = Content.DThangBC;
                tbNamBC.Text = Content.DNamBC;
                tbSoLuongBN.Text = Content.DSoBN;
                tbTongDT.Text = Content.DTongDT;
                if(Content.suaMaBc == "")
                {
                    Content.feel = "";
                    Content.DMaBCDT = "";
                    Content.DThangBC = "";
                    Content.DNamBC = "";
                    Content.DSoBN = "";
                    Content.DTongDT = "";
                }               
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_luu_dt = new DBE_QLPMT();
            string mabc = tbMaBCDT.Text;
            BAOCAODOANHTHU dthu = dbe_luu_dt.BAOCAODOANHTHUs.Where(map => map.MaBCDT == mabc).SingleOrDefault();
            if (dthu != null)
            {
                MessageBox.Show("Mã Báo Cáo Doanh Thu đã tồn tại !");
                tbMaBCDT.ReadOnly = false;
                Content.suaMaBc = "TrungMa";
            }
            else
            {
                dthu = new BAOCAODOANHTHU();
                dthu.MaBCDT = mabc;
                dthu.ThangBaoCao = tbThangBC.Text;
                dthu.NamBaoCao = tbNamBC.Text;
                dthu.SoBenhNhan = tbSoLuongBN.Text;
                dthu.TongDoanhThu = tbTongDT.Text;
                dbe_luu_dt.BAOCAODOANHTHUs.Add(dthu);
                dbe_luu_dt.SaveChanges();
                LoadQLDT();
                tbMaBCDT.ReadOnly = true;
                Content.suaMaBc = "";
                MessageBox.Show("Hoàn tất thống kê Báo Cáo Doanh Thu !");
            }    
        }
    }
}
