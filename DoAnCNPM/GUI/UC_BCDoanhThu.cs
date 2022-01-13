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
    
    public partial class UC_BCDoanhThu : UserControl
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public UC_BCDoanhThu()
        {
            InitializeComponent();
            LoadDT();
        }
        public void LoadDT()
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
        private void btnTim_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_search = new DBE_QLPMT();
            if (txbsearch.Text == "all" || txbsearch.Text == "AL" || txbsearch.Text == "tat ca" || txbsearch.Text == "tất cả" || txbsearch.Text == "TAT CA" || txbsearch.Text == "TẤT CẢ" || txbsearch.Text == "tatca" || txbsearch.Text == "TATCA" || txbsearch.Text == "tc" || txbsearch.Text == "TC")
            {
                LoadDT();
            }
            else if (Content.IsNumber(txbsearch.Text[0]) && txbsearch.Text.Length < 3)
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
                BAOCAODOANHTHU dth = dbe_search.BAOCAODOANHTHUs.Where(h => h.ThangBaoCao == txbsearch.Text).FirstOrDefault();
                if (dth == null)
                {
                    MessageBox.Show("Báo Cáo Doanh Thu không tồn tại !");
                    return;
                }
                dgvBaoCaoDoanhThu.DataSource = listDT.ToList();
                CheckBindingDT();
            }
            else if (Content.IsNumber(txbsearch.Text[0]) && txbsearch.Text.Length > 2)
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
                BAOCAODOANHTHU dth = dbe_search.BAOCAODOANHTHUs.Where(h => h.NamBaoCao == txbsearch.Text).FirstOrDefault();
                if (dth == null)
                {
                    MessageBox.Show("Báo Cáo Doanh Thu không tồn tại !");
                    return;
                }
                dgvBaoCaoDoanhThu.DataSource = listDT.ToList();
                CheckBindingDT();
            }
            else
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
                BAOCAODOANHTHU dth = dbe_search.BAOCAODOANHTHUs.Where(h => h.MaBCDT == txbsearch.Text).SingleOrDefault();
                if (dth == null)
                {
                    MessageBox.Show("Báo Cáo Doanh Thu không tồn tại !");
                    return;
                }
                dgvBaoCaoDoanhThu.DataSource = listDT.ToList();
                CheckBindingDT();
            }            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDT();
        }

        private void btnQLBCDT_Click(object sender, EventArgs e)
        {
            QLBaoCaoDoanhThu f1 = new QLBaoCaoDoanhThu();
            f1.Show();
        }
    }
}
