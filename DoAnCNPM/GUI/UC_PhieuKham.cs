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
    public partial class UC_PhieuKham : UserControl
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        ChonThuoc f1;
        UC_DanhSachBN f2;
        QLPhieuKham f3;
        public UC_PhieuKham()
        {
            InitializeComponent();
            LoadPhieuKham();
        }
        public UC_PhieuKham(ChonThuoc f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public UC_PhieuKham(UC_DanhSachBN f2)
        {
            InitializeComponent();
            this.f2 = f2;
        }
        public void LoadPhieuKham()
        {
            var listPhieu = from phieu in dbe.QLBENHNHANs
                            select new
                            {
                                MaPhieuKham = phieu.MaPhieuKham,
                                MaBN = phieu.MaBN,
                                HoTen = phieu.HoTen,
                                TrieuChung = phieu.PHIEUKHAMBENH.TrieuChung,
                                LoaiBenh = phieu.PHIEUKHAMBENH.LoaiBenh,
                                TenThuoc = phieu.PHIEUKHAMBENH.THUOC.TenThuoc,
                                SoLuongDung = phieu.PHIEUKHAMBENH.SoLuongDung,
                                CachDung = phieu.PHIEUKHAMBENH.THUOC.CachDung,
                                NgayKham = phieu.PHIEUKHAMBENH.NgayKham,
                                GioKham = phieu.PHIEUKHAMBENH.GioKham
                            };
            dgvPhieuKham.DataSource = listPhieu.ToList();
            //DataBindings thông tin bệnh nhân
            BindingLoad();
        }
        private void UC_PhieuKham_Load(object sender, EventArgs e)
        {
           
        }

        public void BindingLoad()
        {
            tbMaPhieu.DataBindings.Clear();
            tbMaPhieu.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "MaPhieuKham"));
            tbMaBN.DataBindings.Clear();
            tbMaBN.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "MaBN"));
            tbHoTenBN.DataBindings.Clear();
            tbHoTenBN.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "HoTen"));
            tbTrieuChung.DataBindings.Clear();
            tbTrieuChung.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "TrieuChung"));
            tbLoaiBenh.DataBindings.Clear();
            tbLoaiBenh.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "LoaiBenh"));
            tbThuoc.DataBindings.Clear();
            tbThuoc.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "TenThuoc"));
            tbSoLuong.DataBindings.Clear();
            tbSoLuong.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "SoLuongDung"));
            tbCachDung.DataBindings.Clear();
            tbCachDung.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "CachDung"));
            tbNgayKham.DataBindings.Clear();
            tbNgayKham.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "NgayKham"));
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_search = new DBE_QLPMT();
            if (txbsearch.Text == "all" || txbsearch.Text == "AL" || txbsearch.Text == "tat ca" || txbsearch.Text == "tất cả" || txbsearch.Text == "TAT CA" || txbsearch.Text == "TẤT CẢ" || txbsearch.Text == "tatca" || txbsearch.Text == "TATCA" || txbsearch.Text == "tc" || txbsearch.Text == "TC")
            {
                LoadPhieuKham();
            }
            else if (txbsearch.Text == "Nam" || txbsearch.Text == "Nữ")
            {
                var timgioitinh = from ten in dbe_search.QLBENHNHANs
                             where ten.GioiTinh == txbsearch.Text
                             select new
                             {
                                 MaPhieuKham = ten.MaPhieuKham,
                                 MaBN = ten.MaBN,
                                 HoTen = ten.HoTen,
                                 TrieuChung = ten.PHIEUKHAMBENH.TrieuChung,
                                 LoaiBenh = ten.PHIEUKHAMBENH.LoaiBenh,
                                 TenThuoc = ten.PHIEUKHAMBENH.THUOC.TenThuoc,
                                 SoLuongDung = ten.PHIEUKHAMBENH.SoLuongDung,
                                 CachDung = ten.PHIEUKHAMBENH.THUOC.CachDung,
                                 NgayKham = ten.PHIEUKHAMBENH.NgayKham,
                                 GioKham = ten.PHIEUKHAMBENH.GioKham
                             };
                QLBENHNHAN hs = dbe_search.QLBENHNHANs.Where(h => h.GioiTinh == txbsearch.Text).FirstOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Phiếu Khám không tồn tại");
                    return;
                }
                dgvPhieuKham.DataSource = timgioitinh.ToList();
                BindingLoad();
            }
            else if (txbsearch.Text[0] == 'P' && txbsearch.Text[1] == 'K')
            {
                var timmaphieu = from ten in dbe_search.QLBENHNHANs
                                  where ten.MaPhieuKham == txbsearch.Text
                                  select new
                                  {
                                      MaPhieuKham = ten.MaPhieuKham,
                                      MaBN = ten.MaBN,
                                      HoTen = ten.HoTen,
                                      TrieuChung = ten.PHIEUKHAMBENH.TrieuChung,
                                      LoaiBenh = ten.PHIEUKHAMBENH.LoaiBenh,
                                      TenThuoc = ten.PHIEUKHAMBENH.THUOC.TenThuoc,
                                      SoLuongDung = ten.PHIEUKHAMBENH.SoLuongDung,
                                      CachDung = ten.PHIEUKHAMBENH.THUOC.CachDung,
                                      NgayKham = ten.PHIEUKHAMBENH.NgayKham,
                                      GioKham = ten.PHIEUKHAMBENH.GioKham
                                  };
                QLBENHNHAN hs = dbe_search.QLBENHNHANs.Where(h => h.MaPhieuKham == txbsearch.Text).SingleOrDefault();
                if (hs == null)
                {
                    MessageBox.Show("Phiếu Khám không tồn tại");
                    return;
                }
                dgvPhieuKham.DataSource = timmaphieu.ToList();
                BindingLoad();
            }
            else
            {
                var timten = from ten in dbe_search.QLBENHNHANs
                             where ten.HoTen == txbsearch.Text
                             select new
                             {
                                 MaPhieuKham = ten.MaPhieuKham,
                                 MaBN = ten.MaBN,
                                 HoTen = ten.HoTen,
                                 TrieuChung = ten.PHIEUKHAMBENH.TrieuChung,
                                 LoaiBenh = ten.PHIEUKHAMBENH.LoaiBenh,
                                 TenThuoc = ten.PHIEUKHAMBENH.THUOC.TenThuoc,
                                 SoLuongDung = ten.PHIEUKHAMBENH.SoLuongDung,
                                 CachDung = ten.PHIEUKHAMBENH.THUOC.CachDung,
                                 NgayKham = ten.PHIEUKHAMBENH.NgayKham,
                                 GioKham = ten.PHIEUKHAMBENH.GioKham
                             };
                QLBENHNHAN bn = dbe_search.QLBENHNHANs.Where(h => h.HoTen == txbsearch.Text).FirstOrDefault();
                if (bn == null)
                {
                    MessageBox.Show("Phiếu Khám không tồn tại !");
                    return;
                }
                dgvPhieuKham.DataSource = timten.ToList();
                BindingLoad();
            }
        }
        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            LoadPhieuKham();
        }
    }
}
