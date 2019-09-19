namespace Film.Class
{
    partial class pnlMovieManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlMovieManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_SaveMM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroGrid_MM = new MetroFramework.Controls.MetroGrid();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daoDienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhoiChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgPhimDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbPhimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFILM = new Film.DataSetFILM();
            this.button_Addmovie = new System.Windows.Forms.Button();
            this.metroContextMenu_MM = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.infomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPhimTableAdapter = new Film.DataSetFILMTableAdapters.TbPhimTableAdapter();
            this.buttonX_Back = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).BeginInit();
            this.metroContextMenu_MM.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_SaveMM
            // 
            this.button_SaveMM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_SaveMM.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_SaveMM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button_SaveMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveMM.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveMM.Location = new System.Drawing.Point(620, 518);
            this.button_SaveMM.Name = "button_SaveMM";
            this.button_SaveMM.Size = new System.Drawing.Size(118, 39);
            this.button_SaveMM.TabIndex = 1;
            this.button_SaveMM.Text = "Save";
            this.button_SaveMM.UseVisualStyleBackColor = false;
            this.button_SaveMM.Click += new System.EventHandler(this.button_SaveMM_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(386, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movie Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroGrid_MM
            // 
            this.metroGrid_MM.AllowUserToAddRows = false;
            this.metroGrid_MM.AllowUserToResizeRows = false;
            this.metroGrid_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid_MM.AutoGenerateColumns = false;
            this.metroGrid_MM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_MM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_MM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_MM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_MM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_MM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_MM.ColumnHeadersHeight = 25;
            this.metroGrid_MM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.metroGrid_MM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhimDataGridViewTextBoxColumn,
            this.tenPhimDataGridViewTextBoxColumn,
            this.theLoaiDataGridViewTextBoxColumn,
            this.daoDienDataGridViewTextBoxColumn,
            this.dienVienDataGridViewTextBoxColumn,
            this.ngayKhoiChieuDataGridViewTextBoxColumn,
            this.moTaPhimDataGridViewTextBoxColumn,
            this.imgPhimDataGridViewImageColumn});
            this.metroGrid_MM.DataSource = this.tbPhimBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_MM.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_MM.EnableHeadersVisualStyles = false;
            this.metroGrid_MM.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_MM.GridColor = System.Drawing.Color.Black;
            this.metroGrid_MM.Location = new System.Drawing.Point(112, 151);
            this.metroGrid_MM.Name = "metroGrid_MM";
            this.metroGrid_MM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_MM.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid_MM.RowHeadersVisible = false;
            this.metroGrid_MM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_MM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_MM.Size = new System.Drawing.Size(904, 282);
            this.metroGrid_MM.TabIndex = 3;
            this.metroGrid_MM.UseCustomBackColor = true;
            this.metroGrid_MM.UseCustomForeColor = true;
            this.metroGrid_MM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroGrid_MM_MouseDown);
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
            this.maPhimDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPhimDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenPhimDataGridViewTextBoxColumn
            // 
            this.tenPhimDataGridViewTextBoxColumn.DataPropertyName = "TenPhim";
            this.tenPhimDataGridViewTextBoxColumn.HeaderText = "Title";
            this.tenPhimDataGridViewTextBoxColumn.Name = "tenPhimDataGridViewTextBoxColumn";
            // 
            // theLoaiDataGridViewTextBoxColumn
            // 
            this.theLoaiDataGridViewTextBoxColumn.DataPropertyName = "TheLoai";
            this.theLoaiDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.theLoaiDataGridViewTextBoxColumn.Name = "theLoaiDataGridViewTextBoxColumn";
            // 
            // daoDienDataGridViewTextBoxColumn
            // 
            this.daoDienDataGridViewTextBoxColumn.DataPropertyName = "DaoDien";
            this.daoDienDataGridViewTextBoxColumn.HeaderText = "Director";
            this.daoDienDataGridViewTextBoxColumn.Name = "daoDienDataGridViewTextBoxColumn";
            // 
            // dienVienDataGridViewTextBoxColumn
            // 
            this.dienVienDataGridViewTextBoxColumn.DataPropertyName = "DienVien";
            this.dienVienDataGridViewTextBoxColumn.HeaderText = "Stars";
            this.dienVienDataGridViewTextBoxColumn.Name = "dienVienDataGridViewTextBoxColumn";
            // 
            // ngayKhoiChieuDataGridViewTextBoxColumn
            // 
            this.ngayKhoiChieuDataGridViewTextBoxColumn.DataPropertyName = "NgayKhoiChieu";
            dataGridViewCellStyle2.Format = "dd / MM / yyyy";
            this.ngayKhoiChieuDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ngayKhoiChieuDataGridViewTextBoxColumn.HeaderText = "Release Date";
            this.ngayKhoiChieuDataGridViewTextBoxColumn.Name = "ngayKhoiChieuDataGridViewTextBoxColumn";
            // 
            // moTaPhimDataGridViewTextBoxColumn
            // 
            this.moTaPhimDataGridViewTextBoxColumn.DataPropertyName = "MoTaPhim";
            this.moTaPhimDataGridViewTextBoxColumn.HeaderText = "Storyline";
            this.moTaPhimDataGridViewTextBoxColumn.Name = "moTaPhimDataGridViewTextBoxColumn";
            // 
            // imgPhimDataGridViewImageColumn
            // 
            this.imgPhimDataGridViewImageColumn.DataPropertyName = "ImgPhim";
            this.imgPhimDataGridViewImageColumn.HeaderText = "Image";
            this.imgPhimDataGridViewImageColumn.Name = "imgPhimDataGridViewImageColumn";
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
            // button_Addmovie
            // 
            this.button_Addmovie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Addmovie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Addmovie.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Addmovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Addmovie.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addmovie.Location = new System.Drawing.Point(389, 518);
            this.button_Addmovie.Name = "button_Addmovie";
            this.button_Addmovie.Size = new System.Drawing.Size(118, 39);
            this.button_Addmovie.TabIndex = 1;
            this.button_Addmovie.Text = "Add movie";
            this.button_Addmovie.UseVisualStyleBackColor = false;
            this.button_Addmovie.Click += new System.EventHandler(this.button_Addmovie_Click);
            // 
            // metroContextMenu_MM
            // 
            this.metroContextMenu_MM.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroContextMenu_MM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infomationToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.metroContextMenu_MM.Name = "metroContextMenu_MM";
            this.metroContextMenu_MM.Size = new System.Drawing.Size(146, 48);
            // 
            // infomationToolStripMenuItem
            // 
            this.infomationToolStripMenuItem.Name = "infomationToolStripMenuItem";
            this.infomationToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.infomationToolStripMenuItem.Text = "Infomation";
            this.infomationToolStripMenuItem.Click += new System.EventHandler(this.infomationToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tbPhimTableAdapter
            // 
            this.tbPhimTableAdapter.ClearBeforeFill = true;
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
            this.buttonX_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Back.Symbol = "";
            this.buttonX_Back.SymbolColor = System.Drawing.Color.Red;
            this.buttonX_Back.TabIndex = 21;
            this.buttonX_Back.Click += new System.EventHandler(this.buttonX_Back_Click);
            // 
            // pnlMovieManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.buttonX_Back);
            this.Controls.Add(this.metroGrid_MM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Addmovie);
            this.Controls.Add(this.button_SaveMM);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(848, 458);
            this.Name = "pnlMovieManagement";
            this.Size = new System.Drawing.Size(1127, 585);
            this.Load += new System.EventHandler(this.pnlMovieManagement_Load);
            this.Enter += new System.EventHandler(this.pnlMovieManagement_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).EndInit();
            this.metroContextMenu_MM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SaveMM;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid metroGrid_MM;
        private System.Windows.Forms.Button button_Addmovie;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu_MM;
        private System.Windows.Forms.ToolStripMenuItem infomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource tbPhimBindingSource;
        private DataSetFILM dataSetFILM;
        private DataSetFILMTableAdapters.TbPhimTableAdapter tbPhimTableAdapter;
        private DevComponents.DotNetBar.ButtonX buttonX_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daoDienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhoiChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgPhimDataGridViewImageColumn;
    }
}
