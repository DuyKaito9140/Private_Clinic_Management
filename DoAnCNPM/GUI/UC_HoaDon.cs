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
    public partial class UC_HoaDon : UserControl
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public UC_HoaDon()
        {
            InitializeComponent();
            LoadHD();
        }
        public void LoadHD()
        {
            var listHD = from hd in dbe.QLBENHNHANs
                         select new
                         {
                            MaHD = hd.PHIEUKHAMBENH.HOADON.MaHD,
                            MaBN = hd.MaBN,
                            HoTen = hd.HoTen,
                            MaPhieuKham = hd.MaPhieuKham,
                            TenThuoc = hd.PHIEUKHAMBENH.THUOC.TenThuoc,
                            GiaThuoc = hd.PHIEUKHAMBENH.THUOC.GiaThuoc,
                            SoLuongDung = hd.PHIEUKHAMBENH.SoLuongDung,
                            TienKham = hd.PHIEUKHAMBENH.HOADON.TienKham,
                            TienThuoc = hd.PHIEUKHAMBENH.HOADON.TienThuoc 
                         };
            dgvHoaDon.DataSource = listHD.ToList();

            //DataBindings thông tin bệnh nhân
            BindingCheck();
        }
        public void BindingCheck()
        {
            tbMaHD.DataBindings.Clear();
            tbMaHD.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MaHD"));
            tbMaBN.DataBindings.Clear();
            tbMaBN.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MaBN"));
            tbHoTenBN.DataBindings.Clear();
            tbHoTenBN.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "HoTen"));
            tbTienKham.DataBindings.Clear();
            tbTienKham.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TienKham"));
            tbTienThuoc.DataBindings.Clear();
            tbTienThuoc.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TienThuoc"));
            tbMaPhieuKham.DataBindings.Clear();
            tbMaPhieuKham.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "MaPhieuKham"));
            tbThuoc.DataBindings.Clear();
            tbThuoc.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "TenThuoc"));
            tbGiaThuoc.DataBindings.Clear();
            tbGiaThuoc.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "GiaThuoc"));
            tbSoLuong.DataBindings.Clear();
            tbSoLuong.DataBindings.Add(new Binding("Text", dgvHoaDon.DataSource, "SoLuongDung"));
            SumMoney();
        }
        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            SumMoney();
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SumMoney();
        }
        public void SumMoney()
        {
            string maphieu = tbMaPhieuKham.Text;
            string tienkham = tbTienKham.Text;
            string tienthuoc = tbTienThuoc.Text;
            int sum = 0;
            if(maphieu == "")
            {
                tbnSumMoney.Text = "BN chưa được nhập phiếu khám !";
            }
            else if (tienkham == "" && tienthuoc == "")
            {
                tbnSumMoney.Text = "BN chưa được nhập hóa đơn !";
            }
            else if(tienkham=="" || tienthuoc == "")
            {
                tbnSumMoney.Text = "BN chưa được nhập đầy đủ hóa đơn !";
            }
            else
            {
                sum = int.Parse(tienkham) + int.Parse(tienthuoc);
                tbnSumMoney.Text = sum.ToString() + "   VNĐ";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_search = new DBE_QLPMT();
            if (txbsearch.Text == "all" || txbsearch.Text == "AL" || txbsearch.Text == "tat ca" || txbsearch.Text == "tất cả" || txbsearch.Text == "TAT CA" || txbsearch.Text == "TẤT CẢ" || txbsearch.Text == "tatca" || txbsearch.Text == "TATCA" || txbsearch.Text == "tc" || txbsearch.Text == "TC")
            {
                LoadHD();
            }
            else if (txbsearch.Text == "Nam" || txbsearch.Text == "Nữ")
            {
                var listHD = from hd in dbe.QLBENHNHANs
                             where hd.GioiTinh == txbsearch.Text
                             select new
                             {
                                 MaHD = hd.PHIEUKHAMBENH.HOADON.MaHD,
                                 MaBN = hd.MaBN,
                                 HoTen = hd.HoTen,
                                 MaPhieuKham = hd.MaPhieuKham,
                                 TenThuoc = hd.PHIEUKHAMBENH.THUOC.TenThuoc,
                                 GiaThuoc = hd.PHIEUKHAMBENH.THUOC.GiaThuoc,
                                 SoLuongDung = hd.PHIEUKHAMBENH.SoLuongDung,
                                 TienKham = hd.PHIEUKHAMBENH.HOADON.TienKham,
                                 TienThuoc = hd.PHIEUKHAMBENH.HOADON.TienThuoc
                             };                
                QLBENHNHAN hs = dbe_search.QLBENHNHANs.Where(h => h.GioiTinh == txbsearch.Text).FirstOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Hóa Đơn không tồn tại");
                    return;
                }
                dgvHoaDon.DataSource = listHD.ToList();
                BindingCheck();
            }
            else if (txbsearch.Text[0] == 'H' && txbsearch.Text[1] == 'D')
            {
                var listHD = from hd in dbe.QLBENHNHANs
                             where hd.PHIEUKHAMBENH.MaHD == txbsearch.Text
                             select new
                             {
                                 MaHD = hd.PHIEUKHAMBENH.MaHD,
                                 MaBN = hd.MaBN,
                                 HoTen = hd.HoTen,
                                 MaPhieuKham = hd.MaPhieuKham,
                                 TenThuoc = hd.PHIEUKHAMBENH.THUOC.TenThuoc,
                                 GiaThuoc = hd.PHIEUKHAMBENH.THUOC.GiaThuoc,
                                 SoLuongDung = hd.PHIEUKHAMBENH.SoLuongDung,
                                 TienKham = hd.PHIEUKHAMBENH.HOADON.TienKham,
                                 TienThuoc = hd.PHIEUKHAMBENH.HOADON.TienThuoc
                             };
                QLBENHNHAN hs = dbe_search.QLBENHNHANs.Where(h => h.PHIEUKHAMBENH.MaHD == txbsearch.Text).SingleOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Hóa Đơn không tồn tại");
                    return;
                }
                dgvHoaDon.DataSource = listHD.ToList();
                BindingCheck();
            }
            else if (txbsearch.Text[0] == 'P' && txbsearch.Text[1] == 'K')
            {
                var listHD = from hd in dbe.QLBENHNHANs
                             where hd.MaPhieuKham == txbsearch.Text
                             select new
                             {
                                 MaHD = hd.PHIEUKHAMBENH.HOADON.MaHD,
                                 MaBN = hd.MaBN,
                                 HoTen = hd.HoTen,
                                 MaPhieuKham = hd.MaPhieuKham,
                                 TenThuoc = hd.PHIEUKHAMBENH.THUOC.TenThuoc,
                                 GiaThuoc = hd.PHIEUKHAMBENH.THUOC.GiaThuoc,
                                 SoLuongDung = hd.PHIEUKHAMBENH.SoLuongDung,
                                 TienKham = hd.PHIEUKHAMBENH.HOADON.TienKham,
                                 TienThuoc = hd.PHIEUKHAMBENH.HOADON.TienThuoc
                             };
                QLBENHNHAN hs = dbe_search.QLBENHNHANs.Where(h => h.MaPhieuKham == txbsearch.Text).SingleOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Hóa Đơn không tồn tại");
                    return;
                }
                dgvHoaDon.DataSource = listHD.ToList();
                BindingCheck();
            }
            else
            {
                var listHD = from hd in dbe.QLBENHNHANs
                             where hd.HoTen == txbsearch.Text
                             select new
                             {
                                 MaHD = hd.PHIEUKHAMBENH.HOADON.MaHD,
                                 MaBN = hd.MaBN,
                                 HoTen = hd.HoTen,
                                 MaPhieuKham = hd.MaPhieuKham,
                                 TenThuoc = hd.PHIEUKHAMBENH.THUOC.TenThuoc,
                                 GiaThuoc = hd.PHIEUKHAMBENH.THUOC.GiaThuoc,
                                 SoLuongDung = hd.PHIEUKHAMBENH.SoLuongDung,
                                 TienKham = hd.PHIEUKHAMBENH.HOADON.TienKham,
                                 TienThuoc = hd.PHIEUKHAMBENH.HOADON.TienThuoc
                             };
                QLBENHNHAN bn = dbe_search.QLBENHNHANs.Where(h => h.HoTen == txbsearch.Text).FirstOrDefault();
                if (bn == null)
                {
                    MessageBox.Show("Hóa Đơn không tồn tại !");
                    return;
                }
                dgvHoaDon.DataSource = listHD.ToList();               
                BindingCheck();
            }
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            LoadHD();
        }
    }
}
