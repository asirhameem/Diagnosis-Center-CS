namespace HospitalManagementSystem
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pcbHeaderLogo = new System.Windows.Forms.PictureBox();
            this.pnlUserPass = new System.Windows.Forms.Panel();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeaderDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHeaderLogo)).BeginInit();
            this.pnlUserPass.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Ivory;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pcbHeaderLogo);
            this.pnlMain.Controls.Add(this.pnlUserPass);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(1, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1181, 702);
            this.pnlMain.TabIndex = 0;
            // 
            // pcbHeaderLogo
            // 
            this.pcbHeaderLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbHeaderLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbHeaderLogo.Image")));
            this.pcbHeaderLogo.Location = new System.Drawing.Point(10, 11);
            this.pcbHeaderLogo.Name = "pcbHeaderLogo";
            this.pcbHeaderLogo.Size = new System.Drawing.Size(217, 216);
            this.pcbHeaderLogo.TabIndex = 6;
            this.pcbHeaderLogo.TabStop = false;
            // 
            // pnlUserPass
            // 
            this.pnlUserPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUserPass.Controls.Add(this.btnShowPass);
            this.pnlUserPass.Controls.Add(this.btnLogin);
            this.pnlUserPass.Controls.Add(this.txtUserName);
            this.pnlUserPass.Controls.Add(this.txtPassword);
            this.pnlUserPass.Controls.Add(this.lblUserName);
            this.pnlUserPass.Controls.Add(this.lblPassword);
            this.pnlUserPass.Location = new System.Drawing.Point(769, 242);
            this.pnlUserPass.Name = "pnlUserPass";
            this.pnlUserPass.Size = new System.Drawing.Size(399, 163);
            this.pnlUserPass.TabIndex = 5;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.Location = new System.Drawing.Point(334, 69);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(32, 30);
            this.btnShowPass.TabIndex = 7;
            this.btnShowPass.Text = "\r\n";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(283, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 37);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(160, 17);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(206, 34);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(160, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(26, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(116, 25);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(38, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DarkRed;
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(233, 11);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(935, 216);
            this.pnlHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHeaderDetails);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(252, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 98);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "You need to let that shit go!!";
            // 
            // lblHeaderDetails
            // 
            this.lblHeaderDetails.AutoSize = true;
            this.lblHeaderDetails.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderDetails.Location = new System.Drawing.Point(9, 11);
            this.lblHeaderDetails.Name = "lblHeaderDetails";
            this.lblHeaderDetails.Size = new System.Drawing.Size(638, 30);
            this.lblHeaderDetails.TabIndex = 1;
            this.lblHeaderDetails.Text = "Your\'s personal healthcare companion, togather we live.";
            this.lblHeaderDetails.Click += new System.EventHandler(this.lblHeaderDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "It\'s not about what you\'ve lost. It\'s about what you still have.";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHeader.Location = new System.Drawing.Point(171, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(595, 71);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Hospital Management System";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Welcome";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHeaderLogo)).EndInit();
            this.pnlUserPass.ResumeLayout(false);
            this.pnlUserPass.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlUserPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderDetails;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pcbHeaderLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnShowPass;
    }
}

