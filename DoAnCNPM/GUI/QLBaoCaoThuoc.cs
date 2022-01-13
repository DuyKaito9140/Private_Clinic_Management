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
    public partial class QLBaoCaoThuoc : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public QLBaoCaoThuoc()
        {
            InitializeComponent();
        }
        public void LoadBCTH()
        {
            var listBCTh = from bct in dbe.BAOCAODUNGTHUOCs
                         select new
                         {
                             MaBaoCaoThuoc = bct.MaBaoCaoThuoc,
                             ThangBaoCao = bct.ThangBaoCao,
                             NamBaoCao = bct.NamBaoCao,
                             SoLuongDaDung = bct.SoLuongDaDung
                         };
            dgvBCThuoc.DataSource = listBCTh.ToList();

            //DataBindings thông tin bệnh nhân
            CheckBindingDT();
        }

        public void CheckBindingDT()
        {
            tbMaBCTh.DataBindings.Clear();
            tbMaBCTh.DataBindings.Add(new Binding("Text", dgvBCThuoc.DataSource, "MaBaoCaoThuoc"));
            tbThangBCTh.DataBindings.Clear();
            tbThangBCTh.DataBindings.Add(new Binding("Text", dgvBCThuoc.DataSource, "ThangBaoCao"));
            tbNamBaoTh.DataBindings.Clear();
            tbNamBaoTh.DataBindings.Add(new Binding("Text", dgvBCThuoc.DataSource, "NamBaoCao"));
            tbSoLuongThuocDaDung.DataBindings.Clear();
            tbSoLuongThuocDaDung.DataBindings.Add(new Binding("Text", dgvBCThuoc.DataSource, "SoLuongDaDung"));

        }

        private void QLBaoCaoThuoc_Load(object sender, EventArgs e)
        {
            LoadBCTH();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeThuoc f1 = new ThongKeThuoc();
            f1.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_luu_bcth = new DBE_QLPMT();
            string mabct = tbMaBCTh.Text;
            BAOCAODUNGTHUOC bcthuoc = dbe_luu_bcth.BAOCAODUNGTHUOCs.Where(map => map.MaBaoCaoThuoc == mabct).SingleOrDefault();
            if (bcthuoc != null)
            {
                MessageBox.Show("Mã Báo Cáo Doanh Thu đã tồn tại !");
                tbMaBCTh.ReadOnly = false;
                Content.suaMaBc = "TrungMa";
            }
            else
            {
                bcthuoc = new BAOCAODUNGTHUOC();
                bcthuoc.MaBaoCaoThuoc = tbMaBCTh.Text;
                bcthuoc.ThangBaoCao = int.Parse(tbThangBCTh.Text);
                bcthuoc.NamBaoCao = int.Parse(tbNamBaoTh.Text);
                bcthuoc.SoLuongDaDung = tbSoLuongThuocDaDung.Text;
                dbe_luu_bcth.BAOCAODUNGTHUOCs.Add(bcthuoc);
                dbe_luu_bcth.SaveChanges();
                LoadBCTH();
                tbMaBCTh.ReadOnly = true;
                Content.suaMaBc = "";
                MessageBox.Show("Hoàn tất thống kê Báo Cáo Thuốc !");
            }
        }

        private void QLBaoCaoThuoc_Activated(object sender, EventArgs e)
        {
            if (Content.uptrangthai == "TKThuocXong")
            {
                tbMaBCTh.Text = Content.BCMaBCTh;
                tbThangBCTh.Text = Content.BCThang;
                tbNamBaoTh.Text = Content.BCNam;
                tbSoLuongThuocDaDung.Text = Content.BCSoLuongThuocDung;
                if (Content.suaMaBc == "")
                {
                    Content.BCMaBCTh = "";
                    Content.BCThang = "";
                    Content.BCNam = "";
                    Content.BCSoLuongThuocDung = "";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
