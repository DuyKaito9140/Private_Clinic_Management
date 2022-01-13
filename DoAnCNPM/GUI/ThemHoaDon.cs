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
    public partial class ThemHoaDon : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public ThemHoaDon()
        {
            InitializeComponent();
            
        }
        public void LoadHD()
        {
            var listHD = from hd in dbe.QLBENHNHANs
                         select new
                         {
                             MaBN = hd.MaBN,
                             HoTen = hd.HoTen,
                             MaPhieuKham = hd.PHIEUKHAMBENH.MaPhieuKham,
                             LoaiBenh = hd.PHIEUKHAMBENH.LoaiBenh,
                             TenThuoc = hd.PHIEUKHAMBENH.THUOC.TenThuoc,
                             GiaThuoc = hd.PHIEUKHAMBENH.THUOC.GiaThuoc,
                             SoLuongDung = hd.PHIEUKHAMBENH.SoLuongDung,
                             MaHD = hd.PHIEUKHAMBENH.HOADON.MaHD,
                             TienKham = hd.PHIEUKHAMBENH.HOADON.TienKham,
                             TienThuoc = hd.PHIEUKHAMBENH.HOADON.TienThuoc
                         };
            dgvQLHoaDon.DataSource = listHD.ToList();

            //DataBindings thông tin bệnh nhân
            tbMaBN.DataBindings.Clear();
            tbMaBN.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "MaBN"));
            tbHoTenBN.DataBindings.Clear();
            tbHoTenBN.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "HoTen"));
            tbmaPhieu.DataBindings.Clear();
            tbmaPhieu.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "MaPhieuKham"));
            tbLoaiBenh.DataBindings.Clear();
            tbLoaiBenh.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "LoaiBenh"));
            tbTenthuoc.DataBindings.Clear();
            tbTenthuoc.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "Tenthuoc"));
            tbGiaThuoc.DataBindings.Clear();
            tbGiaThuoc.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "GiaThuoc"));
            tbSoLuong.DataBindings.Clear();
            tbSoLuong.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "SoLuongDung"));
            tbMaHoaDon.DataBindings.Clear();
            tbMaHoaDon.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "MaHD"));
            tbTienKham.DataBindings.Clear();
            tbTienKham.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "TienKham"));
            tbTienThuoc.DataBindings.Clear();
            tbTienThuoc.DataBindings.Add(new Binding("Text", dgvQLHoaDon.DataSource, "TienThuoc"));
        }
        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void btnNhapHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = tbMaHoaDon.Text;
            string maphieu = tbmaPhieu.Text;
            if(maphieu == "")
            {
                MessageBox.Show("Bệnh nhân chưa được nhập phiếu khám !");
            }
            else if(mahd != "")
            {
                MessageBox.Show("Bệnh nhân đã nhập hóa đơn !");
            }
            else
            {
                Content.HMaBN = tbMaBN.Text;
                Content.HHoTen = tbHoTenBN.Text;
                Content.HTenThuoc = tbTenthuoc.Text;
                Content.HGiaThuoc = tbGiaThuoc.Text;
                Content.HLuongDung = tbSoLuong.Text;
                NhapChiTietHoaDon f4 = new NhapChiTietHoaDon();
                f4.Show();
            }            
        }

        private void ThemHoaDon_Activated(object sender, EventArgs e)
        {
            //tbMaBN.Text = Content._MaBN;
            tbMaHoaDon.Text = Content._MaHD;
            tbTienKham.Text = Content._TienKham;
            tbTienThuoc.Text = Content._TienThuoc;
            if(tbTienKham.Text != "" || tbTienThuoc.Text != "")
            {
                int tienkham = int.Parse(tbTienKham.Text);
                int tienthuoc = int.Parse(tbTienThuoc.Text);
                int sum = tienkham + tienthuoc;
                tbSumMoney.Text = sum.ToString();
            }           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_luu_phieu = new DBE_QLPMT();
            string mahd = tbMaHoaDon.Text;
            string maphieu = tbmaPhieu.Text;
            string loaibenh = tbLoaiBenh.Text;
            PHIEUKHAMBENH phieu = dbe_luu_phieu.PHIEUKHAMBENHs.Where(map => map.MaPhieuKham == maphieu).SingleOrDefault();
            if (phieu != null)
            {
                phieu.MaPhieuKham = maphieu;
                phieu.LoaiBenh = loaibenh;
                phieu.MaHD = mahd;                
                dbe_luu_phieu.SaveChanges();
                LoadHD();
                MessageBox.Show("Hoàn tất nhập hóa đơn cho bệnh nhân !");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
