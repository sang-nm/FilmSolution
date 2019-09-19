using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Film.Class
{
    public partial class pnlMovieManagement : UserControl
    {
        frmMain main;
        DataSetFILM.TbPhimDataTable dsTbPhim;

        public pnlMovieManagement(frmMain form)
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
        }

        private void pnlMovieManagement_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            dsTbPhim = new DataSetFILM.TbPhimDataTable();
            DataAccess.dt = dsTbPhim;
            metroGrid_MM.DataSource = DataAccess.dataGetAll("SELECT * FROM TbPhim");
        }

        private void button_SaveMM_Click(object sender, EventArgs e)
        {
            DataAccess.dt = dsTbPhim;
            DataAccess.dataUpdate("TbPhim");
            MetroFramework.MetroMessageBox.Show(this, "Upload completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void metroGrid_MM_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = metroGrid_MM.HitTest(e.X, e.Y);
                metroGrid_MM.ClearSelection();
                if (hit.RowIndex >= 0 && hit.RowIndex < metroGrid_MM.RowCount)
                {
                    metroGrid_MM.Rows[hit.RowIndex].Selected = true;
                    metroContextMenu_MM.Show(metroGrid_MM, e.X, e.Y);
                }
            }
        }

        private void infomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.dt = new DataSetFILM.TbPhimDataTable();
            DataTable dtInfo = DataAccess.dataGetAll(
                string.Format("SELECT * from TbPhim where MaPhim= {0}", metroGrid_MM.SelectedRows[0].Cells[0].Value));
            byte[] InfoTb = (byte[])dtInfo.Rows[0][7];

            MemoryStream ms = new MemoryStream(InfoTb);
            Image ImageInfo = Image.FromStream(ms);

            pnlAddMovie MovieInfo = new pnlAddMovie(
                Convert.ToInt32(dtInfo.Rows[0][0]),
                dtInfo.Rows[0][1].ToString(),
                dtInfo.Rows[0][2].ToString(),
                dtInfo.Rows[0][3].ToString(),
                dtInfo.Rows[0][4].ToString(),
      (DateTime)dtInfo.Rows[0][5],
                dtInfo.Rows[0][6].ToString(),
                ImageInfo,
                main);
            main.Controls.Add(MovieInfo);
            MovieInfo.BringToFront();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM TbPhim WHERE MaPhim= " + metroGrid_MM.SelectedRows[0].Cells[0].Value;
                DataAccess.NonQuery(sql);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Data exist", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load();
        }

        private void pnlMovieManagement_Enter(object sender, EventArgs e)
        {
            load();
        }

        private void buttonX_Back_Click(object sender, EventArgs e)
        {
            main.pnl_Menu();
            UCslide.Slide(main,this);
            this.Dispose();
            main.Controls.Remove(this);
        }

        private void button_Addmovie_Click(object sender, EventArgs e)
        {
            pnlAddMovie pnlAM = new pnlAddMovie(main);
            main.Controls.Add(pnlAM);
            pnlAM.BringToFront();
        }
    }
}
