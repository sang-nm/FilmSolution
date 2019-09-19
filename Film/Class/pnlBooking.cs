using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Linq;

namespace Film.Class
{
    public partial class pnlBooking : UserControl
    {
        public frmMain main;
        pnlTicketBooking pnl;
        SQLFilmDataContext FilmDC = new SQLFilmDataContext();
        public string TicketID { get; set; }
        public int subtotal { get; set; } = 0;
        public int discount { get; set; } = 0;
        public int total { get; set; } = 0;
        public string mathanhvien { get; set; } = null;

        public pnlBooking(pnlTicketBooking pnl)
        {
            InitializeComponent();
            main = pnl.main;
            this.pnl = pnl;
        }

        public pnlBooking()
        {
            InitializeComponent();
        }

        private void loaditem()
        {
            string[] lastrecord = FilmDC.TbBanVes.OrderByDescending(v => v.MaVe).First().MaVe.Split('_');
            string id = (Convert.ToInt32(lastrecord[0]) + 1).ToString("0000.##");
            TicketID = id;
            label_TicketID.Text = id;
            label_Movie.Text = pnl.lb_movie;
            label_Seats.Text = " | ";
            foreach (Button seat in pnl.seats)
            {
                label_Seats.Text += seat.Text + " | ";
                if (seat.Text[0] == 'C' ^ seat.Text[0] == 'D')
                {
                    int number = Convert.ToInt32(seat.Text.Substring(1, seat.Text.Length - 1));
                    if (number >= 5 && number <= 10)
                    {
                        subtotal += 70000;
                    }
                }
                else
                {
                    subtotal += 50000;
                }
            }
            label_Subtotal.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:#,## đ}", subtotal);
            label_Total.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:#,## đ}", subtotal);
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            int count = 0, gia = 0;
            foreach (Button seat in pnl.seats)
            {
                if (seat.Text[0] == 'C' ^ seat.Text[0] == 'D')
                {
                    int number = Convert.ToInt32(seat.Text.Substring(1, seat.Text.Length - 1));
                    if (number >= 5 && number <= 10)
                    {
                        gia = 70000;
                    }
                }
                else
                {
                    gia = 50000;
                }
                count++;
                if (label_MemberID.Text != "")
                {
                    TbBanVe ticket = new TbBanVe
                    {
                        MaVe = (TicketID + "_" + count).ToString(),
                        MaLichChieu = pnl.malichchieu,
                        TenDangNhap = pnl.tendangnhap,
                        Ghe = seat.Text,
                        GiaVe = gia,
                        MaThanhVien = Convert.ToInt32(label_MemberID.Text),
                        Discount = discount / pnl.seats.Count
                    };
                    FilmDC.TbBanVes.InsertOnSubmit(ticket);
                }
                else
                {
                    TbBanVe ticket = new TbBanVe
                    {
                        MaVe = (TicketID + "_" + count).ToString(),
                        MaLichChieu = pnl.malichchieu,
                        TenDangNhap = pnl.tendangnhap,
                        Ghe = seat.Text,
                        GiaVe = gia,
                        MaThanhVien = null,
                        Discount = discount / pnl.seats.Count
                    };
                    FilmDC.TbBanVes.InsertOnSubmit(ticket);
                }
                
                FilmDC.SubmitChanges();
            }
            
            pnl.seats.Clear();
            MetroFramework.MetroMessageBox.Show(this, "Done", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            button_X.PerformClick();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.DarkGray);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            myPen.Width = 2;
            Graphics formGraphics = splitContainer1.Panel1.CreateGraphics();
            formGraphics.DrawLine(myPen, 0, 175, Width, 175);
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
            main.Controls.Remove(this);
            pnl.Enabled = true;
        }

        private void button_Discount_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == false)
            {
                splitContainer1.Panel2Collapsed = true;
            }
            else if (splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
            }
        }

        private void pnlBooking_Load(object sender, EventArgs e)
        {
            loaditem();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if (radioButton_Member.Checked == false && radioButton_Voucher.Checked == false && textBox_Code.Text == "")
            {
                splitContainer1.Panel2Collapsed = true;
            }
            else if (radioButton_Member.Checked == false && radioButton_Voucher.Checked == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select member or voucher", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_Code.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter coupon code", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (radioButton_Member.Checked == true)
                {
                    try
                    {
                        var linq = FilmDC.TbMembers.SingleOrDefault(i => i.MaCoupon == textBox_Code.Text);
                        label_MemberID.Text = linq.MaThanhVien.ToString();
                        label_Name.Text = linq.HoTen.ToString();
                        label_DoB.Text = ((DateTime)linq.NgaySinh).ToString("dd/MM/yyyy");
                        label_IDnum.Text = linq.CMND.ToString();
                        label_Phone.Text = linq.SDT.ToString();
                        label_CC.Text = linq.MaCoupon.ToString();
                        panel_Member.Visible = true;
                        discount = (int)FilmDC.TbCoupons.SingleOrDefault(m => m.MaCoupon == textBox_Code.Text).Member;
                        total = subtotal;
                        foreach (Button item in pnl.seats)
                        {
                            total = total - discount;
                        }
                        button_Discount.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:#,## đ}", subtotal - total);
                        label_Total.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:#,## đ}", total);
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Coupon code is wrong", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (radioButton_Voucher.Checked == true)
                {
                    try
                    {
                        discount = (int)FilmDC.TbCoupons.SingleOrDefault(v => v.MaCoupon == textBox_Code.Text).Voucher;
                        total = subtotal - discount;
                        button_Discount.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:#,## đ}", discount);
                        label_Total.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:#,## đ}", total);
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Coupon code is wrong", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel_Member.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
            panel_Member.Visible = false;
        }

        private void button_NewMR_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            pnlMemberReg Mreg = new pnlMemberReg(this);
            Mreg.Location = new Point(main.ClientSize.Width / 2 - Mreg.Size.Width / 2, main.ClientSize.Height / 2 - Mreg.Size.Height / 2);
            main.Controls.Add(Mreg);
            Mreg.BackColor = SystemColors.Control;

            Mreg.BringToFront();
            Mreg.Focus();
        }
    }
}
