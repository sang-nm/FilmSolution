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
    public partial class pnlCoupon : UserControl
    {
        frmMain main;
        DataSetFILM.TbCouponDataTable dsCoupon;
        SQLFilmDataContext FilmDC = new SQLFilmDataContext();

        public pnlCoupon(frmMain form)
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

        public void load()
        {
            dsCoupon = new DataSetFILM.TbCouponDataTable();
            DataAccess.dt = dsCoupon;
            dataGridViewX_CM.DataSource = DataAccess.dataGetAll("SELECT * FROM TbCoupon");
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

        private void buttonX_Back_Click(object sender, EventArgs e)
        {
            main.pnl_Menu();
            UCslide.Slide(main, this);
            this.Dispose();
            main.Controls.Remove(this);
        }

        private void buttonX_Insert_Click(object sender, EventArgs e)
        {
            TbCoupon voucher = new TbCoupon
            {
                MaCoupon = randomCode(),
                Member = null,
                Voucher = 15000
            };

            FilmDC.TbCoupons.InsertOnSubmit(voucher);
            FilmDC.SubmitChanges();
            load();
        }

        private void buttonX_Save_Click(object sender, EventArgs e)
        {
            DataAccess.dt = dsCoupon;
            DataAccess.dataUpdate("TbMember");
            MetroFramework.MetroMessageBox.Show(this, "Update completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql1 = "DELETE FROM TbCoupon WHERE MaCoupon = '" + dataGridViewX_CM.SelectedRows[0].Cells[0].Value.ToString() + "'";
            DataAccess.NonQuery(sql1);
            load();
        }

        private void dataGridViewX_CM_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewX_CM.HitTest(e.X, e.Y);
                dataGridViewX_CM.ClearSelection();
                if (hit.RowIndex >= 0 && hit.RowIndex < dataGridViewX_CM.RowCount)
                {
                    dataGridViewX_CM.Rows[hit.RowIndex].Selected = true;
                    metroContextMenu_MM.Show(dataGridViewX_CM, e.X, e.Y);
                }
            }
        }

        private void pnlCoupon_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
