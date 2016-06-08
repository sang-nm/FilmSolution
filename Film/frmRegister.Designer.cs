namespace Film
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.statusStripReg = new System.Windows.Forms.StatusStrip();
            this.sstReg = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCcel = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.errorReg = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelDiachi = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxRegister = new System.Windows.Forms.PictureBox();
            this.statusStripReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripReg
            // 
            this.statusStripReg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripReg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sstReg});
            this.statusStripReg.Location = new System.Drawing.Point(0, 442);
            this.statusStripReg.Name = "statusStripReg";
            this.statusStripReg.Size = new System.Drawing.Size(730, 22);
            this.statusStripReg.TabIndex = 5;
            this.statusStripReg.Text = "statusStrip1";
            // 
            // sstReg
            // 
            this.sstReg.Name = "sstReg";
            this.sstReg.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCcel
            // 
            this.btnCcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCcel.Location = new System.Drawing.Point(406, 409);
            this.btnCcel.Name = "btnCcel";
            this.btnCcel.Size = new System.Drawing.Size(106, 30);
            this.btnCcel.TabIndex = 7;
            this.btnCcel.Text = "Thoát";
            this.btnCcel.UseVisualStyleBackColor = true;
            this.btnCcel.Click += new System.EventHandler(this.btnCcel_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(218, 409);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(106, 30);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Đăng ký";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // errorReg
            // 
            this.errorReg.ContainerControl = this;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(121, 210);
            this.txtDT.MaxLength = 11;
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(284, 22);
            this.txtDT.TabIndex = 4;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(121, 120);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(284, 18);
            this.txtDiachi.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(121, 26);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(284, 22);
            this.txtTen.TabIndex = 0;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(121, 73);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(284, 22);
            this.dateNgaySinh.TabIndex = 1;
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Location = new System.Drawing.Point(22, 217);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(58, 15);
            this.labelphone.TabIndex = 6;
            this.labelphone.Text = "Số Phone";
            // 
            // labelDiachi
            // 
            this.labelDiachi.AutoSize = true;
            this.labelDiachi.Location = new System.Drawing.Point(22, 123);
            this.labelDiachi.Name = "labelDiachi";
            this.labelDiachi.Size = new System.Drawing.Size(44, 15);
            this.labelDiachi.TabIndex = 7;
            this.labelDiachi.Text = "Địa chỉ";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(22, 76);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(63, 15);
            this.labelNgaySinh.TabIndex = 8;
            this.labelNgaySinh.Text = "Ngày Sinh";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(22, 29);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(43, 15);
            this.labelTen.TabIndex = 9;
            this.labelTen.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(121, 163);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(284, 22);
            this.txtCMND.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 257);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(318, 296);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(219, 22);
            this.txtTDN.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(318, 333);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(219, 22);
            this.txtMK.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mật khẩu";
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(318, 370);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.Size = new System.Drawing.Size(219, 22);
            this.txtMK2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(543, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxRegister
            // 
            this.pictureBoxRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBoxRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRegister.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegister.Image")));
            this.pictureBoxRegister.Location = new System.Drawing.Point(459, 29);
            this.pictureBoxRegister.Name = "pictureBoxRegister";
            this.pictureBoxRegister.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegister.TabIndex = 20;
            this.pictureBoxRegister.TabStop = false;
            this.pictureBoxRegister.Click += new System.EventHandler(this.pictureBoxRegister_Click);
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCcel;
            this.ClientSize = new System.Drawing.Size(730, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMK2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxRegister);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelDiachi);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.statusStripReg);
            this.Controls.Add(this.btnCcel);
            this.Controls.Add(this.btnReg);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.statusStripReg.ResumeLayout(false);
            this.statusStripReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripReg;
        private System.Windows.Forms.ToolStripStatusLabel sstReg;
        private System.Windows.Forms.Button btnCcel;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ErrorProvider errorReg;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelDiachi;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxRegister;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}