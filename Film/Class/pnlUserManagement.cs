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

namespace Film.Class
{
    public partial class pnlUserManagement : UserControl
    {
        frmMain main;
        DataSetFILM.TbQuanLyNhanSuDataTable dsQLNS;

        public pnlUserManagement(frmMain form)
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

        private void pnlUserManagement_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            dsQLNS = new DataSetFILM.TbQuanLyNhanSuDataTable();
            DataAccess.dt = dsQLNS;
            dataGridViewX_UM.DataSource = DataAccess.dataGetAll("SELECT * FROM TbQuanLyNhanSu ORDER BY PhanQuyen ASC");
        }

        private void buttonX_Register_Click(object sender, EventArgs e)
        {
            frmRegister callRegister = new frmRegister();
            callRegister.ShowDialog();
            load();
        }

        private void buttonX_Save_Click(object sender, EventArgs e)
        {
            DataAccess.dt = dsQLNS;
            DataAccess.dataUpdate("TbQuanLyNhanSu");
            MetroFramework.MetroMessageBox.Show(this, "Update completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void dataGridViewX_UM_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewX_UM.HitTest(e.X, e.Y);
                dataGridViewX_UM.ClearSelection();
                if (hit.RowIndex >= 0 && hit.RowIndex < dataGridViewX_UM.RowCount)
                {
                    dataGridViewX_UM.Rows[hit.RowIndex].Selected = true;
                    metroContextMenu_UM.Show(dataGridViewX_UM, e.X, e.Y);
                }
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.dt = new DataSetFILM.ThongTinCaNhanDataTable();
            DataTable dtProf = DataAccess.dataGetAll(
                string.Format("SELECT * from ThongTinCaNhan where TenDangNhap='{0}'", dataGridViewX_UM.SelectedRows[0].Cells[0].Value.ToString()));
            byte[] profileTb = (byte[])dtProf.Rows[0][7];

            MemoryStream ms = new MemoryStream(profileTb);
            Image ImageProf = Image.FromStream(ms);

            frmProfile ProfUser = new frmProfile(
                dtProf.Rows[0][1].ToString(),
                (DateTime)dtProf.Rows[0][2],
                dtProf.Rows[0][3].ToString(),
                Convert.ToInt32(dtProf.Rows[0][4]),
                Convert.ToInt32(dtProf.Rows[0][5]),
                dtProf.Rows[0][6].ToString(),
                ImageProf);
            ProfUser.TDN = dtProf.Rows[0][0].ToString();
            ProfUser.StartPosition = FormStartPosition.CenterScreen;
            ProfUser.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM TbQuanLyNhanSu WHERE TenDangNhap=N'" + dataGridViewX_UM.SelectedRows[0].Cells[0].Value.ToString() + "'";
            DataAccess.NonQuery(sql);
            load();
        }

        private void buttonX_Exit_Click(object sender, EventArgs e)
        {
            main.pnl_Menu();
            UCslide.Slide(main, this);
            this.Dispose();
            main.Controls.Remove(this);
        }
    }
}
