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
    public partial class pnlLooking : UserControl
    {
        frmMain main;
        pnlTicketBooking pnl;
        SQLFilmDataContext FilmDC = new SQLFilmDataContext();
        public bool dateLooking { get; set; } = false;

        public pnlLooking(pnlTicketBooking pnl)
        {
            InitializeComponent();
            main = pnl.main;
            this.pnl = pnl;
        }
        
        private void cbbMovie()
        {
            DataTable tbphim = new DataTable();
            DataAccess.dt = tbphim;
            tbphim = DataAccess.dataGetAll("SELECT MaPhim,TenPhim FROM TbPhim");
            DataRow row = tbphim.NewRow();
            row.ItemArray = new object[] { 0, "<----Select---->" };
            tbphim.Rows.InsertAt(row, 0);
            comboBox_Looking.DataSource = tbphim;
            comboBox_Looking.DisplayMember = "TenPhim";
            comboBox_Looking.ValueMember = "MaPhim";
            maPhimDataGridViewTextBoxColumn.DataSource = FilmDC.TbPhims;
        }

        private void pnlLooking_Load(object sender, EventArgs e)
        {
            cbbMovie();
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            Hide();
            main.Controls.Remove(this);
            Dispose();
            pnl.Enabled = true;
        }

        private void button_Looking_Click(object sender, EventArgs e)
        {
            var query =
                (from qllc in FilmDC.TbQuanLyLichChieus
                 join p in FilmDC.TbPhims
                 on qllc.MaPhim equals p.MaPhim
                 select new 
                 {
                     qllc.MaLichChieu,
                     p.MaPhim,
                     qllc.NgayChieu,
                     qllc.PhongChieu,
                     qllc.SuatChieu
                 }
                );
            if (comboBox_Looking.SelectedIndex > 0)
            {
                query = query.Where(p => p.MaPhim == (int)comboBox_Looking.SelectedValue);
            }
            if (dateLooking)
            {

                query = query.Where(qllc => qllc.NgayChieu == dateTimePicker_Looking.Value);
            }
            metroGrid_Looking.DataSource = query;
            dateLooking = false;
        }

        private void dateTimePicker_Looking_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_Looking.Value >= DateTime.Now)
            {
                dateLooking = true;
            }
            else
            {
                dateLooking = false;
            }
        }

        private void label_Looking_Click(object sender, EventArgs e)
        {
            dateLooking = false;
            dateTimePicker_Looking.Value = DateTime.Now;
        }

        private void dateTimePicker_Looking_Enter(object sender, EventArgs e)
        {
            dateLooking = true;
        }

        private void metroGrid_Looking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((DateTime)metroGrid_Looking.SelectedRows[0].Cells[2].Value >= DateTime.Now)
            {
                pnl.malichchieu = (int)metroGrid_Looking.SelectedRows[0].Cells["MaLichChieu"].Value;
                pnl.lb_movie = FilmDC.TbPhims.SingleOrDefault(p => p.MaPhim == (int)metroGrid_Looking.SelectedRows[0].Cells[1].Value).TenPhim;
                pnl.lb_redate = metroGrid_Looking.SelectedRows[0].Cells[2].Value.ToString();
                pnl.lb_showing = metroGrid_Looking.SelectedRows[0].Cells[3].Value.ToString();
                button_X.PerformClick();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Cannot select past date", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
