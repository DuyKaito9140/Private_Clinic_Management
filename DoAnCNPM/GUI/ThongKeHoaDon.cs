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
    public partial class ThongKeHoaDon : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public ThongKeHoaDon()
        {
            InitializeComponent();
        }
        public void LoadHD()
        {
            var listHD = from hd in dbe.PHIEUKHAMBENHs
                         select new
                         {
                             MaHD = hd.HOADON.MaHD,
                             MaBN = hd.HOADON.MaBN,
                             NgayKham = hd.NgayKham,
                             TienKham = hd.HOADON.TienKham,
                             TienThuoc = hd.HOADON.TienThuoc
                         };
            dgvNhapHoaDon.DataSource = listHD.ToList();            
        }

        private void ThongKeHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void btnTinhToan_Click(object sender, EventArgs e) 
        {
            if (tbMaBCDT.Text == "")
            {
                MessageBox.Show("Nhập mã Báo Cáo Doanh Thu !");
            }
            else
            {
                string thang = tbCbThang.Text;
                string nam = tbCbNam.Text;
                DBE_QLPMT dbe_search = new DBE_QLPMT();
                var listthongke = from dt in dbe_search.PHIEUKHAMBENHs
                                  where dt.NgayKham.Value.Month.ToString().Equals(thang) && dt.NgayKham.Value.Year.ToString().Equals(nam)
                                  select new
                                  {
                                      MaHD = dt.MaHD,
                                      MaBN = dt.HOADON.MaBN,
                                      NgayKham = dt.NgayKham,
                                      TienKham = dt.HOADON.TienKham,
                                      TienThuoc = dt.HOADON.TienThuoc
                                  };
                PHIEUKHAMBENH hd = dbe_search.PHIEUKHAMBENHs.Where(h => h.NgayKham.Value.Month.ToString().Equals(thang) && h.NgayKham.Value.Year.ToString().Equals(nam)).FirstOrDefault();
                if (hd == null)
                {
                    MessageBox.Show("Không tìm thấy tháng/năm tương ứng thống kê.\nKiểm tra và thử lại !");
                    return;
                }
                dgvNhapHoaDon.DataSource = listthongke.ToList();
                int countRow = dgvNhapHoaDon.Rows.Count;
                int tongtienkham = 0;
                int tongtienthuoc = 0;
                for (int i = 0; i < countRow; i++)
                {
                      tongtienkham += int.Parse(dgvNhapHoaDon.Rows[i].Cells[3].Value.ToString());                   
                }
                for (int i = 0; i < countRow; i++)
                {
                      tongtienthuoc += int.Parse(dgvNhapHoaDon.Rows[i].Cells[4].Value.ToString());                                                     
                }
                int sumDT = tongtienkham + tongtienthuoc;
                tbTongDT.Text = sumDT.ToString();
                tbSoLuongBN.Text = countRow.ToString();
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(tbMaBCDT.Text == "")
            {
                MessageBox.Show("Nhập mã Báo Cáo Doanh Thu.\nNhập và thử lại !");
            }
            else if (tbMaBCDT.Text.Length != 10 || tbMaBCDT.Text[0] != 'B' || tbMaBCDT.Text[1] != 'C')
            {
                MessageBox.Show("Mã Báo Cáo Doanh Thu sai, mã báo cáo doanh thu bao gồm 10 kí tự !\n2 ký tự đầu là BC.\n8 ký tự sau là số.");
                return;
            }
            else
            {
                Content.DMaBCDT = tbMaBCDT.Text;
                Content.DThangBC = tbCbThang.Text;
                Content.DNamBC = tbCbNam.Text;
                Content.DSoBN = tbSoLuongBN.Text;
                Content.DTongDT = tbTongDT.Text;
                Content.feel = "ThongKeXong";
                this.Hide();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
