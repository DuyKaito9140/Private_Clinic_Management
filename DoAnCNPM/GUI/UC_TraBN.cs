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
    public partial class UC_TraBN :  UserControl
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public UC_TraBN()
        {
            InitializeComponent();
            LoadBN();
        }

        public void LoadBN()
        {
            var listBN = from bn in dbe.QLBENHNHANs
                         select new
                         {
                             MaBN = bn.MaBN,
                             HoTen = bn.HoTen,
                             GioiTinh = bn.GioiTinh,
                             NgaySinh = bn.NgaySinh,
                             Sdt = bn.Sdt,
                             DiaChi = bn.DiaChi,
                         };
            dgvDSBenhNhan.DataSource = listBN.ToList();

            //DataBindings thông tin bệnh nhân
            CheckBinding();
        }

        public void CheckBinding()
        {
            tbMaBN.DataBindings.Clear();
            tbMaBN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "MaBN"));
            tbHoTenBN.DataBindings.Clear();
            tbHoTenBN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "HoTen"));
            tbCbGioiTinh.DataBindings.Clear();
            tbCbGioiTinh.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "GioiTinh"));
            tbdateNgaySinh.DataBindings.Clear();
            tbdateNgaySinh.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "NgaySinh"));
            tbSdt.DataBindings.Clear();
            tbSdt.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "Sdt"));
            tbDiaChi.DataBindings.Clear();
            tbDiaChi.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "DiaChi"));
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_search = new DBE_QLPMT();
            if (txbsearch.Text == "all" || txbsearch.Text == "AL" || txbsearch.Text == "tat ca" || txbsearch.Text == "tất cả" || txbsearch.Text == "TAT CA" || txbsearch.Text == "TẤT CẢ" || txbsearch.Text == "tatca" || txbsearch.Text == "TATCA" || txbsearch.Text == "tc" || txbsearch.Text == "TC")
            {
                LoadBN();
            }
            else if (txbsearch.Text == "Nam" || txbsearch.Text == "Nữ")
            {
                var timgioitinh = from bn in dbe_search.QLBENHNHANs
                                  where bn.GioiTinh == txbsearch.Text
                                  select new
                                  {
                                      MaBN = bn.MaBN,
                                      HoTen = bn.HoTen,
                                      GioiTinh = bn.GioiTinh,
                                      NgaySinh = bn.NgaySinh,
                                      Sdt = bn.Sdt,
                                      DiaChi = bn.DiaChi,
                                  };
                QLBENHNHAN hs = dbe_search.QLBENHNHANs.Where(h => h.GioiTinh == txbsearch.Text).FirstOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Bệnh Nhân không tồn tại !");
                    return;
                }
                dgvDSBenhNhan.DataSource = timgioitinh.ToList();
                CheckBinding();
            }
            else if (txbsearch.Text[0] == 'B' && txbsearch.Text[1] == 'N')
            {
                var timmaphieu = from bn in dbe_search.QLBENHNHANs
                                 where bn.MaBN == txbsearch.Text
                                 select new
                                 {
                                     MaBN = bn.MaBN,
                                     HoTen = bn.HoTen,
                                     GioiTinh = bn.GioiTinh,
                                     NgaySinh = bn.NgaySinh,
                                     Sdt = bn.Sdt,
                                     DiaChi = bn.DiaChi,
                                 };
                QLBENHNHAN hs = dbe_search.QLBENHNHANs.Where(h => h.MaBN == txbsearch.Text).SingleOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Bệnh Nhân không tồn tại !");
                    return;
                }
                dgvDSBenhNhan.DataSource = timmaphieu.ToList();
                CheckBinding();
            }
            else
            {
                var timten = from ten in dbe_search.QLBENHNHANs
                             where ten.HoTen == txbsearch.Text
                             select new
                             {
                                 MaBN = ten.MaBN,
                                 HoTen = ten.HoTen,
                                 GioiTinh = ten.GioiTinh,
                                 NgaySinh = ten.NgaySinh,
                                 Sdt = ten.Sdt,
                                 DiaChi = ten.DiaChi,
                             };
                QLBENHNHAN bn = dbe_search.QLBENHNHANs.Where(h => h.HoTen == txbsearch.Text).FirstOrDefault();
                if (bn == null)
                {
                    MessageBox.Show("Bệnh Nhân không tồn tại !");
                    return;
                }
                dgvDSBenhNhan.DataSource = timten.ToList();
                CheckBinding();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBN();
        }
    }
}
