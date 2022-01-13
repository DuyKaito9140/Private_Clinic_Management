using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPMT
{
    public partial class UC_LichKham : UserControl
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public UC_LichKham()
        {
            InitializeComponent();            
        }
        public void LoadLichKham() 
        {
            var listLK = from lich in dbe.QLLiches
                         select new
                         {
                             MaBN = lich.MaBN,
                             HoTen = lich.QLBENHNHAN.HoTen,
                             Sdt = lich.QLBENHNHAN.Sdt,
                             MaLich = lich.MaLich,
                             NgayDatLich = lich.NgayDatLich,
                             GioDatLich = lich.GioDatLich
                         };
            dgvDSLich.DataSource = listLK.ToList();
            CheckBinding();
        }
        public void CheckBinding()
        {
            tbmabn.DataBindings.Clear();
            tbmabn.DataBindings.Add(new Binding("Text", dgvDSLich.DataSource, "MaBN"));
            tbhoten.DataBindings.Clear();
            tbhoten.DataBindings.Add(new Binding("Text", dgvDSLich.DataSource, "HoTen"));
            tbsdt.DataBindings.Clear();
            tbsdt.DataBindings.Add(new Binding("Text", dgvDSLich.DataSource, "Sdt"));
            tbMaLich.DataBindings.Clear();
            tbMaLich.DataBindings.Add(new Binding("Text", dgvDSLich.DataSource, "MaLich"));
            tbNgayDat.DataBindings.Clear();
            tbNgayDat.DataBindings.Add(new Binding("Text", dgvDSLich.DataSource, "NgayDatLich"));
            tbGioDat.DataBindings.Clear();
            tbGioDat.DataBindings.Add(new Binding("Text", dgvDSLich.DataSource, "GioDatLich"));

        }

        private void btnNhapLichKham_Click(object sender, EventArgs e)
        {
            NhapLichKham f1 = new NhapLichKham();
            f1.Show();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_search = new DBE_QLPMT();
            if (txbsearch.Text == "all" || txbsearch.Text == "AL" || txbsearch.Text == "tat ca" || txbsearch.Text == "tất cả" || txbsearch.Text == "TAT CA" || txbsearch.Text == "TẤT CẢ" || txbsearch.Text == "tatca" || txbsearch.Text == "TATCA" || txbsearch.Text == "tc" || txbsearch.Text == "TC")
            {
                LoadLichKham();
            }           
            else if (txbsearch.Text[0] == 'L' && txbsearch.Text[1] == 'K')
            {
                var timmalich = from lich in dbe_search.QLLiches
                                 where lich.MaLich == txbsearch.Text
                                 select new
                                 {
                                     MaBN = lich.MaBN,
                                     HoTen = lich.QLBENHNHAN.HoTen,
                                     Sdt = lich.QLBENHNHAN.Sdt,
                                     MaLich = lich.MaLich,
                                     NgayDatLich = lich.NgayDatLich,
                                     GioDatLich = lich.GioDatLich
                                 };
                QLLich llich = dbe_search.QLLiches.Where(h => h.MaLich == txbsearch.Text).SingleOrDefault();
                if (llich == null)
                {
                    MessageBox.Show("Lịch khám không tồn tại !");
                    return;
                }
                dgvDSLich.DataSource = timmalich.ToList();
                CheckBinding();
            }
            else if (txbsearch.Text[0] == 'B' && txbsearch.Text[1] == 'N')
            {
                var timmabn = from lich in dbe_search.QLLiches
                                where lich.MaBN == txbsearch.Text
                                select new
                                {
                                    MaBN = lich.MaBN,
                                    HoTen = lich.QLBENHNHAN.HoTen,
                                    Sdt = lich.QLBENHNHAN.Sdt,
                                    MaLich = lich.MaLich,
                                    NgayDatLich = lich.NgayDatLich,
                                    GioDatLich = lich.GioDatLich
                                };
                QLLich llich = dbe_search.QLLiches.Where(h => h.MaBN == txbsearch.Text).SingleOrDefault();
                if (llich == null)
                {
                    MessageBox.Show("Lịch khám không tồn tại !");
                    return;
                }
                dgvDSLich.DataSource = timmabn.ToList();
                CheckBinding();
            }
            else if (Content.IsNumber(txbsearch.Text[0]))
            {
                var timmagio = from lich in dbe_search.QLLiches
                                where lich.GioDatLich == txbsearch.Text
                                select new
                                {
                                    MaBN = lich.MaBN,
                                    HoTen = lich.QLBENHNHAN.HoTen,
                                    Sdt = lich.QLBENHNHAN.Sdt,
                                    MaLich = lich.MaLich,
                                    NgayDatLich = lich.NgayDatLich,
                                    GioDatLich = lich.GioDatLich
                                };
                QLLich llich = dbe_search.QLLiches.Where(h => h.GioDatLich == txbsearch.Text).FirstOrDefault();
                if (llich == null)
                {
                    MessageBox.Show("Lịch khám không tồn tại !");
                    return;
                }
                dgvDSLich.DataSource = timmagio.ToList();
                CheckBinding();
            }
            else
            {
                var timten = from lich in dbe_search.QLLiches
                             where lich.QLBENHNHAN.HoTen == txbsearch.Text
                             select new
                             {
                                 MaBN = lich.MaBN,
                                 HoTen = lich.QLBENHNHAN.HoTen,
                                 Sdt = lich.QLBENHNHAN.Sdt,
                                 MaLich = lich.MaLich,
                                 NgayDatLich = lich.NgayDatLich,
                                 GioDatLich = lich.GioDatLich
                             };
                QLLich bn = dbe_search.QLLiches.Where(h => h.QLBENHNHAN.HoTen == txbsearch.Text).FirstOrDefault();
                if (bn == null)
                {
                    MessageBox.Show("Bệnh Nhân không tồn tại !");
                    return;
                }
                dgvDSLich.DataSource =timten.ToList();
                CheckBinding();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLichKham();
        }

        private void UC_LichKham_Load(object sender, EventArgs e)
        {
            LoadLichKham();
        }
    }
}
;