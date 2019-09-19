namespace Film.Class
{
    partial class pnlTicketBooking
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
            this.flowLayoutPanel_Booking = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Select = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.label_Movie = new System.Windows.Forms.Label();
            this.label_ReDate = new System.Windows.Forms.Label();
            this.label_Showing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX_Back = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Booking
            // 
            this.flowLayoutPanel_Booking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_Booking.Location = new System.Drawing.Point(0, 154);
            this.flowLayoutPanel_Booking.Name = "flowLayoutPanel_Booking";
            this.flowLayoutPanel_Booking.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.flowLayoutPanel_Booking.Size = new System.Drawing.Size(1198, 456);
            this.flowLayoutPanel_Booking.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(941, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Showing :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Release Date :";
            // 
            // button_Select
            // 
            this.button_Select.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Select.BackColor = System.Drawing.Color.LightGray;
            this.button_Select.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_Select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_Select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Select.Location = new System.Drawing.Point(1126, 79);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(65, 31);
            this.button_Select.TabIndex = 0;
            this.button_Select.Text = "Select";
            this.button_Select.UseVisualStyleBackColor = false;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Confirm.BackColor = System.Drawing.Color.Crimson;
            this.button_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.button_Confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Confirm.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(538, 121);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(123, 36);
            this.button_Confirm.TabIndex = 0;
            this.button_Confirm.Text = "Book";
            this.button_Confirm.UseVisualStyleBackColor = false;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label_Movie
            // 
            this.label_Movie.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Movie.Location = new System.Drawing.Point(145, 85);
            this.label_Movie.Name = "label_Movie";
            this.label_Movie.Size = new System.Drawing.Size(352, 65);
            this.label_Movie.TabIndex = 3;
            // 
            // label_ReDate
            // 
            this.label_ReDate.AutoSize = true;
            this.label_ReDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ReDate.Location = new System.Drawing.Point(677, 85);
            this.label_ReDate.Name = "label_ReDate";
            this.label_ReDate.Size = new System.Drawing.Size(0, 19);
            this.label_ReDate.TabIndex = 3;
            // 
            // label_Showing
            // 
            this.label_Showing.AutoSize = true;
            this.label_Showing.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Showing.Location = new System.Drawing.Point(1050, 85);
            this.label_Showing.Name = "label_Showing";
            this.label_Showing.Size = new System.Drawing.Size(0, 19);
            this.label_Showing.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Film.Properties.Resources.appbar_ticket;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(449, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket Booking";
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
            // pnlTicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.buttonX_Back);
            this.Controls.Add(this.label_Showing);
            this.Controls.Add(this.label_ReDate);
            this.Controls.Add(this.label_Movie);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel_Booking);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pnlTicketBooking";
            this.Size = new System.Drawing.Size(1198, 610);
            this.Load += new System.EventHandler(this.pnlBooking_Load);
            this.EnabledChanged += new System.EventHandler(this.pnlBooking_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Booking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Label label_Movie;
        private System.Windows.Forms.Label label_ReDate;
        private System.Windows.Forms.Label label_Showing;
        private DevComponents.DotNetBar.ButtonX buttonX_Back;
    }
}
