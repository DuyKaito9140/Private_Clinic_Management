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
    public partial class SignIn : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        Random rd = new Random();
        public SignIn()
        {
            InitializeComponent();
        }
        public void LoadTK()
        {
            var listTK = from tk in dbe.QLTaiKhoans
                         select new
                         {
                             Username = tk.Username,
                             Password = tk.Password
                         };
            dgvSignIn.DataSource = listTK.ToList();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            LoadTK();            
            tbCaptCha.Text = rd.Next(1000, 10000).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBE_QLPMT dbe_add_tk = new DBE_QLPMT();            
            string user = tbusername.Text;
            string pass = tbpass.Text;            
            string tenadmin = tbNameAdmin.Text;
            string mkadmin = tbpassAdmin.Text;
            string captcha = tbNhapCap.Text;
            if (string.IsNullOrEmpty(tenadmin))
            {
                MessageBox.Show("Tên admin không được để trống !");
                return;
            }
            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Hãy nhập mật khẩu admin !");
                return;
            }           
            else if(tenadmin != dgvSignIn.Rows[0].Cells[0].Value.ToString() || mkadmin != dgvSignIn.Rows[0].Cells[1].Value.ToString())
            {
                MessageBox.Show("TÀI KHOẢN ADMIN KHÔNG ĐÚNG !");
            }
            else if (captcha != tbCaptCha.Text)
            {
                MessageBox.Show("MÃ CAPTCHA KHÔNG ĐÚNG. NHẬP LẠI MÃ MỚI !");
                tbCaptCha.Text = rd.Next(1000, 10000).ToString();
            }
            else
            {
                QLTaiKhoan tk = dbe_add_tk.QLTaiKhoans.Where(mab => mab.Username == user).SingleOrDefault();
                if (tk != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.\nHãy chọn 1 tên khác !");
                    return;
                }
                else if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Tên đăng nhập không được để trống không được để trống !");
                    return;
                }
                else if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Mật khẩu không được để trống không được để trống !");
                    return;
                }
                else if (string.IsNullOrEmpty(tbNhaplaiMK.Text))
                {
                    MessageBox.Show("Hãy xác nhận lại mật khẩu mới !");
                    return;
                }
                else if (pass != tbNhaplaiMK.Text)
                {
                    MessageBox.Show("Xác thực mật khẩu không đúng. Nhập lại xác thực mật khẩu mới !");
                    return;
                }
                else if (pass.Length < 5)
                {
                    MessageBox.Show("Mật khẩu quá ngắn và không an toàn . Hãy thử lại !");
                    return;
                }
                else
                {

                    tk = new QLTaiKhoan();
                    tk.Username = user;
                    tk.Password = pass;
                    dbe_add_tk.QLTaiKhoans.Add(tk);
                    dbe_add_tk.SaveChanges();
                    LoadTK();
                    MessageBox.Show("Thêm tài khoản mới thành công !");
                    tbNameAdmin.Text = "";
                    tbpassAdmin.Text = "";
                    tbNhapCap.Text = "";
                    tbCaptCha.Text = rd.Next(1000, 10000).ToString();
                    tbusername.Text = "";
                    tbpass.Text = "";
                    tbNhaplaiMK.Text = "";
                }
            }            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Logins lg = new Logins();
            lg.Show();
            this.Hide();
        }

    }
}
