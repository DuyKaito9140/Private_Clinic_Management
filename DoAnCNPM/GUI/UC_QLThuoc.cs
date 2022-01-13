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
    public partial class UC_QLThuoc : UserControl
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        ChonThuoc f1;
        public UC_QLThuoc()
        {
            InitializeComponent();
            LoadThuoc();
        }
        public UC_QLThuoc(ChonThuoc f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public void LoadThuoc()
        {
            var listThuoc = from thuoc in dbe.THUOCs 
                         select new
                         {
                             MaThuoc = thuoc.MaThuoc,
                             TenThuoc = thuoc.TenThuoc,
                             HanSuDung = thuoc.HanSuDung,
                             DonVi = thuoc.DonVi,
                             GiaThuoc = thuoc.GiaThuoc,                            
                             SoLuongTrongKho = thuoc.SoLuongTrongKho,
                             CachDung = thuoc.CachDung
                         };
            dgvQLThuoc.DataSource = listThuoc.ToList();

            //DataBindings thông tin thuốc
            CkeckBinding();
        }

        public void CkeckBinding()
        {
            tbMaThuoc.DataBindings.Clear();
            tbMaThuoc.DataBindings.Add(new Binding("Text", dgvQLThuoc.DataSource, "MaThuoc"));
            tbTenThuoc.DataBindings.Clear();
            tbTenThuoc.DataBindings.Add(new Binding("Text", dgvQLThuoc.DataSource, "TenThuoc"));
            tbCbDonVi.DataBindings.Clear();
            tbCbDonVi.DataBindings.Add(new Binding("Text", dgvQLThuoc.DataSource, "DonVi"));
            tbGiaThuoc.DataBindings.Clear();
            tbGiaThuoc.DataBindings.Add(new Binding("Text", dgvQLThuoc.DataSource, "GiaThuoc"));
            tbdateHanDung.DataBindings.Clear();
            tbdateHanDung.DataBindings.Add(new Binding("Text", dgvQLThuoc.DataSource, "HanSuDung"));
            tbSoLuongTrongKho.DataBindings.Clear();
            tbSoLuongTrongKho.DataBindings.Add(new Binding("Text", dgvQLThuoc.DataSource, "SoLuongTrongKho"));
            tbCachDung.DataBindings.Clear();
            tbCachDung.DataBindings.Add(new Binding("Text", dgvQLThuoc.DataSource, "CachDung"));
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_add_thuoc = new DBE_QLPMT();
            string mathuoc = tbMaThuoc.Text;
            string tenthuoc = tbTenThuoc.Text;
            string donvi = tbCbDonVi.Text;
            string soluongtk = tbSoLuongTrongKho.Text;
            string cachdung = tbCachDung.Text;
            string giathuoc = tbGiaThuoc.Text;
            THUOC th = dbe_add_thuoc.THUOCs.Where(math => math.MaThuoc == mathuoc).SingleOrDefault();
            if (th != null)
            {
                MessageBox.Show("Mã thuốc đã tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(mathuoc))
            {
                MessageBox.Show("Mã thuốc không được để trống.\nYêu cầu nhập mã thuốc !");
                return;
            }
            else if (mathuoc.Length != 10 || mathuoc[0] != 'M' || mathuoc[1] != 'T')
            {
                MessageBox.Show("Mã thuốc sai, mã thuốc bao gồm 10 kí tự !\n2 ký tự đầu là MT.\n8 ký tự sau là số.");
                return;
            }
            else if (string.IsNullOrEmpty(tenthuoc))
            {
                MessageBox.Show("Tên thuốc không được để trống.\nYêu cầu nhập tên thuốc !");
                return;
            }
            else if (string.IsNullOrEmpty(donvi))
            {
                MessageBox.Show("Hãy chọn đơn vị của thuốc !");
                return;
            }
            else if (string.IsNullOrEmpty(cachdung))
            {
                MessageBox.Show("Hãy nhập cách dùng thuốc !");
                return;
            }
            else if (string.IsNullOrEmpty(giathuoc))
            {
                MessageBox.Show("Hãy nhập giá thuốc !");
                return;
            }
            else if (string.IsNullOrEmpty(soluongtk))
            {
                MessageBox.Show("Hãy nhập số lượng có trong kho !");
                return;
            }
            else
            {
                th = new THUOC();
                th.MaThuoc = mathuoc;
                th.TenThuoc = tenthuoc;
                th.HanSuDung = tbdateHanDung.Value;
                th.DonVi = donvi;
                th.GiaThuoc = int.Parse(giathuoc);
                th.SoLuongTrongKho = int.Parse(soluongtk);
                th.CachDung = cachdung;
                dbe_add_thuoc.THUOCs.Add(th);
                dbe_add_thuoc.SaveChanges();
                LoadThuoc();
                MessageBox.Show("Thêm thuốc mới thành công !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_remove_thuoc = new DBE_QLPMT();
            string mathuoc = tbMaThuoc.Text;
            string tenthuoc = tbTenThuoc.Text;
            string donvi = tbCbDonVi.Text;
            string soluongtk = tbSoLuongTrongKho.Text;
            string cachdung = tbCachDung.Text;
            string giathuoc = tbGiaThuoc.Text;
            THUOC th = dbe_remove_thuoc.THUOCs.Where(math => math.MaThuoc == mathuoc).SingleOrDefault();
            if (th == null)
            {
                MessageBox.Show("Mã thuốc không tồn tại !");
                return;
            }
            else if (string.IsNullOrEmpty(mathuoc))
            {
                MessageBox.Show("Chọn thuốc cần xóa !");
                return;
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có chắc muốn xóa loại thuốc này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dbe_remove_thuoc.THUOCs.Remove(th);
                    dbe_remove_thuoc.SaveChanges();
                    LoadThuoc();
                    MessageBox.Show("Xóa thuốc thành công !");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_edit_thuoc = new DBE_QLPMT();
            string mathuoc = tbMaThuoc.Text;
            string tenthuoc = tbTenThuoc.Text;
            string donvi = tbCbDonVi.Text;
            string soluongtk = tbSoLuongTrongKho.Text;
            string cachdung = tbCachDung.Text;
            int giathuoc = int.Parse(tbGiaThuoc.Text);
            THUOC th = dbe_edit_thuoc.THUOCs.Where(math => math.MaThuoc == mathuoc).SingleOrDefault();
            if (th == null)
            {
                MessageBox.Show("Mã thuốc đã tồn tại");
                return;
            }
            else if (string.IsNullOrEmpty(mathuoc))
            {
                MessageBox.Show("Mã thuốc không được để trống.\nYêu cầu nhập mã thuốc !");
                return;
            }
            else if (mathuoc.Length != 10 || mathuoc[0] != 'M' || mathuoc[1] != 'T')
            {
                MessageBox.Show("Mã thuốc sai, mã thuốc bao gồm 10 kí tự !\n2 ký tự đầu là MT.\n8 ký tự sau là số.");
                return;
            }
            else if (string.IsNullOrEmpty(tenthuoc))
            {
                MessageBox.Show("Tên thuốc không được để trống.\nYêu cầu nhập tên thuốc !");
                return;
            }
            else if (string.IsNullOrEmpty(donvi))
            {
                MessageBox.Show("Hãy chọn đơn vị của thuốc !");
                return;
            }
            else if (string.IsNullOrEmpty(cachdung))
            {
                MessageBox.Show("Hãy nhập cách dùng thuốc !");
                return;
            }
            else if (string.IsNullOrEmpty(giathuoc.ToString()))
            {
                MessageBox.Show("Hãy nhập giá thuốc !");
                return;
            }
            else if (string.IsNullOrEmpty(soluongtk))
            {
                MessageBox.Show("Hãy nhập số lượng có trong kho !");
                return;
            }
            else
            {
                th.MaThuoc = mathuoc;
                th.TenThuoc = tenthuoc;
                th.HanSuDung = tbdateHanDung.Value;
                th.DonVi = donvi;
                th.GiaThuoc = giathuoc;
                th.SoLuongTrongKho = int.Parse(soluongtk);
                th.CachDung = cachdung;
                dbe_edit_thuoc.SaveChanges();
                LoadThuoc();
                MessageBox.Show("Cập nhật thông tin thuốc thành công !");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_search = new DBE_QLPMT();
            if (txbsearch.Text == "all" || txbsearch.Text == "AL" || txbsearch.Text == "tat ca" || txbsearch.Text == "tất cả" || txbsearch.Text == "TAT CA" || txbsearch.Text == "TẤT CẢ" || txbsearch.Text == "tatca" || txbsearch.Text == "TATCA" || txbsearch.Text == "tc" || txbsearch.Text == "TC")
            {
                LoadThuoc();
            }
            else if (txbsearch.Text == "M" || txbsearch.Text == "T")
            {
                var listThuoc = from thuoc in dbe.THUOCs
                                select new
                                {
                                    MaThuoc = thuoc.MaThuoc,
                                    TenThuoc = thuoc.TenThuoc,
                                    HanSuDung = thuoc.HanSuDung,
                                    DonVi = thuoc.DonVi,
                                    GiaThuoc = thuoc.GiaThuoc,                                    
                                    SoLuongTrongKho = thuoc.SoLuongTrongKho,
                                    CachDung = thuoc.CachDung
                                };

                THUOC th = dbe_search.THUOCs.Where(h => h.MaThuoc == txbsearch.Text).SingleOrDefault();
                if (th == null)
                {
                    MessageBox.Show("Không có thuốc này trong kho !");
                    return;
                }
                dgvQLThuoc.DataSource = listThuoc.ToList();
                CkeckBinding();
            }            
            else
            { 
                var timtenth = from thuoc in dbe_search.THUOCs
                             where thuoc.TenThuoc == txbsearch.Text
                             select new
                             {
                                 MaThuoc = thuoc.MaThuoc,
                                 TenThuoc = thuoc.TenThuoc,
                                 HanSuDung = thuoc.HanSuDung,
                                 DonVi = thuoc.DonVi,
                                 GiaThuoc = thuoc.GiaThuoc,                                
                                 SoLuongTrongKho = thuoc.SoLuongTrongKho,
                                 CachDung = thuoc.CachDung
                             };
                THUOC bn = dbe_search.THUOCs.Where(h => h.TenThuoc == txbsearch.Text).FirstOrDefault();
                if (bn == null)
                {
                    MessageBox.Show("Không có thuốc này trong kho !");
                    return;
                }
                dgvQLThuoc.DataSource = timtenth.ToList();
                CkeckBinding();
            }

        }

        private void btnBcThuoc_Click(object sender, EventArgs e)
        {
            QLBaoCaoThuoc f2 = new QLBaoCaoThuoc();
            f2.Show();
        }

        private void UC_QLThuoc_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int countrow = dgvQLThuoc.Rows.Count;           
            for (int i = 0; i < countrow; i++)
            {
                if (Content.IsDay(dgvQLThuoc.Rows[i].Cells[2].Value.ToString()) == date.Day &&
                    Content.IsMonth(dgvQLThuoc.Rows[i].Cells[2].Value.ToString()) == date.Month &&
                    Content.IsYear(dgvQLThuoc.Rows[i].Cells[2].Value.ToString()) == date.Year)
                {

                    DialogResult dr;
                    dr = MessageBox.Show(dgvQLThuoc.Rows[i].Cells[1].Value.ToString() + " hết hạn sử dụng.\nXóa gấp thuốc trong kho !\nLên gặp giám đốc nộp đơn thôi việc !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Content.IsMonth(dgvQLThuoc.Rows[i].Cells[2].Value.ToString()) == date.Month && Content.IsYear(dgvQLThuoc.Rows[i].Cells[2].Value.ToString()) == date.Year && Content.IsDay(dgvQLThuoc.Rows[i].Cells[2].Value.ToString()) < date.Day )
                {

                    DialogResult dr;
                    dr = MessageBox.Show(dgvQLThuoc.Rows[i].Cells[1].Value.ToString() + " hết hạn sử dụng.\nHãy xóa thuốc và nhập thuốc mới trong kho !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((Content.IsMonth(dgvQLThuoc.Rows[i].Cells[2].Value.ToString()) == date.Month + 1 || Content.IsMonth(dgvQLThuoc.Rows[i].Cells[2].Value.ToString()) == date.Month) && Content.IsYear(dgvQLThuoc.Rows[i].Cells[2].Value.ToString())==date.Year)
                {

                    DialogResult dr;
                    dr = MessageBox.Show(dgvQLThuoc.Rows[i].Cells[1].Value.ToString() + " sắp hết hạn sử dụng.\nHãy xóa thuốc và nhập thuốc mới trong kho !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }        
    }
}
