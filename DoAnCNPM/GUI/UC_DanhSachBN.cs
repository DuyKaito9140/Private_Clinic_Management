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
    public partial class UC_DanhSachBN : UserControl
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        UC_PhieuKham f1;
        public UC_DanhSachBN()
        {
            InitializeComponent();
            LoadBN();
        }
        public UC_DanhSachBN(UC_PhieuKham f1)
        {
            InitializeComponent();
            this.f1 = f1;
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
                             MaPhieuKham = bn.MaPhieuKham
                         };
            dgvDSBenhNhan.DataSource = listBN.ToList();

            //DataBindings thông tin bệnh nhân
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
            tbMaPheuKham.DataBindings.Clear();
            tbMaPheuKham.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "MaPhieuKham"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_add_bn = new DBE_QLPMT();
            string mabn = tbMaBN.Text;
            string tenbn = tbHoTenBN.Text;
            string gioitinh = tbCbGioiTinh.Text;
            string sodt = tbSdt.Text;
            string diachi = tbDiaChi.Text;
            QLBENHNHAN bn = dbe_add_bn.QLBENHNHANs.Where(mab => mab.MaBN == mabn).SingleOrDefault();
            if (bn != null)
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(mabn))
            {
                MessageBox.Show("Mã bệnh nhân không được để trống !");
                return;
            }
            else if (mabn.Length != 10 || mabn[0] != 'B' || mabn[1] != 'N')
            {
                MessageBox.Show("Mã bệnh nhân sai, mã bệnh nhân bao gồm 10 kí tự !\n2 ký tự đầu là BN.\n8 ký tự sau là số.");
                return;
            }
            else if (string.IsNullOrEmpty(tenbn))
            {
                MessageBox.Show("Tên bệnh nhân không được để trống !");
                return;
            }
            else if (string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Yêu cầu chọn giới tính !");
                return;
            }
            else if (string.IsNullOrEmpty(sodt) || sodt.Length != 10 || sodt[0].ToString()=="0")
            {
                MessageBox.Show("Kiểm tra lại số điện thoại ! \nBạn chưa nhập hoặc nhập sai số điện thoại.");
                return;
            }
            else if (string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Hãy nhập địa chỉ !");
                return;
            }
            else
            {
                bn = new QLBENHNHAN();
                bn.MaBN = mabn;
                bn.HoTen = tenbn;
                bn.GioiTinh = gioitinh;
                bn.NgaySinh = tbdateNgaySinh.Value;
                bn.Sdt = sodt;
                bn.DiaChi = diachi;
                dbe_add_bn.QLBENHNHANs.Add(bn);
                dbe_add_bn.SaveChanges();
                LoadBN();
                MessageBox.Show("Thêm mới bệnh nhân thành công !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maph = tbMaPheuKham.Text;
            if(maph == "")
            {
                DBE_QLPMT dbe_remove_bn = new DBE_QLPMT();
                string mabn = tbMaBN.Text;
                string tenbn = tbHoTenBN.Text;
                string gioitinh = tbCbGioiTinh.Text;
                string sodt = tbSdt.Text;
                string diachi = tbDiaChi.Text;
                QLBENHNHAN bn = dbe_remove_bn.QLBENHNHANs.Where(mab => mab.MaBN == mabn).SingleOrDefault();
                if (bn == null)
                {
                    MessageBox.Show("Mã bệnh nhân không tồn tại !");
                    return;
                }
                else if (string.IsNullOrEmpty(mabn))
                {
                    MessageBox.Show("Chọn bệnh nhân cần xóa !");
                    return;
                }
                else
                {
                    DialogResult dr;
                    dr = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        dbe_remove_bn.QLBENHNHANs.Remove(bn);
                        dbe_remove_bn.SaveChanges();
                        LoadBN();
                        MessageBox.Show("Xóa bệnh nhân thành công !");
                    }
                }
            }
            else
                MessageBox.Show("Bệnh nhân đã được nhập lịch khám, không thể xóa !");

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_edit_bn = new DBE_QLPMT();
            string mabn = tbMaBN.Text;
            string tenbn = tbHoTenBN.Text;
            string gioitinh = tbCbGioiTinh.Text;
            string sodt = tbSdt.Text;
            string diachi = tbDiaChi.Text;
            QLBENHNHAN bn = dbe_edit_bn.QLBENHNHANs.Where(mab => mab.MaBN == mabn).SingleOrDefault();
            if (bn == null)
            {
                MessageBox.Show("Mã bệnh nhân không tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(mabn))
            {
                MessageBox.Show("Mã bệnh nhân cần sửa không được trống");
                return;
            }
            else
            {
                bn.MaBN = mabn;
                bn.HoTen = tenbn;
                bn.GioiTinh = gioitinh;
                bn.NgaySinh = tbdateNgaySinh.Value;
                bn.Sdt = sodt;
                bn.DiaChi = diachi;
                dbe_edit_bn.SaveChanges();
                LoadBN();
                MessageBox.Show("Cập nhật thông tin bệnh nhân thành công !");
            }
        }

        private void btnNhapPhieu_Click(object sender, EventArgs e)
        {
            QLPhieuKham f3 = new QLPhieuKham();
            f3.Show();
        }
    }
}
