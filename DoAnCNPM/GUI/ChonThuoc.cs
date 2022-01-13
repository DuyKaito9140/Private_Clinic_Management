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
    public partial class ChonThuoc : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        UC_PhieuKham f1;
        QLPhieuKham f2;
        NhapChiTietPhieu f3;
        public ChonThuoc()
        {
            InitializeComponent();           
        }
        public ChonThuoc(UC_PhieuKham f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        public ChonThuoc(QLPhieuKham f2)
        {
            InitializeComponent();
            this.f2 = f2;
        }
        public ChonThuoc(NhapChiTietPhieu f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }
        public void LoadChonThuoc()
        {
            var listThuoc = from thuoc in dbe.THUOCs
                            select new
                            {
                                MaThuoc = thuoc.MaThuoc,
                                TenThuoc = thuoc.TenThuoc,
                                DonVi = thuoc.DonVi,
                                GiaThuoc = thuoc.GiaThuoc,
                                HanSuDung = thuoc.HanSuDung,
                                SoLuongTrongKho = thuoc.SoLuongTrongKho,
                                CachDung = thuoc.CachDung
                            };
            dgvQLThuoc.DataSource = listThuoc.ToList();

            //DataBindings thông tin thuốc
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

        private void btnChonThuoc_Click(object sender, EventArgs e)
        {
            Content.CMaThuoc = tbMaThuoc.Text;
            Content.CSoLuongConTrongKho = tbSoLuongTrongKho.Text;
            Content.CCachDung = tbCachDung.Text;
            NhapChiTietPhieu pk = new NhapChiTietPhieu(this);
            pk.Show();
            this.Hide();
        }
        private void ChonThuoc_Load(object sender, EventArgs e)
        {
            LoadChonThuoc();
        }
    }
}
