using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Film.Class
{
    public partial class pnlShowtimesManagement : UserControl
    {
        frmMain main;
        #region tumlum
        public int ShowtimesID { get; set; } = 0;
        public int MovieID { get; set; }
        public DateTime ReDate { get; set; }
        public string[] Room = new string[] { "R1", "R2", "R3" };
        private string ReSource;
        // -212, 124 location panel treeview
        #endregion

        public pnlShowtimesManagement(frmMain form)
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

        private void load()
        {
            DataSetFILM.TbQuanLyLichChieuDataTable dsQLLC = new DataSetFILM.TbQuanLyLichChieuDataTable();
            DataAccess.dt = dsQLLC;
            ReSource = "SELECT * FROM TbQuanLyLichChieu ORDER BY MaLichChieu ASC";
            DataAccess_source();
        }

        private void DataAccess_source()
        {
            metroGrid_SM.DataSource = DataAccess.dataGetAll(ReSource);
        }

        private void TreeViewSM()
        {
            DataTable tb = new DataTable();
            DataAccess.dt = tb;
            tb = DataAccess.dataGetAll("SELECT DISTINCT NgayChieu FROM TbQuanLyLichChieu ORDER BY NgayChieu ASC");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                DateTime temp = (DateTime)tb.Rows[i]["NgayChieu"];
                TreeNode childnode_date;
                if (!treeView_SM.Nodes["NodeDate"].Nodes.ContainsKey(temp.Date.ToString("dd/MM/yyyy")))
                {
                    childnode_date = new TreeNode()
                    {
                        Text = temp.Date.ToString("dd/MM/yyyy"),
                        Name = temp.Date.ToString("dd/MM/yyyy"),
                        Tag = temp
                    };

                    childnode_date.SelectedImageIndex = 1;
                    treeView_SM.Nodes["NodeDate"].Nodes.Add(childnode_date);
                }
            }
            tb = new DataTable();
            DataAccess.dt = tb;
            tb = DataAccess.dataGetAll("SELECT DISTINCT b.TenPhim FROM TbQuanLyLichChieu AS a JOIN TbPhim AS b ON a.MaPhim = b.MaPhim ORDER BY b.TenPhim ASC");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                TreeNode childnode_Movie;
                if (!treeView_SM.Nodes["NodeMovie"].Nodes.ContainsKey(tb.Rows[i]["TenPhim"].ToString()))
                {
                    childnode_Movie = new TreeNode()
                    {
                        Text = tb.Rows[i]["TenPhim"].ToString(),
                        Name = tb.Rows[i]["TenPhim"].ToString(),
                    };
                    childnode_Movie.SelectedImageIndex = 2;
                    treeView_SM.Nodes["NodeMovie"].Nodes.Add(childnode_Movie);
                }
            }
        }

        private void getlistroom()
        {
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "Room";
            dt.Columns.Add(col);
            DataRow rowD = dt.NewRow();
            rowD.ItemArray = new object[] { "<----Select---->" };
            dt.Rows.InsertAt(rowD, 0);
            foreach (string room in Room)
            {
                DataTable tb1 = new DataTable();
                DataAccess.dt = tb1;
                tb1 = DataAccess.dataGetAll(string.Format("SELECT * FROM TbQuanLyLichChieu WHERE NgayChieu = '{0}' and PhongChieu = '{1}'",
                  dateTimePicker_ReDate.Value, room));

                string suatchieu = DataAccess.getvalue(string.Format("SELECT SuatChieu FROM TbRoom WHERE PhongChieu = '{0}'", room));
                string[] suatchieuRoom = suatchieu.Split(',');

                rowD = dt.NewRow();
                rowD.ItemArray = new object[] { room };
                dt.Rows.Add(rowD);
            }
            comboBox_Room.DataSource = null;
            comboBox_Room.DataSource = dt;
            comboBox_Room.DisplayMember = "Room";
            comboBox_Room.ValueMember = "Room";
        }

        private void getlistshowing()
        {
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn();
            col.DataType = Type.GetType("System.String");
            col.ColumnName = "Showing";
            dt.Columns.Add(col);
            DataRow rowD = dt.NewRow();
            rowD.ItemArray = new object[] { "<----Select---->" };
            dt.Rows.InsertAt(rowD, 0);
            DataTable tb1 = DataAccess.dataGetAll(string.Format("SELECT * FROM TbQuanLyLichChieu WHERE NgayChieu = '{0}' and PhongChieu = '{1}'",
                dateTimePicker_ReDate.Value, comboBox_Room.SelectedValue.ToString()));
            string suatchieu = DataAccess.getvalue(string.Format("SELECT SuatChieu FROM TbRoom WHERE PhongChieu = '{0}'", comboBox_Room.SelectedValue.ToString()));
            string[] suatchieuRoom = suatchieu.Split(',');
            //suatchieuRoom = tb2.AsEnumerable().Select(r => r.Field<string>("SuatChieu")).ToArray();

            List<string> suatchieuQLLC = getlistshowing(tb1, suatchieuRoom);
            if (suatchieuQLLC.Count > 0)
            {
                foreach (string item in suatchieuQLLC)
                {
                    rowD = dt.NewRow();
                    rowD.ItemArray = new object[] { item };
                    dt.Rows.Add(rowD);
                }
            }
            comboBox_Showing.DataSource = null;
            comboBox_Showing.DataSource = dt;
            comboBox_Showing.DisplayMember = "Showing";
            comboBox_Showing.ValueMember = "Showing";
        }

        private List<string> getlistshowing(DataTable table, string[] array)
        {
            List<string> list = new List<string>();
            string[] rowtb = table.AsEnumerable().Select(r => r.Field<string>("SuatChieu")).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (!rowtb.Contains(array[i]))
                {
                    list.Add(array[i]);
                }
            }
            return list;
        }

        private bool validate()
        {
            if (comboBox_Movie.SelectedIndex == 0)
            {
                return false;
            }
            else if (comboBox_Room.SelectedIndex == 0)
            {
                return false;
            }
            else if (comboBox_Showing.SelectedIndex == 0 && ShowtimesID == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonX_Treeview_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(buttonX_Treeview.Image);
            Bitmap bmp1 = new Bitmap(Properties.Resources.appbar_chevron_left);
            Bitmap bmp2 = new Bitmap(Properties.Resources.appbar_chevron_right);
            if (ClassImage.CompareBitmapsFast(bmp, bmp1))
            {
                while (panel_Treeview.Right > 23)
                {
                    panel_Treeview.Location = new Point(panel_Treeview.Left - 2, panel_Treeview.Top);
                }
                buttonX_Treeview.Image = Properties.Resources.appbar_chevron_right;
            }
            else if (ClassImage.CompareBitmapsFast(bmp, bmp2))
            {
                while (panel_Treeview.Right < 234)
                {
                    panel_Treeview.Location = new Point(panel_Treeview.Left + 2, panel_Treeview.Top);
                }
                buttonX_Treeview.Image = Properties.Resources.appbar_chevron_left;
            }
        }

        private void buttonX_Back_Click(object sender, EventArgs e)
        {
            main.pnl_Menu();
            UCslide.Slide(main, this);
            this.Dispose();
            main.Controls.Remove(this);
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Input error");
                return;
            }
            else
            {
                try
                {
                    if (ShowtimesID == 0)
                    {
                        DataAccess.NonQuery(string.Format("INSERT TbQuanLyLichChieu VALUES({0},'{1}','{2}','{3}')",
                           comboBox_Movie.SelectedValue.ToString(), dateTimePicker_ReDate.Value, comboBox_Room.SelectedValue.ToString(), comboBox_Showing.SelectedValue.ToString()));
                        MetroFramework.MetroMessageBox.Show(this, "Insert completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        comboBox_Movie.SelectedIndex = 0;
                        DataAccess.dt = new DataSetFILM.TbQuanLyLichChieuDataTable();
                        if (ReSource == null)
                        {
                            ReSource = "SELECT * FROM TbQuanLyLichChieu ORDER BY MaLichChieu ASC";
                        }
                        DataAccess_source();
                        TreeViewSM();
                        //load();
                    }
                    else
                    {
                        DataAccess.NonQuery(string.Format("UPDATE TbQuanLyLichChieu SET MaPhim = {0}, NgayChieu = '{1}', PhongChieu = '{2}', SuatChieu = '{3}' WHERE MaLichChieu = {4}",
                            comboBox_Movie.SelectedValue.ToString(), dateTimePicker_ReDate.Value.ToString("yyyy-MM-dd"), comboBox_Room.SelectedValue.ToString(), comboBox_Showing.Text, ShowtimesID));
                        MetroFramework.MetroMessageBox.Show(this, "Update completed", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        comboBox_Movie.SelectedIndex = 0;
                        ShowtimesID = 0;
                        DataAccess.dt = new DataSetFILM.TbQuanLyLichChieuDataTable();
                        DataAccess_source();
                        //load();
                    }
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input error", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.NonQuery(string.Format("DELETE FROM TbQuanLyLichChieu WHERE MaLichChieu = {0}", ShowtimesID));
            ShowtimesID = 0;
            DataAccess.dt = new DataSetFILM.TbQuanLyLichChieuDataTable();
            DataAccess_source();
            foreach (TreeNode node0 in treeView_SM.Nodes)
            {
                node0.Nodes.Clear();
            }
            TreeViewSM();
        }

        private void pnlShowtimesManagement_Load(object sender, EventArgs e)
        {
            DataSetFILM.TbPhimDataTable dsPhim = new DataSetFILM.TbPhimDataTable();
            DataAccess.dt = dsPhim;
            maPhimDataGridViewTextBoxColumn.DataSource = DataAccess.dataGetAll("SELECT * FROM TbPhim ORDER BY TenPhim ASC");

            DataTable cbbPhim = new DataTable();
            DataAccess.dt = cbbPhim;
            cbbPhim = DataAccess.dataGetAll("SELECT * FROM TbPhim ORDER BY TenPhim ASC");
            DataRow row = cbbPhim.NewRow();
            row.ItemArray = new object[] { 0, "<----Select---->" };
            cbbPhim.Rows.InsertAt(row, 0);
            comboBox_Movie.DataSource = cbbPhim;
            comboBox_Movie.DisplayMember = "TenPhim";
            comboBox_Movie.ValueMember = "MaPhim";
            //load();
            TreeViewSM();
            buttonX_Treeview.PerformClick();
        }

        private void dataGridView_SM_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = metroGrid_SM.HitTest(e.X, e.Y);
                metroGrid_SM.ClearSelection();
                if (hit.RowIndex >= 0 && hit.RowIndex < metroGrid_SM.RowCount)
                {
                    metroGrid_SM.Rows[hit.RowIndex].Selected = true;
                    ShowtimesID = (int)metroGrid_SM.SelectedRows[0].Cells[0].Value;
                    metroContextMenu_SM.Show(metroGrid_SM, e.X, e.Y);
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                var hit = metroGrid_SM.HitTest(e.X, e.Y);
                metroGrid_SM.ClearSelection();
                if (hit.RowIndex >= 0 && hit.RowIndex < metroGrid_SM.RowCount)
                {
                    metroGrid_SM.Rows[hit.RowIndex].Selected = true;
                    ShowtimesID = (int)metroGrid_SM.SelectedRows[0].Cells[0].Value;
                    comboBox_Movie.SelectedValue = metroGrid_SM.SelectedRows[0].Cells[1].Value;
                    dateTimePicker_ReDate.Value = (DateTime)metroGrid_SM.SelectedRows[0].Cells[2].Value;
                    comboBox_Room.SelectedValue = metroGrid_SM.SelectedRows[0].Cells[3].Value;
                    comboBox_Showing.Text = metroGrid_SM.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
        }

        private void comboBox_Movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Movie.SelectedIndex != 0)
            {
                dateTimePicker_ReDate.Enabled = true;
            }
            else
            {
                dateTimePicker_ReDate.Enabled = false;
                ShowtimesID = 0;
                dateTimePicker_ReDate.Value = DateTime.Now;
            }
        }

        private void dateTimePicker_ReDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_ReDate.Value.Date <= DateTime.Now.Date)
            {
                comboBox_Room.Enabled = false;
                comboBox_Room.DataSource = null;
            }
            else
            {
                comboBox_Room.Enabled = true;
                getlistroom();
                comboBox_Room.SelectedIndex = 0;
            }
        }

        private void comboBox_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Room.SelectedIndex != 0 && comboBox_Room.DataSource != null)
            {
                comboBox_Showing.Enabled = true;
                getlistshowing();
                comboBox_Showing.SelectedIndex = 0;
            }
            else
            {
                comboBox_Showing.Enabled = false;
                comboBox_Showing.DataSource = null;
            }
        }

        private void comboBox_Room_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_Room.SelectedIndex != 0 && comboBox_Room.DataSource != null)
            {
                comboBox_Showing.Enabled = true;
                getlistshowing();
                comboBox_Showing.SelectedIndex = 0;
            }
            else
            {
                comboBox_Showing.Enabled = false;
                comboBox_Showing.DataSource = null;
            }
        }

        private void treeView_SM_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView_SM.Nodes["Root"] == treeView_SM.SelectedNode)
            {
                load();
            }
            DataSetFILM.TbQuanLyLichChieuDataTable dsQLLC = new DataSetFILM.TbQuanLyLichChieuDataTable();
            DataAccess.dt = dsQLLC;
            if (treeView_SM.Nodes["NodeDate"] == treeView_SM.SelectedNode.Parent)
            {
                DateTime temp = Convert.ToDateTime(treeView_SM.SelectedNode.Tag);
                ReSource = string.Format("SELECT * FROM TbQuanLyLichChieu WHERE NgayChieu = '{0}'", temp.ToString("yyyy-MM-dd"));
                DataAccess_source();
            }
            if (treeView_SM.Nodes["NodeMovie"] == treeView_SM.SelectedNode.Parent)
            {
                ReSource = string.Format("SELECT a.* FROM TbQuanLyLichChieu AS a JOIN TbPhim AS b ON a.MaPhim = b.MaPhim WHERE b.TenPhim = N'{0}'", treeView_SM.SelectedNode.Text);
                DataAccess_source();
            }
        }
    }
}
