using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film.Class
{
    public partial class pnlMemberReg : UserControl
    {
        frmMain main;
        pnlMemberManagerment pnlMM;
        pnlBooking pnlB;
        SQLFilmDataContext FilmDC = new SQLFilmDataContext();

        public pnlMemberReg(pnlMemberManagerment pnl1)
        {
            InitializeComponent();
            main = pnl1.main;
            pnlMM = pnl1;
        }

        public pnlMemberReg(pnlBooking pnl2)
        {
            InitializeComponent();
            main = pnl2.main;
            pnlB = pnl2;
        }

        public pnlMemberReg(frmMain form)
        {
            InitializeComponent();
            main = form;
        }

        private bool validate()
        {
            if (txtTen.Text == "")
            {
                errorReg.SetError(txtTen, "Error");
                sstReg.Text = "Enter Name";
                txtTen.Focus();
                return false;
            }
            else if (dateNgaySinh.Value.Date >= DateTime.Now.Date)
            {
                errorReg.SetError(dateNgaySinh, "Error");
                sstReg.Text = "Enter date";
                dateNgaySinh.Focus();
                return false;
            }
            else if (txtCMND.Text == "")
            {
                errorReg.SetError(txtCMND, "Error");
                sstReg.Text = "Enter ID number";
                txtCMND.Focus();
                return false;
            }
            else if (txtDT.Text == "")
            {
                errorReg.SetError(txtDT, "Error");
                sstReg.Text = "Enter phone number";
                txtDT.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private string randomCode()
        {
            string str01 = "abcdefghijklmnopqrstuvwxyz";
            string str02 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string str03 = "0123456789";
            string strValid = str01 + str02 + str03;
            Random random = new Random();

            string code = "";
            for (int i = 0; i < 20; i++)
            {
                int randnum = random.Next(strValid.Length);
                code = code + strValid[randnum];
            }
            return code;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                errorReg.SetError((Control)item, "");
            }
            sstReg.Text = "";
            if (!validate())
            {
                return;
            }
            else
            {
                TbCoupon coupon = new TbCoupon
                {
                    MaCoupon = txtCode.Text,
                    Member = 15000,
                    Voucher = null
                };
                FilmDC.TbCoupons.InsertOnSubmit(coupon);
                FilmDC.SubmitChanges();
                TbMember member = new TbMember
                {
                    HoTen = txtTen.Text,
                    NgaySinh = dateNgaySinh.Value,
                    CMND = Convert.ToInt32(txtCMND.Text),
                    SDT = Convert.ToInt32(txtDT.Text),
                    MaCoupon = txtCode.Text
                };
                FilmDC.TbMembers.InsertOnSubmit(member);
                FilmDC.SubmitChanges();
                foreach (var item in Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = "";
                    }
                    if (item is DateTimePicker)
                    {
                        ((DateTimePicker)item).Value = DateTime.Now;
                    }
                }
                MetroFramework.MetroMessageBox.Show(this, "Update completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtCode.Text = randomCode();
                if (main.Controls.Contains(pnlMM))
                {
                    pnlMM.load();
                }
            }
        }

        private void pnlMemberReg_Load(object sender, EventArgs e)
        {
            txtCode.Text = randomCode();
        }

        private void btnCcel_Click(object sender, EventArgs e)
        {
            Hide();
            main.Controls.Remove(this);
            Dispose();
            if (pnlMM == null && pnlB == null)
            {
                main.pnl_IN.Enabled = true;
                main.pnl_IN = null;
            }
            if (main.Controls.Contains(pnlB))
            {
                pnlB.Enabled = true;
            }
            if (main.Controls.Contains(pnlMM))
            {
                pnlMM.Enabled = true;
                pnlMM.load();
            }
        }
    }
}
