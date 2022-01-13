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
    public partial class ThongKeThuoc : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public ThongKeThuoc()
        {
            InitializeComponent();
        }
        public void LoadPhieuKham()
        {
            var listPhieu = from phieu in dbe.PHIEUKHAMBENHs
                            select new
                            {
                                MaPhieuKham = phieu.MaPhieuKham,                                
                                NgayKham = phieu.NgayKham,
                                TenThuoc = phieu.THUOC.TenThuoc,
                                SoLuongDung = phieu.SoLuongDung
                            };
            dgvPhieuTKT.DataSource = listPhieu.ToList();
        }
        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            if (tbMaBCTh.Text == "")
            {
                MessageBox.Show("Nhập mã Báo Cáo Thuốc !");
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
                                        MaPhieuKham = dt.MaPhieuKham,
                                        NgayKham = dt.NgayKham,
                                        TenThuoc = dt.THUOC.TenThuoc,
                                        SoLuongDung = dt.SoLuongDung
                                  };
                PHIEUKHAMBENH hd = dbe_search.PHIEUKHAMBENHs.Where(h => h.NgayKham.Value.Month.ToString().Equals(thang) && h.NgayKham.Value.Year.ToString().Equals(nam)).FirstOrDefault();
                if (hd == null)
                {
                    MessageBox.Show("Không tìm thấy tháng/năm tương ứng thống kê.\nKiểm tra và thử lại !");
                    return;
                }
                dgvPhieuTKT.DataSource = listthongke.ToList();
                int countRow = dgvPhieuTKT.Rows.Count;
                string chuoithuocdadung = "";
                List<string> listthuoc = new List<string>();
                int temp = 2;
                listthuoc.Add(dgvPhieuTKT.Rows[0].Cells[2].Value.ToString());
                for (int i = 1; i < countRow; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (dgvPhieuTKT.Rows[i].Cells[2].Value.ToString() == dgvPhieuTKT.Rows[j].Cells[2].Value.ToString())
                        {

                            temp = 0;
                            break;

                        }
                        else

                            temp = 1;
                    }
                    if (temp == 1)
                    {
                        listthuoc.Add(dgvPhieuTKT.Rows[i].Cells[2].Value.ToString());
                    }
                }
                int[] a = new int[listthuoc.Count];
                for (int i = 0; i < listthuoc.Count; i++)
                {
                    a[i] = 0;
                    for (int j = 0; j < countRow; j++)
                    {
                        if(listthuoc[i] == dgvPhieuTKT.Rows[j].Cells[2].Value.ToString())
                        {
                            a[i] += int.Parse(dgvPhieuTKT.Rows[j].Cells[3].Value.ToString());
                        }
                    }
                }
                for (int i = 0; i < listthuoc.Count; i++)
                {
                    if (i == listthuoc.Count - 1)
                    {
                        chuoithuocdadung += listthuoc[i] + " - " + a[i];
                    }
                    else
                    {
                        chuoithuocdadung += listthuoc[i] + " - " + a[i] + " / ";
                    }                   
                }
                tbSoLuongThuocDaDung.Text = chuoithuocdadung;
            }
        }

        private void ThongKeThuoc_Load(object sender, EventArgs e)
        {
            LoadPhieuKham();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadPhieuKham();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbMaBCTh.Text == "")
            {
                MessageBox.Show("Nhập mã Báo Cáo Thuốc.\nNhập và thử lại !");
            }
            else if (tbMaBCTh.Text.Length != 10 || tbMaBCTh.Text[0] != 'B' || tbMaBCTh.Text[1] != 'C' || tbMaBCTh.Text[2] != 'T')
            {
                MessageBox.Show("Mã Báo Cáo Thuốc sai, mã báo cáo thuốc bao gồm 10 kí tự !\n3 ký tự đầu là BCT.\n7 ký tự sau là số.");
                return;
            }
            else
            {
                Content.BCMaBCTh = tbMaBCTh.Text;
                Content.BCThang = tbCbThang.Text;
                Content.BCNam = tbCbNam.Text;
                Content.BCSoLuongThuocDung = tbSoLuongThuocDaDung.Text;
                Content.uptrangthai = "TKThuocXong";
                this.Hide();
            }           
        }
    }
}
