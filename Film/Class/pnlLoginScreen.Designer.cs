namespace Film.Class
{
    partial class pnlLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlLoginScreen));
            this.metroButton_Login = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToolTip_Login = new MetroFramework.Components.MetroToolTip();
            this.metroTextBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.checkBox_showPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // metroButton_Login
            // 
            this.metroButton_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton_Login.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton_Login.Location = new System.Drawing.Point(544, 359);
            this.metroButton_Login.Name = "metroButton_Login";
            this.metroButton_Login.Size = new System.Drawing.Size(113, 39);
            this.metroButton_Login.TabIndex = 3;
            this.metroButton_Login.Text = "Login";
            this.metroButton_Login.UseSelectable = true;
            this.metroButton_Login.Click += new System.EventHandler(this.metroButton_Login_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Screen";
            // 
            // metroToolTip_Login
            // 
            this.metroToolTip_Login.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToolTip_Login.StyleManager = null;
            this.metroToolTip_Login.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTextBox_Password
            // 
            this.metroTextBox_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.metroTextBox_Password.CustomButton.BackColor = System.Drawing.Color.Red;
            this.metroTextBox_Password.CustomButton.Image = null;
            this.metroTextBox_Password.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.metroTextBox_Password.CustomButton.Name = "";
            this.metroTextBox_Password.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTextBox_Password.CustomButton.TabIndex = 1;
            this.metroTextBox_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox_Password.CustomButton.UseCustomBackColor = true;
            this.metroTextBox_Password.CustomButton.UseCustomForeColor = true;
            this.metroTextBox_Password.CustomButton.UseSelectable = true;
            this.metroTextBox_Password.CustomButton.UseStyleColors = true;
            this.metroTextBox_Password.CustomButton.UseVisualStyleBackColor = true;
            this.metroTextBox_Password.CustomButton.Visible = false;
            this.metroTextBox_Password.DisplayIcon = true;
            this.metroTextBox_Password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox_Password.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox_Password.Icon")));
            this.metroTextBox_Password.IconRight = true;
            this.metroTextBox_Password.Lines = new string[0];
            this.metroTextBox_Password.Location = new System.Drawing.Point(307, 324);
            this.metroTextBox_Password.MaxLength = 32767;
            this.metroTextBox_Password.Name = "metroTextBox_Password";
            this.metroTextBox_Password.PasswordChar = '\0';
            this.metroTextBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Password.SelectedText = "";
            this.metroTextBox_Password.SelectionLength = 0;
            this.metroTextBox_Password.SelectionStart = 0;
            this.metroTextBox_Password.Size = new System.Drawing.Size(350, 29);
            this.metroTextBox_Password.TabIndex = 2;
            this.metroToolTip_Login.SetToolTip(this.metroTextBox_Password, "Enter your password!");
            this.metroTextBox_Password.UseSelectable = true;
            this.metroTextBox_Password.WaterMark = "Password";
            this.metroTextBox_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_Password_KeyPress);
            // 
            // metroTextBox_Username
            // 
            this.metroTextBox_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.metroTextBox_Username.CustomButton.Image = null;
            this.metroTextBox_Username.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.metroTextBox_Username.CustomButton.Name = "";
            this.metroTextBox_Username.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Username.CustomButton.TabIndex = 1;
            this.metroTextBox_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Username.CustomButton.UseSelectable = true;
            this.metroTextBox_Username.CustomButton.Visible = false;
            this.metroTextBox_Username.DisplayIcon = true;
            this.metroTextBox_Username.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox_Username.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox_Username.Icon")));
            this.metroTextBox_Username.IconRight = true;
            this.metroTextBox_Username.Lines = new string[0];
            this.metroTextBox_Username.Location = new System.Drawing.Point(307, 289);
            this.metroTextBox_Username.MaxLength = 32767;
            this.metroTextBox_Username.Name = "metroTextBox_Username";
            this.metroTextBox_Username.PasswordChar = '\0';
            this.metroTextBox_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Username.SelectedText = "";
            this.metroTextBox_Username.SelectionLength = 0;
            this.metroTextBox_Username.SelectionStart = 0;
            this.metroTextBox_Username.Size = new System.Drawing.Size(350, 29);
            this.metroTextBox_Username.TabIndex = 1;
            this.metroToolTip_Login.SetToolTip(this.metroTextBox_Username, "Enter your username!");
            this.metroTextBox_Username.UseSelectable = true;
            this.metroTextBox_Username.WaterMark = "Username";
            this.metroTextBox_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_Username.Enter += new System.EventHandler(this.metroTextBox_Username_Enter);
            this.metroTextBox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_Username_KeyPress);
            // 
            // checkBox_showPass
            // 
            this.checkBox_showPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_showPass.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_showPass.AutoSize = true;
            this.checkBox_showPass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_showPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBox_showPass.FlatAppearance.BorderSize = 0;
            this.checkBox_showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_showPass.Image = ((System.Drawing.Image)(resources.GetObject("checkBox_showPass.Image")));
            this.checkBox_showPass.Location = new System.Drawing.Point(659, 325);
            this.checkBox_showPass.Name = "checkBox_showPass";
            this.checkBox_showPass.Size = new System.Drawing.Size(26, 26);
            this.checkBox_showPass.TabIndex = 4;
            this.checkBox_showPass.UseVisualStyleBackColor = false;
            this.checkBox_showPass.CheckedChanged += new System.EventHandler(this.checkBox_showPass_CheckedChanged);
            // 
            // pnlLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_showPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton_Login);
            this.Controls.Add(this.metroTextBox_Password);
            this.Controls.Add(this.metroTextBox_Username);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(440, 270);
            this.Name = "pnlLoginScreen";
            this.Size = new System.Drawing.Size(992, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroToolTip metroToolTip_Login;
        private MetroFramework.Controls.MetroButton metroButton_Login;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Password;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_showPass;
    }
}
