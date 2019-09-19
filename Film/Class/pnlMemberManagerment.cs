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
    public partial class pnlMemberManagerment : UserControl
    {
        public frmMain main;
        DataSetFILM.TbMemberDataTable dsMem;

        public pnlMemberManagerment(frmMain form)
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

        private void pnlMemberManagerment_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            dsMem = new DataSetFILM.TbMemberDataTable();
            DataAccess.dt = dsMem;
            dataGridViewX_MM.DataSource = DataAccess.dataGetAll("SELECT * FROM TbMember");
        }

        private void buttonX_Save_Click(object sender, EventArgs e)
        {
            DataAccess.dt = dsMem;
            DataAccess.dataUpdate("TbMember");
            MetroFramework.MetroMessageBox.Show(this, "Update completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void dataGridViewX_UM_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewX_MM.HitTest(e.X, e.Y);
                dataGridViewX_MM.ClearSelection();
                if (hit.RowIndex >= 0 && hit.RowIndex < dataGridViewX_MM.RowCount)
                {
                    dataGridViewX_MM.Rows[hit.RowIndex].Selected = true;
                    metroContextMenu_MM.Show(dataGridViewX_MM, e.X, e.Y);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM TbMember WHERE MaThanhVien = '" + dataGridViewX_MM.SelectedRows[0].Cells[0].Value.ToString() + "'";
            DataAccess.NonQuery(sql);
            string sql1 = "DELETE FROM TbCoupon WHERE MaCoupon = '" + dataGridViewX_MM.SelectedRows[0].Cells[5].Value.ToString() + "'";
            DataAccess.NonQuery(sql1);
            load();
        }

        private void buttonX_Exit_Click(object sender, EventArgs e)
        {
            main.pnl_Menu();
            UCslide.Slide(main, this);
            this.Dispose();
            main.Controls.Remove(this);
        }

        private void buttonX_MRegister_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            pnlMemberReg MReg = new pnlMemberReg(this);
            MReg.Location = new Point(main.ClientSize.Width / 2 - MReg.Size.Width / 2, main.ClientSize.Height / 2 - MReg.Size.Height / 2);
            main.Controls.Add(MReg);
            MReg.BackColor = SystemColors.Control;

            MReg.BringToFront();
            MReg.Focus();
        }
    }
}
