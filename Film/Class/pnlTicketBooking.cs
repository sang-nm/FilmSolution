using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Film.Class
{
    public partial class pnlTicketBooking : UserControl
    {
        #region tumlum
        public frmMain main;
        SQLFilmDataContext FilmDC = new SQLFilmDataContext();
        public int malichchieu { get; set; } = 0;
        public string lb_movie { get; set; }
        public string lb_redate { get; set; }
        public string lb_showing { get; set; }
        public string tendangnhap { get; set; }
        public List<Button> seats = new List<Button>();
        #endregion

        public pnlTicketBooking(frmMain form)
        {
            InitializeComponent();
            main = form;
            tendangnhap = main.tendangnhap;
            form.MinimumSize = new Size(this.MinimumSize.Width + 50, this.MinimumSize.Height + 90);
            form.Resize += main_Resize;
            ResizeForm();
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

        private void seat()
        {
            label_Movie.Text = lb_movie;
            label_ReDate.Text = lb_redate;
            label_Showing.Text = lb_showing;
            var list = FilmDC.TbBanVes.Where(v => v.MaLichChieu == malichchieu);
            List<string> bookingtickets = list.Select(x => x.Ghe).Distinct().ToList();
            Font font = new Font("Times New Roman", 13);
            int index = 0;
            for (int i = 0; i < 6; i++)
            {
                Label lb = new Label();
                var lbmargin = lb.Margin;
                lbmargin.Top = 28;
                lb.Margin = lbmargin;
                lb.Font = font;
                lb.Size = new Size(20, 20);
                switch (i)
                {
                    case 0:
                        {
                            lb.Text = "A";
                            flowLayoutPanel_Booking.Controls.Add(lb);
                        }
                        break;
                    case 1:
                        {
                            lb.Text = "B";
                            flowLayoutPanel_Booking.Controls.Add(lb);
                        }
                        break;
                    case 2:
                        {
                            lb.Text = "C";
                            flowLayoutPanel_Booking.Controls.Add(lb);
                        }
                        break;
                    case 3:
                        {
                            lb.Text = "D";
                            flowLayoutPanel_Booking.Controls.Add(lb);
                        }
                        break;
                    case 4:
                        {
                            lb.Text = "E";
                            flowLayoutPanel_Booking.Controls.Add(lb);
                        }
                        break;
                    case 5:
                        {
                            lb.Text = "F";
                            flowLayoutPanel_Booking.Controls.Add(lb);
                        }
                        break;
                    case 6:
                        {
                            lb.Text = "G";
                            flowLayoutPanel_Booking.Controls.Add(lb);
                        }
                        break;
                    case 7:
                        {
                            lb.Text = "H";
                            flowLayoutPanel_Booking.Controls.Add(lb);
                        }
                        break;
                    default:
                        break;
                }
                for (int j = 0; j < 14; j++)
                {
                    index++;
                    Button button = new Button();
                    if (j == 4 ^ j == 10)
                    {
                        var btmargin = button.Margin;
                        btmargin.Left = 30;
                        button.Margin = btmargin;
                    }
                    button.Text = lb.Text + (j + 1).ToString();
                    button.Name = lb.Text + (j + 1).ToString();
                    button.Size = new Size(70, 70);
                    button.TabStop = false;
                    button.Font = font;

                    if ((lb.Text == "C" ^ lb.Text == "D") && (j + 1 >= 5 && j + 1 <= 10))
                    {
                        button.Image = Properties.Resources.cinema_chair;
                    }
                    else
                    {
                        button.Image = Properties.Resources.cinema_chair_VIP;
                    }
                    button.ImageAlign = ContentAlignment.TopCenter;
                    button.UseVisualStyleBackColor = true;
                    button.BackColor = Color.Khaki;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.MouseOverBackColor = Color.DarkKhaki;
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Color.White;
                    button.Click += new EventHandler(Seat_Click);
                    flowLayoutPanel_Booking.Controls.Add(button);
                    if (bookingtickets.Contains(button.Text))
                    {
                        button.BackColor = Color.DarkBlue;
                        button.ForeColor = Color.Black;
                        button.FlatAppearance.MouseOverBackColor = Color.Empty;
                        button.FlatAppearance.BorderSize = 3;
                        button.FlatAppearance.BorderColor = Color.WhiteSmoke;
                        button.Enabled = false;
                    }
                }
            }
            //button_Select.PerformClick();
        }

        void Seat_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Khaki)
            {
                ((Button)sender).BackColor = Color.RoyalBlue;
                ((Button)sender).ForeColor = Color.White;
                ((Button)sender).FlatAppearance.MouseOverBackColor = Color.Empty;
                ((Button)sender).FlatAppearance.BorderSize = 3;
                ((Button)sender).FlatAppearance.BorderColor = Color.WhiteSmoke;
                seats.Add(((Button)sender));
            }
            else
            {
                ((Button)sender).BackColor = Color.Khaki;
                ((Button)sender).ForeColor = Color.Black;
                ((Button)sender).FlatAppearance.MouseOverBackColor = Color.DarkKhaki;
                ((Button)sender).FlatAppearance.BorderSize = 1;
                ((Button)sender).FlatAppearance.BorderColor = Color.White;
                seats.Remove(((Button)sender));
            }
            ActiveControl = null;
            ((Button)sender).NotifyDefault(false);
        }

        private void pnlBooking_Load(object sender, EventArgs e)
        {
            seat();
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            pnlLooking search = new pnlLooking(this);
            search.Location = new Point(main.ClientSize.Width / 2 - search.Size.Width / 2, main.ClientSize.Height / 2 - search.Size.Height / 2);
            main.Controls.Add(search);
            search.BackColor = SystemColors.Control;

            search.BringToFront();
            search.Focus();
        }

        private void pnlBooking_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled == true)
            {
                seats.Clear();
                flowLayoutPanel_Booking.Controls.Clear();
                seat();
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (label_Movie.Text != "")
            {
                this.Enabled = false;
                pnlBooking booking = new pnlBooking(this);
                booking.Location = new Point(main.ClientSize.Width / 2 - booking.Size.Width / 2, main.ClientSize.Height / 2 - booking.Size.Height / 2);
                main.Controls.Add(booking);
                booking.BackColor = SystemColors.Control;

                booking.BringToFront();
                booking.Focus();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select movie", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonX_Back_Click(object sender, EventArgs e)
        {
            main.pnl_Menu();
            UCslide.Slide(main, this);
            this.Dispose();
            main.Controls.Remove(this);
        }
    }
}
