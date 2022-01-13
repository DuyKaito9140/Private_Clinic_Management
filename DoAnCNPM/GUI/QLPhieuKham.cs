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
    public partial class QLPhieuKham : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        UC_DanhSachBN f1;
        ChonThuoc f2;
        public QLPhieuKham()
        {
            InitializeComponent();
        }
        public QLPhieuKham(UC_DanhSachBN f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public QLPhieuKham(ChonThuoc f2)
        {
            InitializeComponent();
            this.f2 = f2;
        }
        public void LoadPhieuKham()
        {
            var listPhieu = from phieu in dbe.QLBENHNHANs
                            select new
                            {
                                MaBN = phieu.MaBN,
                                HoTen = phieu.HoTen,
                                MaPhieuKham = phieu.PHIEUKHAMBENH.MaPhieuKham,
                                TrieuChung = phieu.PHIEUKHAMBENH.TrieuChung,
                                LoaiBenh = phieu.PHIEUKHAMBENH.LoaiBenh,
                                TenThuoc = phieu.PHIEUKHAMBENH.THUOC.TenThuoc,
                                SoLuongDung = phieu.PHIEUKHAMBENH.SoLuongDung,
                                CachDung = phieu.PHIEUKHAMBENH.THUOC.CachDung,
                                NgayKham = phieu.PHIEUKHAMBENH.NgayKham,
                                GioKham = phieu.PHIEUKHAMBENH.GioKham,
                                MaHD = phieu.PHIEUKHAMBENH.MaHD
                            };
            dgvPhieuKham.DataSource = listPhieu.ToList();
            //DataBindings thông tin bệnh nhân
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
            tbMathuoc.DataBindings.Clear();
            tbMathuoc.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "TenThuoc"));
            tbSoLuong.DataBindings.Clear();
            tbSoLuong.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "SoLuongDung"));
            tbCachDung.DataBindings.Clear();
            tbCachDung.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "CachDung"));
        }

        private void QLPhieuKham_Load(object sender, EventArgs e)
        {
            tbMaBN.Text = Content.CMaBN;
            tbHoTenBN.Text = Content.CHoTen;
            tbMathuoc.Text = Content.CMaThuoc;
            tbCachDung.Text = Content.CCachDung;
            LoadPhieuKham();
        }

        private void btnChonThuoc_Click(object sender, EventArgs e)
        {
            ChonThuoc ct = new ChonThuoc(this); 
            ct.Show();
            this.Hide();
        }

        private void QLPhieuKham_FormClosed(object sender, FormClosedEventArgs e)
        {

            Content.CMaBN = "";
            Content.CHoTen = "";
            Content.CMaThuoc= "";
            Content.CSoLuongConTrongKho = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_luu_phieu = new DBE_QLPMT();
            string maphieu = tbMaPhieu.Text;
            string mabn = tbMaBN.Text;
            string tenbn = tbHoTenBN.Text;
            string trieuchung = tbTrieuChung.Text;
            string loaibenh = tbLoaiBenh.Text;
            string soluongdung = tbSoLuong.Text;
            string mathuoc = tbMathuoc.Text;
            QLBENHNHAN phieu = dbe_luu_phieu.QLBENHNHANs.Where(map => map.MaBN == mabn).SingleOrDefault();
            if (phieu != null)
            {
                phieu.MaBN = mabn;
                phieu.HoTen = tenbn;
                phieu.MaPhieuKham = maphieu;
                dbe_luu_phieu.SaveChanges();
                LoadPhieuKham();
                MessageBox.Show("Hoàn tất nhập phiếu khám cho bệnh nhân !");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            bool status = false;
            int count = dgvPhieuKham.Rows.Count;
            for (int i = 0; i < count; i++) 
            {
                if(dgvPhieuKham.Rows[i].Cells[2].Value.ToString() != "" && dgvPhieuKham.Rows[i].Cells[10].Value == null)
                {
                    MessageBox.Show("Hãy nhập hóa đơn cho bệnh nhân vừa nhập phiếu khám !");
                    status = true;
                }
            }
            if(!status)
                this.Hide();
        }

        private void btnPhieuKham_Click(object sender, EventArgs e)
        {
            string maphieu = tbMaPhieu.Text;
            if (maphieu == "")
            {
                Content.CMaBN = tbMaBN.Text;
                Content.CHoTen = tbHoTenBN.Text;
                Content.CCachDung = tbCachDung.Text;
                Content.CLoaiBenh = tbLoaiBenh.Text;
                Content.CMaPhieu = tbMaPhieu.Text;
                Content.CMaThuoc = tbMathuoc.Text;
                Content.Csoluongdung = tbSoLuong.Text;
                Content.CTrieuChung = tbTrieuChung.Text;
                NhapChiTietPhieu f3 = new NhapChiTietPhieu(this);
                f3.Show();
            }
            else
                MessageBox.Show("Bệnh nhân này đã có phiếu khám bệnh trước đó.\nChọn Sửa Phiếu Khám nếu muốn sửa !");
        }

        private void QLPhieuKham_Activated(object sender, EventArgs e)
        {
            if(Content.trangthai == "NhapXong")
            {
                tbMaBN.Text = Content.CMaBN;
                tbHoTenBN.Text = Content.CHoTen;
                tbTrieuChung.Text = Content.CTrieuChung;
                tbLoaiBenh.Text = Content.CLoaiBenh;
                tbMaPhieu.Text = Content.CMaPhieu;
                tbCachDung.Text = Content.CCachDung;
                tbSoLuong.Text = Content.Csoluongdung;
                tbMathuoc.Text = Content.CMaThuoc;
                Content.trangthai = "";
                Content.CMaBN = "";
                Content.CHoTen = "";
                Content.CCachDung = "";
                Content.CLoaiBenh = "";
                Content.CMaPhieu = "";
                Content.CMaThuoc = "";
                Content.Csoluongdung = "";
                Content.CTrieuChung = "";
            }
            else
            {
                LoadPhieuKham();
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Content.CMaBN = tbMaBN.Text;
            Content.CHoTen = tbHoTenBN.Text;
            Content.CCachDung = tbCachDung.Text;
            Content.CLoaiBenh = tbLoaiBenh.Text;
            Content.CMaPhieu = tbMaPhieu.Text;
            Content.CMaThuoc = tbMathuoc.Text;
            Content.Csoluongdung = tbSoLuong.Text;
            Content.CTrieuChung = tbTrieuChung.Text;
            ThemHoaDon f3 = new ThemHoaDon();
            f3.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPhieuKham();
        }
    }
}
