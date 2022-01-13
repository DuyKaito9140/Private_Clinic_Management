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
    public partial class NhapLichKham : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public NhapLichKham()
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
        private void btnChonBN_Click(object sender, EventArgs e)
        {
            BenhNhan f1 = new BenhNhan();
            f1.Show();
        }

        private void NhapLichKham_Load(object sender, EventArgs e)
        {
            
        }

        private void NhapLichKham_Activated(object sender, EventArgs e)
        {
            if(Content.Ltrangthai == "ChonXong")
            {
                tbmabn.Text = Content.LMaBN;
                tbhoten.Text = Content.LHoTenBN;
                tbsdt.Text = Content.LSdt;
                tbMaLich.Text = "";
                tbGioDat.Text = "";
                Content.Ltrangthai = "";
            }
            else
            {
                LoadLichKham();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_luu_hoadon = new DBE_QLPMT();
            string malich = tbMaLich.Text;
            string giodat = tbGioDat.Text;
            string mabn = tbmabn.Text;
            if(malich == "")
            {
                MessageBox.Show("Hãy nhập mã lịch !");
            }
            if (malich.Length != 10 || malich[0] != 'L' || malich[1] != 'K')
            {
                MessageBox.Show("Mã Lịch Khám sai, mã lịch khám bao gồm 10 kí tự !\n2 ký tự đầu là LK.\n8 ký tự sau là số.");
                return;
            }
            QLLich lich = dbe_luu_hoadon.QLLiches.Where(map => map.MaLich == malich).SingleOrDefault();
            if (lich == null)
            {
                lich = new QLLich();
                lich.MaLich = malich;
                lich.GioDatLich = giodat;
                lich.NgayDatLich = tbNgayDat.Value;
                lich.MaBN = tbmabn.Text;
                dbe_luu_hoadon.QLLiches.Add(lich);
                dbe_luu_hoadon.SaveChanges();
                LoadLichKham();
                MessageBox.Show("Lịch khám đặt của bệnh nhân đã được lưu !");
            }
            else if (malich.Length != 10 || malich[0] != 'L' || malich[1] != 'K')
            {
                MessageBox.Show("Mã Lịch Khám sai, mã lịch khám bao gồm 10 kí tự !\n2 ký tự đầu là LK.\n8 ký tự sau là số.");
                return;
            }
            else
            {
                MessageBox.Show("Bệnh nhân đã được nhập lịch khám trước đó !");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_remove_lich = new DBE_QLPMT();
            string malich = tbMaLich.Text;
            string giodat = tbGioDat.Text;
            string mabn = tbmabn.Text;
            QLLich lich = dbe_remove_lich.QLLiches.Where(mab => mab.MaLich == malich).SingleOrDefault();
            if (lich != null)
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có chắc muốn xóa lịch này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dbe_remove_lich.QLLiches.Remove(lich);
                    dbe_remove_lich.SaveChanges();
                    LoadLichKham();
                    MessageBox.Show("Xóa lịch thành công !");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_edit_lich = new DBE_QLPMT();
            string malich = tbMaLich.Text;
            string giodat = tbGioDat.Text;
            string mabn = tbmabn.Text;
            QLLich lich = dbe_edit_lich.QLLiches.Where(mab => mab.MaLich == malich).SingleOrDefault();
            if (lich != null)
            {
                lich.MaLich = malich;
                lich.GioDatLich = giodat;
                lich.NgayDatLich = tbNgayDat.Value;
                lich.MaBN = tbmabn.Text;
                dbe_edit_lich.SaveChanges();
                LoadLichKham();
                MessageBox.Show("Cập nhật lịch khám thành công !");
            }
            else
            {
                MessageBox.Show("Mã lịch không thể sửa !");
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
