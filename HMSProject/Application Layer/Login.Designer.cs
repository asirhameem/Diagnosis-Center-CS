namespace HMSProject.Application_Layer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.mbtnLogin = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.mbtnExit = new MetroFramework.Controls.MetroButton();
            this.ckbShowPass = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(23, 134);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(325, 34);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(25, 238);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(323, 34);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(20, 193);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.Location = new System.Drawing.Point(23, 356);
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Size = new System.Drawing.Size(323, 44);
            this.mbtnLogin.TabIndex = 7;
            this.mbtnLogin.Text = "Login";
            this.mbtnLogin.UseSelectable = true;
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(360, 30);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(799, 521);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // mbtnExit
            // 
            this.mbtnExit.Location = new System.Drawing.Point(25, 430);
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(323, 43);
            this.mbtnExit.TabIndex = 10;
            this.mbtnExit.Text = "Exit";
            this.mbtnExit.UseSelectable = true;
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // ckbShowPass
            // 
            this.ckbShowPass.AutoSize = true;
            this.ckbShowPass.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.ckbShowPass.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.ckbShowPass.Location = new System.Drawing.Point(25, 299);
            this.ckbShowPass.Name = "ckbShowPass";
            this.ckbShowPass.Size = new System.Drawing.Size(149, 25);
            this.ckbShowPass.TabIndex = 11;
            this.ckbShowPass.Text = "Show Password";
            this.ckbShowPass.UseSelectable = true;
            this.ckbShowPass.CheckedChanged += new System.EventHandler(this.ckbShowPass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1163, 553);
            this.Controls.Add(this.ckbShowPass);
            this.Controls.Add(this.mbtnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "Login";
            this.Text = "Welcome To Our Facility";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private MetroFramework.Controls.MetroButton mbtnLogin;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton mbtnExit;
        private MetroFramework.Controls.MetroCheckBox ckbShowPass;
    }
}