namespace Film.Class
{
    partial class pnlMemberManagerment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX_Back = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_Save = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX_MM = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCouponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFILM = new Film.DataSetFILM();
            this.buttonX_MRegister = new DevComponents.DotNetBar.ButtonX();
            this.tbMemberTableAdapter = new Film.DataSetFILMTableAdapters.TbMemberTableAdapter();
            this.metroContextMenu_MM = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).BeginInit();
            this.metroContextMenu_MM.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "Member Management";
            // 
            // buttonX_Back
            // 
            this.buttonX_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Back.BackColor = System.Drawing.Color.Transparent;
            this.buttonX_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Back.FocusCuesEnabled = false;
            this.buttonX_Back.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Back.Location = new System.Drawing.Point(37, 37);
            this.buttonX_Back.Margin = new System.Windows.Forms.Padding(6);
            this.buttonX_Back.Name = "buttonX_Back";
            this.buttonX_Back.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX_Back.Size = new System.Drawing.Size(40, 40);
            this.buttonX_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX_Back.Symbol = "";
            this.buttonX_Back.SymbolColor = System.Drawing.Color.Red;
            this.buttonX_Back.TabIndex = 25;
            this.buttonX_Back.Click += new System.EventHandler(this.buttonX_Exit_Click);
            // 
            // buttonX_Save
            // 
            this.buttonX_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonX_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Save.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Save.Location = new System.Drawing.Point(606, 390);
            this.buttonX_Save.Margin = new System.Windows.Forms.Padding(6);
            this.buttonX_Save.Name = "buttonX_Save";
            this.buttonX_Save.Size = new System.Drawing.Size(125, 41);
            this.buttonX_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Save.TabIndex = 24;
            this.buttonX_Save.Text = "Save";
            this.buttonX_Save.Click += new System.EventHandler(this.buttonX_Save_Click);
            // 
            // dataGridViewX_MM
            // 
            this.dataGridViewX_MM.AllowUserToAddRows = false;
            this.dataGridViewX_MM.AllowUserToResizeColumns = false;
            this.dataGridViewX_MM.AllowUserToResizeRows = false;
            this.dataGridViewX_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX_MM.AutoGenerateColumns = false;
            this.dataGridViewX_MM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX_MM.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX_MM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewX_MM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX_MM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThanhVien,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.maCouponDataGridViewTextBoxColumn});
            this.dataGridViewX_MM.DataSource = this.tbMemberBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX_MM.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewX_MM.EnableHeadersVisualStyles = false;
            this.dataGridViewX_MM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX_MM.Location = new System.Drawing.Point(105, 80);
            this.dataGridViewX_MM.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewX_MM.MinimumSize = new System.Drawing.Size(714, 260);
            this.dataGridViewX_MM.MultiSelect = false;
            this.dataGridViewX_MM.Name = "dataGridViewX_MM";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX_MM.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewX_MM.RowHeadersVisible = false;
            this.dataGridViewX_MM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX_MM.Size = new System.Drawing.Size(805, 294);
            this.dataGridViewX_MM.TabIndex = 23;
            this.dataGridViewX_MM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewX_UM_MouseDown);
            // 
            // MaThanhVien
            // 
            this.MaThanhVien.DataPropertyName = "MaThanhVien";
            this.MaThanhVien.FillWeight = 20F;
            this.MaThanhVien.HeaderText = "ID";
            this.MaThanhVien.Name = "MaThanhVien";
            this.MaThanhVien.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.FillWeight = 89.54314F;
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Name";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.FillWeight = 89.54314F;
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.FillWeight = 89.54314F;
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "Identity Card Number";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.FillWeight = 89.54314F;
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // maCouponDataGridViewTextBoxColumn
            // 
            this.maCouponDataGridViewTextBoxColumn.DataPropertyName = "MaCoupon";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gainsboro;
            this.maCouponDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.maCouponDataGridViewTextBoxColumn.FillWeight = 89.54314F;
            this.maCouponDataGridViewTextBoxColumn.HeaderText = "Coupon Code";
            this.maCouponDataGridViewTextBoxColumn.Name = "maCouponDataGridViewTextBoxColumn";
            this.maCouponDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbMemberBindingSource
            // 
            this.tbMemberBindingSource.DataMember = "TbMember";
            this.tbMemberBindingSource.DataSource = this.dataSetFILM;
            // 
            // dataSetFILM
            // 
            this.dataSetFILM.DataSetName = "DataSetFILM";
            this.dataSetFILM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonX_MRegister
            // 
            this.buttonX_MRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_MRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonX_MRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_MRegister.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_MRegister.Location = new System.Drawing.Point(286, 390);
            this.buttonX_MRegister.Margin = new System.Windows.Forms.Padding(6);
            this.buttonX_MRegister.Name = "buttonX_MRegister";
            this.buttonX_MRegister.Size = new System.Drawing.Size(125, 41);
            this.buttonX_MRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_MRegister.TabIndex = 22;
            this.buttonX_MRegister.Text = "M.Register";
            this.buttonX_MRegister.Click += new System.EventHandler(this.buttonX_MRegister_Click);
            // 
            // tbMemberTableAdapter
            // 
            this.tbMemberTableAdapter.ClearBeforeFill = true;
            // 
            // metroContextMenu_MM
            // 
            this.metroContextMenu_MM.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroContextMenu_MM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.metroContextMenu_MM.Name = "metroContextMenu_UM";
            this.metroContextMenu_MM.Size = new System.Drawing.Size(107, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // pnlMemberManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonX_Save);
            this.Controls.Add(this.buttonX_MRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonX_Back);
            this.Controls.Add(this.dataGridViewX_MM);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(925, 439);
            this.Name = "pnlMemberManagerment";
            this.Size = new System.Drawing.Size(1016, 455);
            this.Load += new System.EventHandler(this.pnlMemberManagerment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).EndInit();
            this.metroContextMenu_MM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonX_Back;
        private DevComponents.DotNetBar.ButtonX buttonX_Save;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX_MM;
        private DevComponents.DotNetBar.ButtonX buttonX_MRegister;
        private System.Windows.Forms.BindingSource tbMemberBindingSource;
        private DataSetFILM dataSetFILM;
        private DataSetFILMTableAdapters.TbMemberTableAdapter tbMemberTableAdapter;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu_MM;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCouponDataGridViewTextBoxColumn;
    }
}
