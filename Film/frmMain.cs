using Film.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //pnlShow("Trailer");
            pnlLoginScreen login = new pnlLoginScreen(this);
            this.Controls.Add(login);
            login.BackColor = SystemColors.Control;
            login.BringToFront();
        }

        public void pnl_Menu()
        {
            pnlMenuAdmin MA = new pnlMenuAdmin(this);
            this.Controls.Add(MA);
            MA.BackColor = SystemColors.Control;
            MA.Size = pnl_fill;
            MA.Location = pnl_point;
            //MA.BringToFront();
            this.Size = new Size(1248, 700);
            this.Resizable = false;
        }

        public void sessionIN()
        {
            label2.Visible = true;
            label_Name.Visible = true;
            label_Name.Text = tendangnhap;
            if (isAdministator)
            {
                label_Name.ForeColor = Color.Red;
            }
        }

        public void sesstionOUT()
        {
            label2.Visible = false;
            label_Name.Visible = false;
            label_Name.Text = Name;
            label_Name.ForeColor = Color.White;
        }

        public void pnlShow(string pnl_Name)
        {
            this.Resizable = true;
            this.Refresh();
            switch (pnl_Name)
            {
                case "LoginScreen":
                    pnlLoginScreen login = new pnlLoginScreen(this);
                    this.Controls.Add(login);
                    login.BackColor = SystemColors.Control;
                    login.BringToFront();
                    break;

                case "UserManagement":
                    pnlUserManagement UM = new pnlUserManagement(this);
                    this.Controls.Add(UM);
                    UM.BackColor = SystemColors.Control;
                    UM.BringToFront();
                    break;

                case "AddMovie":
                    pnlAddMovie addmovie = new pnlAddMovie(this);
                    this.Controls.Add(addmovie);
                    //pnl.BackColor = SystemColors.Control;
                    addmovie.BringToFront();
                    break;

                case "MovieManagement":
                    pnlMovieManagement pnlMM = new pnlMovieManagement(this);
                    this.Controls.Add(pnlMM);
                    //pnl.BackColor = SystemColors.Control;
                    pnlMM.BringToFront();
                    break;

                case "ShowtimesManagement":
                    pnlShowtimesManagement pnlSM = new pnlShowtimesManagement(this);
                    this.Controls.Add(pnlSM);
                    pnlSM.BackColor = SystemColors.Control;
                    pnlSM.BringToFront();
                    break;

                case "TicketBooking":
                    pnlTicketBooking pnlB = new pnlTicketBooking(this);
                    this.Controls.Add(pnlB);
                    pnlB.BackColor = SystemColors.GradientActiveCaption;
                    pnlB.BringToFront();
                    this.Size = new Size(1248, 700);
                    this.Resizable = false;
                    break;

                case "MemberManagement":
                    pnlMemberManagerment pnlMeM = new pnlMemberManagerment(this);
                    this.Controls.Add(pnlMeM);
                    pnlMeM.BackColor = SystemColors.Control;
                    pnlMeM.BringToFront();
                    break;

                case "MemberReg":
                    pnlMemberReg pnlReg = new pnlMemberReg(this);
                    pnlReg.Location = new Point(this.ClientSize.Width / 2 - pnlReg.Size.Width / 2, this.ClientSize.Height / 2 - pnlReg.Size.Height / 2);
                    this.Controls.Add(pnlReg);
                    pnlReg.BackColor = SystemColors.Control;
                    pnlReg.BringToFront();
                    pnl_IN.Enabled = false;
                    break;
                case "Password":
                    pnlChangePassword pnlCp = new pnlChangePassword(this);
                    pnlCp.Location = new Point(this.ClientSize.Width / 2 - pnlCp.Size.Width / 2, this.ClientSize.Height / 2 - pnlCp.Size.Height / 2);
                    this.Controls.Add(pnlCp);
                    pnlCp.BackColor = SystemColors.Control;
                    pnlCp.BringToFront();
                    pnl_IN.Enabled = false;
                    break;

                case "Coupon":
                    pnlCoupon pnlC = new pnlCoupon(this);
                    this.Controls.Add(pnlC);
                    pnlC.BackColor = SystemColors.Control;
                    pnlC.BringToFront();
                    break;

                case "Trailer":
                    pnlTrailer pnlT = new pnlTrailer(this);
                    this.Controls.Add(pnlT);
                    pnlT.BackColor = SystemColors.Control;
                    pnlT.BringToFront();
                    break;

                default:
                    break;
            }
        }

        private void metroLink_Power_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region tumlum
        public string tendangnhap { get; set; }
        public bool isAdministator { get; set; }
        public Size pnl_fill = new Size(1188, 619);
        public Point pnl_point = new Point(30, 53);
        public Control pnl_IN { get; set; }
        #endregion

    }
}
