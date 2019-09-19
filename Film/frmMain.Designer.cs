namespace Film
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLink_Power = new MetroFramework.Controls.MetroLink();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(528, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Margarita";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.metroLink_Power);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 48);
            this.panel1.TabIndex = 1;
            // 
            // metroLink_Power
            // 
            this.metroLink_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink_Power.BackColor = System.Drawing.Color.Transparent;
            this.metroLink_Power.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink_Power.BackgroundImage")));
            this.metroLink_Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink_Power.Location = new System.Drawing.Point(1192, 3);
            this.metroLink_Power.Name = "metroLink_Power";
            this.metroLink_Power.Size = new System.Drawing.Size(54, 44);
            this.metroLink_Power.TabIndex = 2;
            this.metroLink_Power.UseSelectable = true;
            this.metroLink_Power.Click += new System.EventHandler(this.metroLink_Power_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sessions: ";
            this.label2.Visible = false;
            // 
            // label_Name
            // 
            this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(92, 676);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(46, 19);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name";
            this.label_Name.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(0, 0, 0, -16);
            this.BackMaxSize = 150;
            this.ClientSize = new System.Drawing.Size(1248, 700);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(30, 53, 30, 28);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLink metroLink_Power;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Name;
    }
}