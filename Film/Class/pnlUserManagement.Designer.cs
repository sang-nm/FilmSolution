namespace Film.Class
{
    partial class pnlUserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.tbQuanLyNhanSuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFILM = new Film.DataSetFILM();
            this.tbQuanLyNhanSuTableAdapter = new Film.DataSetFILMTableAdapters.TbQuanLyNhanSuTableAdapter();
            this.metroContextMenu_UM = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonX_Back = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_Save = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX_UM = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanQuyenDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.trangThaiDataGridViewTextBoxColumn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.buttonX_Register = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuanLyNhanSuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).BeginInit();
            this.metroContextMenu_UM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX_UM)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // tbQuanLyNhanSuBindingSource
            // 
            this.tbQuanLyNhanSuBindingSource.DataMember = "TbQuanLyNhanSu";
            this.tbQuanLyNhanSuBindingSource.DataSource = this.dataSetFILM;
            // 
            // dataSetFILM
            // 
            this.dataSetFILM.DataSetName = "DataSetFILM";
            this.dataSetFILM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbQuanLyNhanSuTableAdapter
            // 
            this.tbQuanLyNhanSuTableAdapter.ClearBeforeFill = true;
            // 
            // metroContextMenu_UM
            // 
            this.metroContextMenu_UM.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroContextMenu_UM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.metroContextMenu_UM.Name = "metroContextMenu_UM";
            this.metroContextMenu_UM.Size = new System.Drawing.Size(112, 48);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // buttonX_Back
            // 
            this.buttonX_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Back.BackColor = System.Drawing.Color.Transparent;
            this.buttonX_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Back.FocusCuesEnabled = false;
            this.buttonX_Back.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Back.Location = new System.Drawing.Point(37, 37);
            this.buttonX_Back.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX_Back.Name = "buttonX_Back";
            this.buttonX_Back.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX_Back.Size = new System.Drawing.Size(40, 40);
            this.buttonX_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX_Back.Symbol = "";
            this.buttonX_Back.SymbolColor = System.Drawing.Color.Red;
            this.buttonX_Back.TabIndex = 20;
            this.buttonX_Back.Click += new System.EventHandler(this.buttonX_Exit_Click);
            // 
            // buttonX_Save
            // 
            this.buttonX_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonX_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Save.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Save.Location = new System.Drawing.Point(536, 363);
            this.buttonX_Save.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX_Save.Name = "buttonX_Save";
            this.buttonX_Save.Size = new System.Drawing.Size(126, 43);
            this.buttonX_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Save.TabIndex = 19;
            this.buttonX_Save.Text = "Save";
            this.buttonX_Save.Click += new System.EventHandler(this.buttonX_Save_Click);
            // 
            // dataGridViewX_UM
            // 
            this.dataGridViewX_UM.AllowUserToResizeColumns = false;
            this.dataGridViewX_UM.AllowUserToResizeRows = false;
            this.dataGridViewX_UM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX_UM.AutoGenerateColumns = false;
            this.dataGridViewX_UM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX_UM.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX_UM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX_UM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX_UM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.phanQuyenDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dataGridViewX_UM.DataSource = this.tbQuanLyNhanSuBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX_UM.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX_UM.EnableHeadersVisualStyles = false;
            this.dataGridViewX_UM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX_UM.Location = new System.Drawing.Point(195, 80);
            this.dataGridViewX_UM.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewX_UM.MultiSelect = false;
            this.dataGridViewX_UM.Name = "dataGridViewX_UM";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX_UM.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX_UM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX_UM.Size = new System.Drawing.Size(541, 270);
            this.dataGridViewX_UM.TabIndex = 18;
            this.dataGridViewX_UM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewX_UM_MouseDown);
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Username";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Password";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // phanQuyenDataGridViewTextBoxColumn
            // 
            this.phanQuyenDataGridViewTextBoxColumn.DataPropertyName = "PhanQuyen";
            this.phanQuyenDataGridViewTextBoxColumn.DisplayMember = "Text";
            this.phanQuyenDataGridViewTextBoxColumn.DropDownHeight = 106;
            this.phanQuyenDataGridViewTextBoxColumn.DropDownWidth = 121;
            this.phanQuyenDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phanQuyenDataGridViewTextBoxColumn.HeaderText = "Authority";
            this.phanQuyenDataGridViewTextBoxColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.phanQuyenDataGridViewTextBoxColumn.IntegralHeight = false;
            this.phanQuyenDataGridViewTextBoxColumn.ItemHeight = 15;
            this.phanQuyenDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.phanQuyenDataGridViewTextBoxColumn.Name = "phanQuyenDataGridViewTextBoxColumn";
            this.phanQuyenDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phanQuyenDataGridViewTextBoxColumn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.Checked = true;
            this.trangThaiDataGridViewTextBoxColumn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.trangThaiDataGridViewTextBoxColumn.CheckValue = null;
            this.trangThaiDataGridViewTextBoxColumn.CheckValueChecked = "Activated";
            this.trangThaiDataGridViewTextBoxColumn.CheckValueUnchecked = "Blocked";
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Activated";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangThaiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangThaiDataGridViewTextBoxColumn.TextColor = System.Drawing.Color.Red;
            // 
            // buttonX_Register
            // 
            this.buttonX_Register.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Register.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonX_Register.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Register.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Register.Location = new System.Drawing.Point(268, 363);
            this.buttonX_Register.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX_Register.Name = "buttonX_Register";
            this.buttonX_Register.Size = new System.Drawing.Size(126, 43);
            this.buttonX_Register.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Register.TabIndex = 17;
            this.buttonX_Register.Text = "Register";
            this.buttonX_Register.Click += new System.EventHandler(this.buttonX_Register_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Account Management";
            // 
            // pnlMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonX_Back);
            this.Controls.Add(this.buttonX_Save);
            this.Controls.Add(this.dataGridViewX_UM);
            this.Controls.Add(this.buttonX_Register);
            this.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(930, 430);
            this.Name = "pnlMemberManagement";
            this.Size = new System.Drawing.Size(930, 430);
            this.Load += new System.EventHandler(this.pnlUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbQuanLyNhanSuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).EndInit();
            this.metroContextMenu_UM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX_UM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.BindingSource tbQuanLyNhanSuBindingSource;
        private DataSetFILM dataSetFILM;
        private DataSetFILMTableAdapters.TbQuanLyNhanSuTableAdapter tbQuanLyNhanSuTableAdapter;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu_UM;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX buttonX_Back;
        private DevComponents.DotNetBar.ButtonX buttonX_Save;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX_UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn phanQuyenDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn trangThaiDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX buttonX_Register;
        private System.Windows.Forms.Label label1;
    }
}
