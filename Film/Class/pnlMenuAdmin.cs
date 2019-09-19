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
    public partial class pnlMenuAdmin : UserControl
    {
        frmMain main;
        public pnlMenuAdmin(frmMain form)
        {
            InitializeComponent();
            main = form;
            form.Resize += main_Resize;
            ResizeForm();
            rule();
        }

        void main_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            this.Width = main.Width - 60;
            this.Height = main.Height - 90;
            this.Location = new Point(30, 53);
        }

        private void rule()
        {
            if (main.isAdministator == true)
            {
                metroTileItem_UserManagement.Visible = true;
                metroTileItem_SignUP.Visible = true;
                metroTileItem_MovieManagement.Visible = true;
                metroTileItem_Showtimes.Visible = true;
                metroTileItem_MemberManagement.Visible = true;
                metroTileItem_Coupon.Visible = true;
            }
        }

        private void metroTileItem_UserManagement_Click(object sender, EventArgs e)
        {
            main.pnlShow("UserManagement");
            this.Hide();
        }

        private void metroTileItem_SignUP_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.Show();
        }

        private void metroTileItem_LogOUT_Click(object sender, EventArgs e)
        {
            main.sesstionOUT();
            main.pnlShow("LoginScreen");
            this.Hide();
        }

        private void metroTileItem_AddMovie_Click(object sender, EventArgs e)
        {
            main.pnlShow("AddMovie");
            this.Hide();
        }

        private void metroTileItem_MovieManagement_Click(object sender, EventArgs e)
        {
            main.pnlShow("MovieManagement");
            this.Hide();
        }

        private void metroTileItem_Showtimes_Click(object sender, EventArgs e)
        {
            main.pnlShow("ShowtimesManagement");
            this.Hide();
        }

        private void metroTileItem_Booking_Click(object sender, EventArgs e)
        {
            main.pnlShow("TicketBooking");
            this.Hide();
        }

        private void metroTileItem_MemberReg_Click(object sender, EventArgs e)
        {
            main.pnl_IN = this;
            main.pnlShow("MemberReg");
        }

        private void metroTileItem_MemberManagement_Click(object sender, EventArgs e)
        {
            main.pnlShow("MemberManagement");
            this.Hide();
        }

        private void metroTileItem_Coupon_Click(object sender, EventArgs e)
        {
            main.pnlShow("Coupon");
            this.Hide();
        }

        private void metroTileItem_Trailer_Click(object sender, EventArgs e)
        {
            main.pnlShow("Trailer");
            this.Hide();
        }
    }
}
