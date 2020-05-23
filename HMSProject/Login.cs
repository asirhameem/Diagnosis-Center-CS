using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblHeaderDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text.Equals("hamim"))
            {
                this.Visible = false;

                Admin admin = new Admin(txtUserName.Text);
                admin.Visible = true;
              
            }
            else { MessageBox.Show("Invalid"); }
        }

       
    }
}
