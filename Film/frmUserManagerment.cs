using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film
{
    public partial class frmUserManagerment : Form
    {
        DataSetFILM.QuanLyNhanSuDataTable dsQLNS;
        public frmUserManagerment()
        {
            InitializeComponent();
        }

        private void frmUserManagerment_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            dsQLNS = new DataSetFILM.QuanLyNhanSuDataTable();
            DataAccess.dt = dsQLNS;
            dataGridViewUser.DataSource = DataAccess.dataGetAll("SELECT * FROM QuanLyNhanSu ORDER BY PhanQuyen ASC");
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            DataAccess.dt = dsQLNS;
            DataAccess.dataUpdate();
            MessageBox.Show("Lưu thành công!", "Thông Báo");
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDangky_Click(object sender, EventArgs e)
        {
            frmRegister callRegister = new frmRegister();
            callRegister.Show();
            load();
        }

        private void dataGridViewUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewUser.HitTest(e.X, e.Y);
                dataGridViewUser.ClearSelection();
                if (hit.RowIndex >= 0 && hit.RowIndex < dataGridViewUser.RowCount)
                {
                    dataGridViewUser.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip_UM.Show(dataGridViewUser, e.X, e.Y);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.dt = new DataSetFILM.ThongTinCaNhanDataTable();
            DataTable dtProf = DataAccess.dataGetAll(
                string.Format("SELECT * from ThongTinCaNhan where TenDangNhap='{0}'", dataGridViewUser.SelectedRows[0].Cells[0].Value.ToString()));
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
            string sql = "DELETE FROM QuanLyNhanSu WHERE TenDangNhap=N'" + dataGridViewUser.SelectedRows[0].Cells[0].Value.ToString() + "'";
            DataAccess.NonQuery(sql);
            load();
        }
    }
}
