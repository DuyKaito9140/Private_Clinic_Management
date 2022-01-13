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
    public partial class NhapChiTietPhieu : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        UC_DanhSachBN f1;
        ChonThuoc f2;
        QLPhieuKham f3;
        public NhapChiTietPhieu()
        {
            InitializeComponent();
            LoadPhieuKham();
        }
        public NhapChiTietPhieu(QLPhieuKham f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }
        public NhapChiTietPhieu(ChonThuoc f2)
        {
            InitializeComponent();
            this.f2 = f2;
        }
        private void btnChonThuoc_Click(object sender, EventArgs e)
        {
            ChonThuoc ct = new ChonThuoc(this);
            ct.Show();
            this.Hide();
        }
        public void LoadPhieuKham()
        {
            var listPhieu = from phieu in dbe.PHIEUKHAMBENHs
                            select new
                            {
                                MaPhieuKham = phieu.MaPhieuKham,
                                TrieuChung = phieu.TrieuChung,
                                LoaiBenh = phieu.LoaiBenh,
                                MaThuoc = phieu.MaThuoc,
                                SoLuongDung = phieu.SoLuongDung,
                                NgayKham = phieu.NgayKham,
                                GioKham = phieu.GioKham
                            };
            dgvPhieuKham.DataSource = listPhieu.ToList();
            //DataBindings thông tin bệnh nhân
            tbMaPhieu.DataBindings.Clear();
            tbMaPhieu.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "MaPhieuKham"));
            tbTrieuChung.DataBindings.Clear();
            tbTrieuChung.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "TrieuChung"));
            tbLoaiBenh.DataBindings.Clear();
            tbLoaiBenh.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "LoaiBenh"));
            tbMathuoc.DataBindings.Clear();
            tbMathuoc.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "MaThuoc"));
            tbSoLuong.DataBindings.Clear();
            tbSoLuong.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "SoLuongDung"));
            tbNgayKham.DataBindings.Clear();
            tbNgayKham.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "NgayKham"));
            tbGioKham.DataBindings.Clear();
            tbGioKham.DataBindings.Add(new Binding("Text", dgvPhieuKham.DataSource, "GioKham"));

        }
        private void NhapChiTietPhieu_Load(object sender, EventArgs e)
        {
            LoadPhieuKham();
            tbMaBN.Text = Content.CMaBN;
            tbHoTenBN.Text = Content.CHoTen;
            tbTrieuChung.Text = Content.CTrieuChung;
            tbLoaiBenh.Text = Content.CLoaiBenh;
            tbNgayKham.Text = Content.CNgayKham;
            tbMaPhieu.Text = Content.CMaPhieu;
            tbSoLuong.Text = Content.Csoluongdung;
            tbGioKham.Text = Content.CGioKham;
            tbMathuoc.Text = Content.CMaThuoc;
        }

        private void btnChonThuoc_Click_1(object sender, EventArgs e)
        {
            Content.CMaBN = tbMaBN.Text;
            Content.CHoTen = tbHoTenBN.Text;
            Content.CMaPhieu = tbMaPhieu.Text;
            Content.Csoluongdung = tbSoLuong.Text;
            Content.CTrieuChung = tbTrieuChung.Text;
            Content.CLoaiBenh = tbLoaiBenh.Text;
            Content.CNgayKham = tbNgayKham.Text;
            Content.CGioKham = tbGioKham.Text;
            ChonThuoc ct = new ChonThuoc(this);
            ct.Show();
            this.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_add_phieu = new DBE_QLPMT();
            string maphieu = tbMaPhieu.Text;
            string mabn = tbMaBN.Text;
            string tenbn = tbHoTenBN.Text;
            string trieuchung = tbTrieuChung.Text;
            string loaibenh = tbLoaiBenh.Text;
            string giokham = tbGioKham.Text;
            string soluongdung = tbSoLuong.Text;
            string mathuoc = tbMathuoc.Text;

            PHIEUKHAMBENH phieu = dbe_add_phieu.PHIEUKHAMBENHs.Where(map => map.MaPhieuKham == maphieu).SingleOrDefault();
            if (phieu != null)
            {
                MessageBox.Show("Mã phiếu khám đã tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(maphieu))
            {
                MessageBox.Show("Mã phiếu khám không được để trống !");
                return;
            }
            else if (maphieu.Length != 10 || maphieu[0] != 'P' || maphieu[1] != 'K')
            {
                MessageBox.Show("Mã Phiếu Khám sai, mã phiếu khám bao gồm 10 kí tự !\n2 ký tự đầu là PK.\n8 ký tự sau là số.");
                return;
            }
            else if (string.IsNullOrEmpty(trieuchung))
            {
                MessageBox.Show("Hãy nhập triệu chứng của bệnh nhân !");
                return;
            }
            else if (string.IsNullOrEmpty(loaibenh))
            {
                MessageBox.Show("Hãy xác định và nhập loại bệnh của bệnh nhân !");
                return;
            }
            else if (string.IsNullOrEmpty(soluongdung))
            {
                MessageBox.Show("Nhập số lượng thuốc cần dùng !");
                return;
            }
            else if (string.IsNullOrEmpty(mathuoc))
            {
                MessageBox.Show("Hãy chọn thuốc cho bệnh nhân !");
                return;
            }
            else if (int.Parse(soluongdung) > int.Parse(Content.CSoLuongConTrongKho))
            {
                MessageBox.Show("Hãy nhập lại số lượng thuốc! \n" + Content.CMaThuoc + " còn lại trong kho là " + Content.CSoLuongConTrongKho);
                return;
            }
            else
            {
                phieu = new PHIEUKHAMBENH();
                phieu.MaPhieuKham = maphieu;
                phieu.TrieuChung = trieuchung;
                phieu.LoaiBenh = loaibenh;
                phieu.MaThuoc = mathuoc;
                phieu.SoLuongDung = soluongdung;
                phieu.NgayKham = tbNgayKham.Value;
                phieu.GioKham = giokham;
                dbe_add_phieu.PHIEUKHAMBENHs.Add(phieu);
                dbe_add_phieu.SaveChanges();
                Content.CMaBN = tbMaBN.Text;
                Content.CHoTen = tbHoTenBN.Text;
                Content.CMaPhieu = tbMaPhieu.Text;
                Content.Csoluongdung = tbSoLuong.Text;
                Content.CTrieuChung = tbTrieuChung.Text;
                Content.CLoaiBenh = tbLoaiBenh.Text;
                Content.CNgayKham = tbNgayKham.Text;
                Content.CGioKham = tbGioKham.Text;
                Content.trangthai = "NhapXong";
                LoadPhieuKham();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
