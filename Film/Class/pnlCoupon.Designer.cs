namespace Film.Class
{
    partial class pnlCoupon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonX_Save = new DevComponents.DotNetBar.ButtonX();
            this.buttonX_Insert = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX_Back = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX_CM = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tbCouponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFILM = new Film.DataSetFILM();
            this.tbCouponTableAdapter = new Film.DataSetFILMTableAdapters.TbCouponTableAdapter();
            this.metroContextMenu_MM = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maCouponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX_CM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCouponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).BeginInit();
            this.metroContextMenu_MM.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonX_Save
            // 
            this.buttonX_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonX_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Save.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Save.Location = new System.Drawing.Point(423, 355);
            this.buttonX_Save.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.buttonX_Save.Name = "buttonX_Save";
            this.buttonX_Save.Size = new System.Drawing.Size(162, 34);
            this.buttonX_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Save.TabIndex = 29;
            this.buttonX_Save.Text = "Save";
            this.buttonX_Save.Click += new System.EventHandler(this.buttonX_Save_Click);
            // 
            // buttonX_Insert
            // 
            this.buttonX_Insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Insert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonX_Insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Insert.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Insert.Location = new System.Drawing.Point(145, 355);
            this.buttonX_Insert.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.buttonX_Insert.Name = "buttonX_Insert";
            this.buttonX_Insert.Size = new System.Drawing.Size(176, 34);
            this.buttonX_Insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX_Insert.TabIndex = 27;
            this.buttonX_Insert.Text = "Insert Voucher";
            this.buttonX_Insert.Click += new System.EventHandler(this.buttonX_Insert_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 34);
            this.label1.TabIndex = 31;
            this.label1.Text = "Coupon Management";
            // 
            // buttonX_Back
            // 
            this.buttonX_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX_Back.BackColor = System.Drawing.Color.Transparent;
            this.buttonX_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX_Back.FocusCuesEnabled = false;
            this.buttonX_Back.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX_Back.Location = new System.Drawing.Point(27, 27);
            this.buttonX_Back.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.buttonX_Back.Name = "buttonX_Back";
            this.buttonX_Back.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX_Back.Size = new System.Drawing.Size(40, 40);
            this.buttonX_Back.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.buttonX_Back.Symbol = "";
            this.buttonX_Back.SymbolColor = System.Drawing.Color.Red;
            this.buttonX_Back.TabIndex = 30;
            this.buttonX_Back.Click += new System.EventHandler(this.buttonX_Back_Click);
            // 
            // dataGridViewX_CM
            // 
            this.dataGridViewX_CM.AllowUserToAddRows = false;
            this.dataGridViewX_CM.AllowUserToResizeColumns = false;
            this.dataGridViewX_CM.AllowUserToResizeRows = false;
            this.dataGridViewX_CM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewX_CM.AutoGenerateColumns = false;
            this.dataGridViewX_CM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX_CM.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX_CM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX_CM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX_CM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCouponDataGridViewTextBoxColumn,
            this.memberDataGridViewTextBoxColumn,
            this.voucherDataGridViewTextBoxColumn});
            this.dataGridViewX_CM.DataSource = this.tbCouponBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX_CM.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX_CM.EnableHeadersVisualStyles = false;
            this.dataGridViewX_CM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX_CM.Location = new System.Drawing.Point(73, 66);
            this.dataGridViewX_CM.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dataGridViewX_CM.MultiSelect = false;
            this.dataGridViewX_CM.Name = "dataGridViewX_CM";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX_CM.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX_CM.RowHeadersVisible = false;
            this.dataGridViewX_CM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX_CM.Size = new System.Drawing.Size(579, 271);
            this.dataGridViewX_CM.TabIndex = 28;
            this.dataGridViewX_CM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewX_CM_MouseDown);
            // 
            // tbCouponBindingSource
            // 
            this.tbCouponBindingSource.DataMember = "TbCoupon";
            this.tbCouponBindingSource.DataSource = this.dataSetFILM;
            // 
            // dataSetFILM
            // 
            this.dataSetFILM.DataSetName = "DataSetFILM";
            this.dataSetFILM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCouponTableAdapter
            // 
            this.tbCouponTableAdapter.ClearBeforeFill = true;
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
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // maCouponDataGridViewTextBoxColumn
            // 
            this.maCouponDataGridViewTextBoxColumn.DataPropertyName = "MaCoupon";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maCouponDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.maCouponDataGridViewTextBoxColumn.HeaderText = "Coupon Code";
            this.maCouponDataGridViewTextBoxColumn.Name = "maCouponDataGridViewTextBoxColumn";
            // 
            // memberDataGridViewTextBoxColumn
            // 
            this.memberDataGridViewTextBoxColumn.DataPropertyName = "Member";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "#,## ₫";
            this.memberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.memberDataGridViewTextBoxColumn.HeaderText = "Member";
            this.memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            // 
            // voucherDataGridViewTextBoxColumn
            // 
            this.voucherDataGridViewTextBoxColumn.DataPropertyName = "Voucher";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "#,## ₫";
            this.voucherDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.voucherDataGridViewTextBoxColumn.HeaderText = "Voucher";
            this.voucherDataGridViewTextBoxColumn.Name = "voucherDataGridViewTextBoxColumn";
            // 
            // pnlCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonX_Save);
            this.Controls.Add(this.buttonX_Insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonX_Back);
            this.Controls.Add(this.dataGridViewX_CM);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(725, 412);
            this.Name = "pnlCoupon";
            this.Size = new System.Drawing.Size(725, 412);
            this.Load += new System.EventHandler(this.pnlCoupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX_CM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCouponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).EndInit();
            this.metroContextMenu_MM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX_Save;
        private DevComponents.DotNetBar.ButtonX buttonX_Insert;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonX_Back;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX_CM;
        private System.Windows.Forms.BindingSource tbCouponBindingSource;
        private DataSetFILM dataSetFILM;
        private DataSetFILMTableAdapters.TbCouponTableAdapter tbCouponTableAdapter;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu_MM;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCouponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherDataGridViewTextBoxColumn;
    }
}
