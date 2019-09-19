namespace Film.Class
{
    partial class pnlLooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlLooking));
            this.dateTimePicker_Looking = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Looking = new System.Windows.Forms.ComboBox();
            this.label_Looking = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroGrid_Looking = new MetroFramework.Controls.MetroGrid();
            this.MaLichChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbPhimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFILM = new Film.DataSetFILM();
            this.ngayChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suatChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbQuanLyLichChieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbQuanLyLichChieuTableAdapter = new Film.DataSetFILMTableAdapters.TbQuanLyLichChieuTableAdapter();
            this.tbPhimTableAdapter = new Film.DataSetFILMTableAdapters.TbPhimTableAdapter();
            this.button_Looking = new System.Windows.Forms.Button();
            this.button_X = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Looking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuanLyLichChieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Looking
            // 
            this.dateTimePicker_Looking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Looking.Location = new System.Drawing.Point(520, 28);
            this.dateTimePicker_Looking.Name = "dateTimePicker_Looking";
            this.dateTimePicker_Looking.Size = new System.Drawing.Size(246, 26);
            this.dateTimePicker_Looking.TabIndex = 34;
            this.dateTimePicker_Looking.ValueChanged += new System.EventHandler(this.dateTimePicker_Looking_ValueChanged);
            this.dateTimePicker_Looking.Enter += new System.EventHandler(this.dateTimePicker_Looking_Enter);
            // 
            // comboBox_Looking
            // 
            this.comboBox_Looking.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Looking.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Looking.FormattingEnabled = true;
            this.comboBox_Looking.Location = new System.Drawing.Point(124, 28);
            this.comboBox_Looking.Name = "comboBox_Looking";
            this.comboBox_Looking.Size = new System.Drawing.Size(246, 26);
            this.comboBox_Looking.TabIndex = 33;
            // 
            // label_Looking
            // 
            this.label_Looking.AutoSize = true;
            this.label_Looking.Font = new System.Drawing.Font("Modern No. 20", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Looking.Location = new System.Drawing.Point(407, 30);
            this.label_Looking.Name = "label_Looking";
            this.label_Looking.Size = new System.Drawing.Size(76, 22);
            this.label_Looking.TabIndex = 29;
            this.label_Looking.Text = "ReDate";
            this.label_Looking.Click += new System.EventHandler(this.label_Looking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Movie";
            // 
            // metroGrid_Looking
            // 
            this.metroGrid_Looking.AllowUserToAddRows = false;
            this.metroGrid_Looking.AllowUserToDeleteRows = false;
            this.metroGrid_Looking.AllowUserToResizeRows = false;
            this.metroGrid_Looking.AutoGenerateColumns = false;
            this.metroGrid_Looking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid_Looking.BackgroundColor = System.Drawing.SystemColors.Control;
            this.metroGrid_Looking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_Looking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_Looking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Looking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_Looking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_Looking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichChieu,
            this.maPhimDataGridViewTextBoxColumn,
            this.ngayChieuDataGridViewTextBoxColumn,
            this.phongChieuDataGridViewTextBoxColumn,
            this.suatChieuDataGridViewTextBoxColumn});
            this.metroGrid_Looking.DataSource = this.tbQuanLyLichChieuBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_Looking.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_Looking.EnableHeadersVisualStyles = false;
            this.metroGrid_Looking.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_Looking.GridColor = System.Drawing.Color.Black;
            this.metroGrid_Looking.Location = new System.Drawing.Point(36, 102);
            this.metroGrid_Looking.Name = "metroGrid_Looking";
            this.metroGrid_Looking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Looking.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_Looking.RowHeadersVisible = false;
            this.metroGrid_Looking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_Looking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_Looking.Size = new System.Drawing.Size(717, 149);
            this.metroGrid_Looking.TabIndex = 35;
            this.metroGrid_Looking.UseCustomBackColor = true;
            this.metroGrid_Looking.UseCustomForeColor = true;
            this.metroGrid_Looking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_Looking_CellDoubleClick);
            // 
            // MaLichChieu
            // 
            this.MaLichChieu.DataPropertyName = "MaLichChieu";
            this.MaLichChieu.HeaderText = "MaLichChieu";
            this.MaLichChieu.Name = "MaLichChieu";
            this.MaLichChieu.ReadOnly = true;
            this.MaLichChieu.Visible = false;
            // 
            // maPhimDataGridViewTextBoxColumn
            // 
            this.maPhimDataGridViewTextBoxColumn.DataPropertyName = "MaPhim";
            this.maPhimDataGridViewTextBoxColumn.DataSource = this.tbPhimBindingSource;
            this.maPhimDataGridViewTextBoxColumn.DisplayMember = "TenPhim";
            this.maPhimDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.maPhimDataGridViewTextBoxColumn.HeaderText = "Movie";
            this.maPhimDataGridViewTextBoxColumn.Name = "maPhimDataGridViewTextBoxColumn";
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
            this.ngayChieuDataGridViewTextBoxColumn.HeaderText = "ReDate";
            this.ngayChieuDataGridViewTextBoxColumn.Name = "ngayChieuDataGridViewTextBoxColumn";
            // 
            // phongChieuDataGridViewTextBoxColumn
            // 
            this.phongChieuDataGridViewTextBoxColumn.DataPropertyName = "PhongChieu";
            this.phongChieuDataGridViewTextBoxColumn.HeaderText = "Room";
            this.phongChieuDataGridViewTextBoxColumn.Name = "phongChieuDataGridViewTextBoxColumn";
            // 
            // suatChieuDataGridViewTextBoxColumn
            // 
            this.suatChieuDataGridViewTextBoxColumn.DataPropertyName = "SuatChieu";
            this.suatChieuDataGridViewTextBoxColumn.HeaderText = "Showings";
            this.suatChieuDataGridViewTextBoxColumn.Name = "suatChieuDataGridViewTextBoxColumn";
            // 
            // tbQuanLyLichChieuBindingSource
            // 
            this.tbQuanLyLichChieuBindingSource.DataMember = "TbQuanLyLichChieu";
            this.tbQuanLyLichChieuBindingSource.DataSource = this.dataSetFILM;
            // 
            // tbQuanLyLichChieuTableAdapter
            // 
            this.tbQuanLyLichChieuTableAdapter.ClearBeforeFill = true;
            // 
            // tbPhimTableAdapter
            // 
            this.tbPhimTableAdapter.ClearBeforeFill = true;
            // 
            // button_Looking
            // 
            this.button_Looking.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Looking.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Looking.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Looking.Location = new System.Drawing.Point(351, 59);
            this.button_Looking.Name = "button_Looking";
            this.button_Looking.Size = new System.Drawing.Size(87, 32);
            this.button_Looking.TabIndex = 36;
            this.button_Looking.Text = "Search";
            this.button_Looking.UseVisualStyleBackColor = false;
            this.button_Looking.Click += new System.EventHandler(this.button_Looking_Click);
            // 
            // button_X
            // 
            this.button_X.BackColor = System.Drawing.Color.White;
            this.button_X.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_X.Image = ((System.Drawing.Image)(resources.GetObject("button_X.Image")));
            this.button_X.Location = new System.Drawing.Point(761, 3);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(25, 23);
            this.button_X.TabIndex = 37;
            this.button_X.UseVisualStyleBackColor = false;
            this.button_X.Click += new System.EventHandler(this.button_X_Click);
            // 
            // pnlLooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_X);
            this.Controls.Add(this.button_Looking);
            this.Controls.Add(this.metroGrid_Looking);
            this.Controls.Add(this.dateTimePicker_Looking);
            this.Controls.Add(this.comboBox_Looking);
            this.Controls.Add(this.label_Looking);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pnlLooking";
            this.Size = new System.Drawing.Size(789, 268);
            this.Load += new System.EventHandler(this.pnlLooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Looking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFILM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuanLyLichChieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Looking;
        private System.Windows.Forms.ComboBox comboBox_Looking;
        private System.Windows.Forms.Label label_Looking;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid metroGrid_Looking;
        private System.Windows.Forms.BindingSource tbPhimBindingSource;
        private DataSetFILM dataSetFILM;
        private System.Windows.Forms.BindingSource tbQuanLyLichChieuBindingSource;
        private DataSetFILMTableAdapters.TbQuanLyLichChieuTableAdapter tbQuanLyLichChieuTableAdapter;
        private DataSetFILMTableAdapters.TbPhimTableAdapter tbPhimTableAdapter;
        private System.Windows.Forms.Button button_Looking;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichChieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn maPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suatChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_X;
    }
}
