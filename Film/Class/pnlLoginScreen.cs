using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace Film.Class
{
    public partial class pnlLoginScreen : UserControl
    {
        frmMain main;
        public pnlLoginScreen(frmMain form)
        {
            InitializeComponent();
            main = form;
            form.MinimumSize = new Size(this.MinimumSize.Width + 50, this.MinimumSize.Height + 90);
            form.Resize += main_Resize;
            ResizeForm();
            metroTextBox_Password.UseSystemPasswordChar = true;
            checkBox_showPass.Image = Properties.Resources.eye_hide;
        }
        private void metroButton_Login_Click(object sender, EventArgs e)
        {
            SQLFilmDataContext filmDC = new SQLFilmDataContext();

            if (metroTextBox_Username.Text == "")
            {
                metroToolTip_Login.Show("Username cannot be empty!", metroTextBox_Username);
            }
            else if (metroTextBox_Password.Text == "")
            {
                metroToolTip_Login.Show("Password cannot be empty!", metroTextBox_Password);
            }
            else
            {
                TbQuanLyNhanSu qlns = filmDC.TbQuanLyNhanSus.SingleOrDefault(ns => ns.TenDangNhap == metroTextBox_Username.Text);
                if (qlns != null)
                {
                    if (qlns.MatKhau == metroTextBox_Password.Text && qlns.TrangThai == "Activated")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Welcome to Margarita.", "SUCCESSFUL!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        main.tendangnhap = qlns.TenDangNhap;
                        if (qlns.PhanQuyen == "Administrator")
                            main.isAdministator = true;
                        else
                            main.isAdministator = false;
                        main.pnl_Menu();
                        main.sessionIN();
                        UCslide.Slide(main, this);
                        this.Dispose();
                        main.Controls.Remove(this);
                    }
                    else if (qlns.MatKhau == metroTextBox_Password.Text && qlns.TrangThai != "Activated")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "BUT Your account is temporarily locked!", "SUCCESSFUL!");
                    }
                    else
                    {
                        metroToolTip_Login.Show("That password is incorrect", metroTextBox_Password);
                    }
                }
                else
                {
                    metroToolTip_Login.Show("That username is incorrect", metroTextBox_Username);
                }
            }
        }

        void main_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            this.Width = main.Width - 60;
            this.Height = main.Height - 85;
            this.Location = new Point(30, 53);
        }

        private void metroTextBox_Username_Enter(object sender, EventArgs e)
        {
            metroToolTip_Login.Hide(metroTextBox_Username);
            metroToolTip_Login.Hide(metroTextBox_Password);
        }

        private void metroTextBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                metroButton_Login.PerformClick();
            }
        }

        private void metroTextBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                metroButton_Login.PerformClick();
            }
        }

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPass.Checked)
            {
                checkBox_showPass.Image = Properties.Resources.eye_show;
                metroTextBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                metroTextBox_Password.UseSystemPasswordChar = true;
                checkBox_showPass.Image = Properties.Resources.eye_hide;
            }
        }
    }
}
