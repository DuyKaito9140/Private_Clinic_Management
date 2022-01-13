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
    public partial class BenhNhan : Form 
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public BenhNhan()
        {
            InitializeComponent();
        }
        public void LoadBN()
        {
            var listBN = from bn in dbe.QLBENHNHANs
                         select new
                         {
                             MaBN = bn.MaBN,
                             HoTen = bn.HoTen,
                             GioiTinh = bn.GioiTinh,
                             Sdt = bn.Sdt,
                         };
            dgvDSBenhNhan.DataSource = listBN.ToList();

            //DataBindings thông tin bệnh nhân
            tbMaBN.DataBindings.Clear();
            tbMaBN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "MaBN"));
            tbHoTenBN.DataBindings.Clear();
            tbHoTenBN.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "HoTen"));
            tbGioiTinh.DataBindings.Clear();
            tbGioiTinh.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "GioiTinh"));
            tbSdt.DataBindings.Clear();
            tbSdt.DataBindings.Add(new Binding("Text", dgvDSBenhNhan.DataSource, "Sdt"));
        }
        private void BenhNhan_Load(object sender, EventArgs e) 
        {
            LoadBN();
        }

        private void btnChonBN_Click(object sender, EventArgs e)
        {
            Content.LMaBN = tbMaBN.Text;
            Content.LHoTenBN = tbHoTenBN.Text;
            Content.LSdt = tbSdt.Text;
            Content.Ltrangthai = "ChonXong";
            this.Hide();
        }
    }
}
