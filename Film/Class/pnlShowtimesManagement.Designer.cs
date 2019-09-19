namespace Film.Class
{
    partial class pnlShowtimesManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Full");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Datetime");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Movies", 1, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlShowtimesManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView_SM = new System.Windows.Forms.TreeView();
            this.imageList_treeview = new System.Windows.Forms.ImageList(this.components);
            this.button_Add = new System.Windows.Forms.Button();
            this.panel_Treeview = new System.Windows.Forms.Panel();
            this.buttonX_Treeview = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX_Back = new DevComponents.DotNetBar.ButtonX();
            this.metroContextMenu_SM = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroGrid_SM = new MetroFramework.Controls.MetroGrid();
            this.MaLichChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbPhimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFILM = new Film.DataSetFILM();
            this.ngayChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suatChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbQuanLyLichChieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Movie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Room = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Showing = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_ReDate = new System.Windows.Forms.DateTimePicker();
            this.tbQuanLyLichChieuTableAdapter = new Film.DataSetFILMTableAdapters.TbQuanLyLichChieuTableAdapter();
            this.tbPhimTableAdapter = new Film.DataSetFILMTableAdapters.TbPhimTableAdapter();
            this.panel_Treeview.SuspendLayout();
            this.metroContextMenu_SM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_SM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuanLyLichChieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_SM
            // 
            this.treeView_SM.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_SM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_SM.ImageIndex = 0;
            this.treeView_SM.ImageList = this.imageList_treeview;
            this.treeView_SM.Location = new System.Drawing.Point(0, 0);
            this.treeView_SM.Name = "treeView_SM";
            treeNode1.ImageKey = "appbar.social.github.octocat.png";
            treeNode1.Name = "Root";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Full";
            treeNode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            treeNode2.ForeColor = System.Drawing.Color.Black;
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "NodeDate";
            treeNode2.SelectedImageKey = "appbar.calendar.31.png";
            treeNode2.Text = "Datetime";
            treeNode3.BackColor = System.Drawing.Color.Yellow;
            treeNode3.ForeColor = System.Drawing.Color.Black;
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "NodeMovie";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Movies";
            this.treeView_SM.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView_SM.SelectedImageIndex = 0;
            this.treeView_SM.Size = new System.Drawing.Size(212, 370);
            this.treeView_SM.TabIndex = 3;
            this.treeView_SM.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_SM_AfterSelect);
            // 
            // imageList_treeview
            // 
            this.imageList_treeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_treeview.ImageStream")));
            this.imageList_treeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_treeview.Images.SetKeyName(0, "");
            this.imageList_treeview.Images.SetKeyName(1, "");
            this.imageList_treeview.Images.SetKeyName(2, "");
            this.imageList_treeview.Images.SetKeyName(3, "");
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(532, 551);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(125, 49);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Confirm";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // panel_Treeview
            // 
            this.panel_Treeview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Treeview.BackColor = System.Drawing.Color.Transparent;
            this.panel_Treeview.Controls.Add(this.treeView_SM);
            this.panel_Treeview.Controls.Add(this.buttonX_Treeview);
            this.panel_Treeview.Location = new System.Drawing.Point(0, 124);
            this.panel_Treeview.Name = "panel_Treeview";
            this.panel_Treeview.Size = new System.Drawing.Size(234, 370);
            this.panel_Treeview.TabIndex = 6;
            // 
            // buttonX_Treeview
            // 
            this.buttonX_Treeview.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Treeview.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX_Treeview.FocusCuesEnabled = false;
            this.buttonX_Treeview.Image = ((System.Drawing.Image)(resources.GetObject("buttonX_Treeview.Image")));
            this.buttonX_Treeview.Location = new System.Drawing.Point(204, 170);
            this.buttonX_Treeview.Name = "buttonX_Treeview";
            this.buttonX_Treeview.Size = new System.Drawing.Size(30, 30);
            this.buttonX_Treeview.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Treeview.TabIndex = 7;
            this.buttonX_Treeview.Click += new System.EventHandler(this.buttonX_Treeview_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(385, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Showtimes Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonX_Back
            // 
            this.buttonX_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Back.BackColor = System.Drawing.Color.Transparent;
            this.buttonX_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Back.FocusCuesEnabled = false;
            this.buttonX_Back.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Back.Location = new System.Drawing.Point(30, 30);
            this.buttonX_Back.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX_Back.Name = "buttonX_Back";
            this.buttonX_Back.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX_Back.Size = new System.Drawing.Size(40, 40);
            this.buttonX_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX_Back.Symbol = "";
            this.buttonX_Back.SymbolColor = System.Drawing.Color.Red;
            this.buttonX_Back.TabIndex = 21;
            this.buttonX_Back.Click += new System.EventHandler(this.buttonX_Back_Click);
            // 
            // metroContextMenu_SM
            // 
            this.metroContextMenu_SM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.metroContextMenu_SM.Name = "metroContextMenu_SM";
            this.metroContextMenu_SM.Size = new System.Drawing.Size(115, 26);
            this.metroContextMenu_SM.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroContextMenu_SM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroContextMenu_SM.UseStyleColors = true;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // metroGrid_SM
            // 
            this.metroGrid_SM.AllowUserToAddRows = false;
            this.metroGrid_SM.AllowUserToResizeRows = false;
            this.metroGrid_SM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid_SM.AutoGenerateColumns = false;
            this.metroGrid_SM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_SM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.metroGrid_SM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_SM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_SM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_SM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_SM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_SM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichChieu,
            this.maPhimDataGridViewTextBoxColumn,
            this.ngayChieuDataGridViewTextBoxColumn,
            this.phongChieuDataGridViewTextBoxColumn,
            this.suatChieuDataGridViewTextBoxColumn});
            this.metroGrid_SM.DataSource = this.tbQuanLyLichChieuBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_SM.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_SM.EnableHeadersVisualStyles = false;
            this.metroGrid_SM.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_SM.GridColor = System.Drawing.Color.Black;
            this.metroGrid_SM.Location = new System.Drawing.Point(236, 222);
            this.metroGrid_SM.Name = "metroGrid_SM";
            this.metroGrid_SM.ReadOnly = true;
            this.metroGrid_SM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_SM.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_SM.RowHeadersVisible = false;
            this.metroGrid_SM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_SM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_SM.Size = new System.Drawing.Size(717, 272);
            this.metroGrid_SM.TabIndex = 23;
            this.metroGrid_SM.UseCustomBackColor = true;
            this.metroGrid_SM.UseCustomForeColor = true;
            this.metroGrid_SM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_SM_MouseDown);
            // 
            // MaLichChieu
            // 
            this.MaLichChieu.DataPropertyName = "MaLichChieu";
            this.MaLichChieu.FillWeight = 31.49873F;
            this.MaLichChieu.HeaderText = "ID";
            this.MaLichChieu.Name = "MaLichChieu";
            this.MaLichChieu.ReadOnly = true;
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.DataSource = this.tbPhimBindingSource;
            this.maPhimDataGridViewTextBoxColumn.DisplayMember = "TenPhim";
            this.maPhimDataGridViewTextBoxColumn.FillWeight = 180.4127F;
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "Movie";
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            this.maPhimDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPhimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maPhimDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.maPhimDataGridViewTextBoxColumn.ValueMember = "MaPhim";
            // 
            // tbPhimBindingSource
            // 
            this.tbPhimBindingSource.DataMember = "TbPhim";
            this.tbPhimBindingSource.DataSource = this.dataSetFILM;
            // 
            // dataSetFILM
            // 
            this.dataSetFILM.DataSetName = "DataSetFILM";
            this.dataSetFILM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ngayChieuDataGridViewTextBoxColumn
            // 
            this.ngayChieuDataGridViewTextBoxColumn.DataPropertyName = "NgayChieu";
            this.ngayChieuDataGridViewTextBoxColumn.FillWeight = 135.3079F;
            this.ngayChieuDataGridViewTextBoxColumn.HeaderText = "ReDate";
            this.ngayChieuDataGridViewTextBoxColumn.Name = "ngayChieuDataGridViewTextBoxColumn";
            this.ngayChieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phongChieuDataGridViewTextBoxColumn
            // 
            this.phongChieuDataGridViewTextBoxColumn.DataPropertyName = "PhongChieu";
            this.phongChieuDataGridViewTextBoxColumn.FillWeight = 76.63853F;
            this.phongChieuDataGridViewTextBoxColumn.HeaderText = "Room";
            this.phongChieuDataGridViewTextBoxColumn.Name = "phongChieuDataGridViewTextBoxColumn";
            this.phongChieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suatChieuDataGridViewTextBoxColumn
            // 
            this.suatChieuDataGridViewTextBoxColumn.DataPropertyName = "SuatChieu";
            this.suatChieuDataGridViewTextBoxColumn.FillWeight = 76.14214F;
            this.suatChieuDataGridViewTextBoxColumn.HeaderText = "Showings";
            this.suatChieuDataGridViewTextBoxColumn.Name = "suatChieuDataGridViewTextBoxColumn";
            this.suatChieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbQuanLyLichChieuBindingSource
            // 
            this.tbQuanLyLichChieuBindingSource.DataMember = "TbQuanLyLichChieu";
            this.tbQuanLyLichChieuBindingSource.DataSource = this.dataSetFILM;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Movie";
            // 
            // comboBox_Movie
            // 
            this.comboBox_Movie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Movie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Movie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Movie.FormattingEnabled = true;
            this.comboBox_Movie.Location = new System.Drawing.Point(370, 124);
            this.comboBox_Movie.Name = "comboBox_Movie";
            this.comboBox_Movie.Size = new System.Drawing.Size(246, 26);
            this.comboBox_Movie.TabIndex = 25;
            this.comboBox_Movie.SelectedIndexChanged += new System.EventHandler(this.comboBox_Movie_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Room";
            // 
            // comboBox_Room
            // 
            this.comboBox_Room.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Room.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Room.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Room.Enabled = false;
            this.comboBox_Room.FormattingEnabled = true;
            this.comboBox_Room.Location = new System.Drawing.Point(793, 124);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(121, 26);
            this.comboBox_Room.TabIndex = 25;
            this.comboBox_Room.SelectedIndexChanged += new System.EventHandler(this.comboBox_Room_SelectedIndexChanged);
            this.comboBox_Room.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Room_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Showing";
            // 
            // comboBox_Showing
            // 
            this.comboBox_Showing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Showing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Showing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Showing.Enabled = false;
            this.comboBox_Showing.FormattingEnabled = true;
            this.comboBox_Showing.Location = new System.Drawing.Point(793, 167);
            this.comboBox_Showing.Name = "comboBox_Showing";
            this.comboBox_Showing.Size = new System.Drawing.Size(121, 26);
            this.comboBox_Showing.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "ReDate";
            // 
            // dateTimePicker_ReDate
            // 
            this.dateTimePicker_ReDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_ReDate.Enabled = false;
            this.dateTimePicker_ReDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ReDate.Location = new System.Drawing.Point(370, 164);
            this.dateTimePicker_ReDate.Name = "dateTimePicker_ReDate";
            this.dateTimePicker_ReDate.Size = new System.Drawing.Size(246, 26);
            this.dateTimePicker_ReDate.TabIndex = 26;
            this.dateTimePicker_ReDate.ValueChanged += new System.EventHandler(this.dateTimePicker_ReDate_ValueChanged);
            // 
            // tbQuanLyLichChieuTableAdapter
            // 
            this.tbQuanLyLichChieuTableAdapter.ClearBeforeFill = true;
            // 
            // tbPhimTableAdapter
            // 
            this.tbPhimTableAdapter.ClearBeforeFill = true;
            // 
            // pnlShowtimesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Treeview);
            this.Controls.Add(this.dateTimePicker_ReDate);
            this.Controls.Add(this.comboBox_Showing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Movie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonX_Back);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroGrid_SM);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(870, 517);
            this.Name = "pnlShowtimesManagement";
            this.Size = new System.Drawing.Size(1188, 619);
            this.Load += new System.EventHandler(this.pnlShowtimesManagement_Load);
            this.panel_Treeview.ResumeLayout(false);
            this.metroContextMenu_SM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_SM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuanLyLichChieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView_SM;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Panel panel_Treeview;
        private DevComponents.DotNetBar.ButtonX buttonX_Treeview;
        private DevComponents.DotNetBar.ButtonX buttonX_Back;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu_SM;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid metroGrid_SM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Movie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Showing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ReDate;
        private System.Windows.Forms.BindingSource tbQuanLyLichChieuBindingSource;
        private DataSetFILM dataSetFILM;
        private DataSetFILMTableAdapters.TbQuanLyLichChieuTableAdapter tbQuanLyLichChieuTableAdapter;
        private System.Windows.Forms.BindingSource tbPhimBindingSource;
        private DataSetFILMTableAdapters.TbPhimTableAdapter tbPhimTableAdapter;
        private System.Windows.Forms.ImageList imageList_treeview;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichChieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suatChieuDataGridViewTextBoxColumn;
    }
}
