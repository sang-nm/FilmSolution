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
    public partial class pnlTrailer : UserControl
    {
        frmMain main;
        public pnlTrailer(frmMain form)
        {
            InitializeComponent();
            main = form;
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
            toolStripTextBox_Link.Size = new Size(toolStrip_Trailer.Width - 190, toolStripTextBox_Link.Height);
        }

        private void toolStripButton_Back_Click(object sender, EventArgs e)
        {
            webBrowser_Trailer.GoBack();
        }

        private void toolStripButton_Forward_Click(object sender, EventArgs e)
        {
            webBrowser_Trailer.GoForward();
        }

        private void toolStripButton_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser_Trailer.Refresh();
        }

        private void toolStripButton_Home_Click(object sender, EventArgs e)
        {
            webBrowser_Trailer.GoHome();
        }

        private void toolStripButton_Go_Click(object sender, EventArgs e)
        {
            webBrowser_Trailer.Navigate(toolStripTextBox_Link.Text);
        }

        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            main.pnl_Menu();
            UCslide.Slide(main, this);
            this.Dispose();
            main.Controls.Remove(this);
        }
    }
}
