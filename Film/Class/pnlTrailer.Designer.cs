namespace Film.Class
{
    partial class pnlTrailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlTrailer));
            this.toolStrip_Trailer = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Fog = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_Back = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Forward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Home = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox_Link = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_Go = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.webBrowser_Trailer = new System.Windows.Forms.WebBrowser();
            this.toolStrip_Trailer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_Trailer
            // 
            this.toolStrip_Trailer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Fog,
            this.toolStripButton_Back,
            this.toolStripButton_Forward,
            this.toolStripSeparator1,
            this.toolStripButton_Home,
            this.toolStripButton_Refresh,
            this.toolStripTextBox_Link,
            this.toolStripButton_Go,
            this.toolStripButton_Exit});
            this.toolStrip_Trailer.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Trailer.Name = "toolStrip_Trailer";
            this.toolStrip_Trailer.Size = new System.Drawing.Size(740, 33);
            this.toolStrip_Trailer.TabIndex = 0;
            // 
            // toolStripLabel_Fog
            // 
            this.toolStripLabel_Fog.AutoSize = false;
            this.toolStripLabel_Fog.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel_Fog.Image")));
            this.toolStripLabel_Fog.Name = "toolStripLabel_Fog";
            this.toolStripLabel_Fog.Size = new System.Drawing.Size(30, 30);
            // 
            // toolStripButton_Back
            // 
            this.toolStripButton_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Back.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Back.Image")));
            this.toolStripButton_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Back.Name = "toolStripButton_Back";
            this.toolStripButton_Back.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton_Back.Text = "toolStripButton1";
            this.toolStripButton_Back.Click += new System.EventHandler(this.toolStripButton_Back_Click);
            // 
            // toolStripButton_Forward
            // 
            this.toolStripButton_Forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton_Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Forward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Forward.Image")));
            this.toolStripButton_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Forward.Name = "toolStripButton_Forward";
            this.toolStripButton_Forward.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton_Forward.Text = "toolStripButton2";
            this.toolStripButton_Forward.Click += new System.EventHandler(this.toolStripButton_Forward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton_Home
            // 
            this.toolStripButton_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Home.Image = global::Film.Properties.Resources.home;
            this.toolStripButton_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Home.Name = "toolStripButton_Home";
            this.toolStripButton_Home.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton_Home.Text = "toolStripButton3";
            this.toolStripButton_Home.Click += new System.EventHandler(this.toolStripButton_Refresh_Click);
            // 
            // toolStripButton_Refresh
            // 
            this.toolStripButton_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Refresh.Image = global::Film.Properties.Resources.refresh;
            this.toolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Refresh.Name = "toolStripButton_Refresh";
            this.toolStripButton_Refresh.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton_Refresh.Text = "toolStripButton4";
            this.toolStripButton_Refresh.Click += new System.EventHandler(this.toolStripButton_Home_Click);
            // 
            // toolStripTextBox_Link
            // 
            this.toolStripTextBox_Link.Name = "toolStripTextBox_Link";
            this.toolStripTextBox_Link.Size = new System.Drawing.Size(522, 33);
            // 
            // toolStripButton_Go
            // 
            this.toolStripButton_Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Go.Image = global::Film.Properties.Resources.play;
            this.toolStripButton_Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Go.Name = "toolStripButton_Go";
            this.toolStripButton_Go.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton_Go.Text = "toolStripButton5";
            this.toolStripButton_Go.Click += new System.EventHandler(this.toolStripButton_Go_Click);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Exit.Image = global::Film.Properties.Resources.close;
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton_Exit.Text = "toolStripButton6";
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // webBrowser_Trailer
            // 
            this.webBrowser_Trailer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_Trailer.Location = new System.Drawing.Point(0, 33);
            this.webBrowser_Trailer.Name = "webBrowser_Trailer";
            this.webBrowser_Trailer.Size = new System.Drawing.Size(740, 427);
            this.webBrowser_Trailer.TabIndex = 1;
            this.webBrowser_Trailer.Url = new System.Uri("http://youtube.com", System.UriKind.Absolute);
            // 
            // pnlTrailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser_Trailer);
            this.Controls.Add(this.toolStrip_Trailer);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(740, 460);
            this.Name = "pnlTrailer";
            this.Size = new System.Drawing.Size(740, 460);
            this.toolStrip_Trailer.ResumeLayout(false);
            this.toolStrip_Trailer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_Trailer;
        private System.Windows.Forms.ToolStripButton toolStripButton_Back;
        private System.Windows.Forms.ToolStripButton toolStripButton_Forward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Home;
        private System.Windows.Forms.ToolStripButton toolStripButton_Refresh;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Link;
        private System.Windows.Forms.ToolStripButton toolStripButton_Go;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.WebBrowser webBrowser_Trailer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Fog;
    }
}
