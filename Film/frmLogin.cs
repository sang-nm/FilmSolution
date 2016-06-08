using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film
{
    public partial class frmLogin : Form
    {
        public bool isLogin = false;
        public bool isAdmin = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        public string email;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                error1.SetError(txtUser, "Error");
                ssText.Text = "Nhập email";
                txtUser.Focus();
            }
            else if (txtPass.Text == "")
            {
                error1.SetError(txtPass, "Error");
                ssText.Text = "Nhập password";
                txtPass.Focus();
            }
            else
            {
                error1.SetError(txtUser, "");
                error1.SetError(txtPass, "");
                ssText.Text = "";
                bool usertext = false;
                //FileStream fs = new FileStream("User.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                //StreamReader sr = new StreamReader(fs);

                SqlConnection conn = new SqlConnection("Data Source=FELISSILVESTRIS\\SQLEXPRESS; Initial Catalog=SQLFILM; User ID=sa; Password=123456");
                SqlCommand cmd = new SqlCommand("SELECT * FROM QuanLyNhanSu", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                
                while (dr.Read())
                {
                    string user = dr[0].ToString();
                    string pass = dr[1].ToString();
                    if (user == txtUser.Text)
                    {
                        usertext = true;
                        if (pass == txtPass.Text && dr[3].ToString() == "Activated")
                        {
                            error1.SetError(txtPass, "");
                            ssText.Text = "";
                            MessageBox.Show("Đăng nhập thành công");
                            isLogin = true;
                            email = txtUser.Text;
                            if (dr[2].ToString() == "Administrator")
                            {
                                isAdmin = true;
                            }
                            this.Close();
                        }
                        else if (pass == txtPass.Text && dr[3].ToString() != "Activated")
                        {
                            ssText.Text = "Tài khoản chưa được kích hoạt!";
                        }
                        else
                        {
                            error1.SetError(txtPass, "Wrong");
                            ssText.Text = "Sai password";
                            txtPass.Focus();
                            return;
                        }
                    }
                }
                //sr.Close();
                //fs.Close();
                if (isLogin == false && usertext == false)
                {
                    error1.SetError(txtUser, "Wrong");
                    ssText.Text = "Sai Email";
                    txtUser.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        frmRegister callReg;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            callReg = new frmRegister();
            callReg.ShowDialog();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }
    }
}
