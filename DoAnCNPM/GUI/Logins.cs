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
    public partial class Logins : Form
    {
        DBE_QLPMT dbe = new DBE_QLPMT();
        public Logins()
        {
            InitializeComponent();
            LoadTK();
        }
        public void LoadTK()
        {
            var listTK = from tk in dbe.QLTaiKhoans
                         select new
                         {
                             Username = tk.Username,
                             Password = tk.Password
                         };
            dgvLogin.DataSource = listTK.ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            int count = dgvLogin.Rows.Count;
            string username = tbusername.Text;
            string password = tbpass.Text;
            bool status = false;
            for (int i = 0; i < count; i++)
            {
                if (username == dgvLogin.Rows[i].Cells[0].Value.ToString() && password == dgvLogin.Rows[i].Cells[1].Value.ToString())
                {
                    Content.TKten = tbusername.Text;
                    if(tbusername.Text != "admin")
                    {
                        Content.TKQuyen = "Thành viên";
                    }
                    DashBoard f1 = new DashBoard();
                    f1.Show();
                    this.Hide();
                    status = true;
                }                
                    
            }
            if(status==false)
                MessageBox.Show("ĐĂNG NHẬP THẤT BẠI");

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn();
            sign.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
