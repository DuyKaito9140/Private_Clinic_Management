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
    public partial class NhapChiTietHoaDon : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public NhapChiTietHoaDon()
        {
            InitializeComponent();
        }
        public void LoadHD()
        {
            var listHD = from hd in dbe.HOADONs
                         select new
                         {
                             MaHD = hd.MaHD,
                             MaBN = hd.MaBN,
                             TienKham = hd.TienKham,
                             TienThuoc = hd.TienThuoc
                         };
            dgvNhapHoaDon.DataSource = listHD.ToList();

            //DataBindings thông tin bệnh nhân
            //tbMaHoaDon.DataBindings.Clear();
            //tbMaHoaDon.DataBindings.Add(new Binding("Text", dgvNhapHoaDon.DataSource, "MaHD"));
            //tbMaBN.DataBindings.Clear();
            //tbMaBN.DataBindings.Add(new Binding("Text", dgvNhapHoaDon.DataSource, "MaBN"));
            //tbTienKham.DataBindings.Clear();
            //tbTienKham.DataBindings.Add(new Binding("Text", dgvNhapHoaDon.DataSource, "TienKham"));
            //tbTienThuoc.DataBindings.Clear();
            //tbTienThuoc.DataBindings.Add(new Binding("Text", dgvNhapHoaDon.DataSource, "TienThuoc"));
        }

        private void NhapChiTietHoaDon_Load(object sender, EventArgs e)
        {
            tbMaBN.Text = Content.HMaBN;
            tbHoTenBN.Text = Content.HHoTen;
            tbTenthuoc.Text = Content.HTenThuoc;
            tbGiaThuoc.Text = Content.HGiaThuoc;
            tbSoLuong.Text = Content.HLuongDung;
            int giathuoc = int.Parse(tbGiaThuoc.Text);
            int soluong = int.Parse(tbSoLuong.Text);
            int sum = giathuoc * soluong;
            tbTienThuoc.Text = sum.ToString();
            LoadHD();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_add_hd = new DBE_QLPMT();
            string mahd = tbMaHoaDon.Text;
            string mabn = tbMaBN.Text;
            string tienkham = tbTienKham.Text;
            string tienthuoc = tbTienThuoc.Text;
            HOADON hd = dbe_add_hd.HOADONs.Where(mah => mah.MaHD == mahd).SingleOrDefault();
            if (hd != null)
            {
                MessageBox.Show("Mã Hóa Đơn đã tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Mã Hóa Đơn không được để trống !");
                return;
            }
            else if (mahd.Length != 10 || mahd[0] != 'H' || mahd[1] != 'D')
            {
                MessageBox.Show("Mã Hóa Đơn sai, mã hóa đơn bao gồm 10 kí tự !\n2 ký tự đầu là HD.\n8 ký tự sau là số.");
                return;
            }
            else
            {
                hd = new HOADON();
                hd.MaHD = mahd;
                hd.MaBN = mabn;
                hd.TienKham = int.Parse(tienkham);
                hd.TienThuoc = int.Parse(tienthuoc);
                dbe_add_hd.HOADONs.Add(hd);
                dbe_add_hd.SaveChanges();
                Content._MaHD = tbMaHoaDon.Text;
                Content._MaBN = tbMaBN.Text;
                Content._TienKham = tbTienKham.Text;
                Content._TienThuoc = tbTienThuoc.Text;
                LoadHD();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
