namespace Film
{
    partial class frmUserManagerment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonDangky = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanQuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quanLyNhanSuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFILM = new Film.DataSetFILM();
            this.quanLyNhanSuTableAdapter = new Film.DataSetFILMTableAdapters.QuanLyNhanSuTableAdapter();
            this.contextMenuStrip_UM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).BeginInit();
            this.contextMenuStrip_UM.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDangky
            // 
            this.buttonDangky.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDangky.Location = new System.Drawing.Point(73, 214);
            this.buttonDangky.Name = "buttonDangky";
            this.buttonDangky.Size = new System.Drawing.Size(101, 31);
            this.buttonDangky.TabIndex = 2;
            this.buttonDangky.Text = "Đăng ký";
            this.buttonDangky.UseVisualStyleBackColor = true;
            this.buttonDangky.Click += new System.EventHandler(this.buttonDangky_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Location = new System.Drawing.Point(369, 214);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(101, 31);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLuu.Location = new System.Drawing.Point(221, 214);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(101, 31);
            this.buttonLuu.TabIndex = 3;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToResizeColumns = false;
            this.dataGridViewUser.AllowUserToResizeRows = false;
            this.dataGridViewUser.AutoGenerateColumns = false;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.phanQuyenDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dataGridViewUser.DataSource = this.quanLyNhanSuBindingSource;
            this.dataGridViewUser.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewUser.MultiSelect = false;
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersVisible = false;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(539, 181);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUser_MouseDown);
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // phanQuyenDataGridViewTextBoxColumn
            // 
            this.phanQuyenDataGridViewTextBoxColumn.DataPropertyName = "PhanQuyen";
            this.phanQuyenDataGridViewTextBoxColumn.HeaderText = "Phân quyền";
            this.phanQuyenDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.phanQuyenDataGridViewTextBoxColumn.Name = "phanQuyenDataGridViewTextBoxColumn";
            this.phanQuyenDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.FalseValue = "Blocked";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trangThaiDataGridViewTextBoxColumn.IndeterminateValue = "Blocked";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangThaiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangThaiDataGridViewTextBoxColumn.TrueValue = "Activated";
            // 
            // quanLyNhanSuBindingSource
            // 
            this.quanLyNhanSuBindingSource.DataMember = "QuanLyNhanSu";
            this.quanLyNhanSuBindingSource.DataSource = this.dataSetFILM;
            // 
            // dataSetFILM
            // 
            this.dataSetFILM.DataSetName = "DataSetFILM";
            this.dataSetFILM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyNhanSuTableAdapter
            // 
            this.quanLyNhanSuTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip_UM
            // 
            this.contextMenuStrip_UM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_UM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_UM.Name = "contextMenuStrip_UM";
            this.contextMenuStrip_UM.Size = new System.Drawing.Size(109, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.editToolStripMenuItem.Text = "Profile";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmUserManagerment
            // 
            this.AcceptButton = this.buttonLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonThoat;
            this.ClientSize = new System.Drawing.Size(563, 267);
            this.Controls.Add(this.buttonDangky);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.dataGridViewUser);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUserManagerment";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.frmUserManagerment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).EndInit();
            this.contextMenuStrip_UM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDangky;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private DataSetFILM dataSetFILM;
        private System.Windows.Forms.BindingSource quanLyNhanSuBindingSource;
        private DataSetFILMTableAdapters.QuanLyNhanSuTableAdapter quanLyNhanSuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn phanQuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_UM;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}