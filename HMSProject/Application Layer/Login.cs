using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using HMSProject.Data_layer;
using HMSProject.Entity_Layer;
using HMSProject.Repository_Layer;


namespace HMSProject.Application_Layer
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        /*
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        */
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
           /* if(this.txtUserName.Text != "" && this.txtPassword.Text != "" )
            {
                var user =new UserLoginEntity();
                user.UserName = this.txtUserName.Text.Trim();
                user.UserPass = this.txtPassword.Text.Trim();

                var userRep = new UserLoginRepo();
                if (user.UserName.Substring(0, 1) == "A")
                {

                    if (userRep.UserLoginAdmin(user))
                    {
                        MessageBox.Show("Welcome Admin");
                        this.Visible = false;
                        var admin = new AdminDash(txtUserName.Text.Trim());
                        admin.Visible = true;

                    }
                    else
                    { MessageBox.Show("Invalid Id or Password"); }
                }
                else if (user.UserName.Substring(0, 1) == "R")
                {
                    if (userRep.UserLoginReciptionist(user))
                    {
                        MessageBox.Show("Hey There");
                        var reciption = new ReciptionistDash(txtUserName.Text.Trim());
                        //this.Visible = false;
                        this.Hide();
                        reciption.Show();
                        //reciption.Visible = true;
                    }
                    else
                    { MessageBox.Show("Invalid Id or Password"); }
                }
                else if (user.UserName.Substring(0, 1) == "D")
                {
                    if (userRep.UserLoginDoctor(user))
                    {
                        MessageBox.Show("Welcome Doctor");
                        var doctor = new DoctorDash(txtUserName.Text.Trim());
                        this.Visible = false;
                        doctor.Visible = true;
                    }
                    else
                    { MessageBox.Show("Invalid Id or Password"); }
                    
                }


            }*/
            

        }

        private void mbtnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text != "" && this.txtPassword.Text != "")
            {
                var user = new UserLoginEntity();
                user.UserName = this.txtUserName.Text.Trim();
                user.UserPass = this.txtPassword.Text.Trim();

                var userRep = new UserLoginRepo();
                if (user.UserName.Substring(0, 1) == "A" || user.UserName.Substring(0, 1) == "a")
                {

                    if (userRep.UserLoginAdmin(user))
                    {
                        MessageBox.Show("Welcome Admin");
                        this.Visible = false;
                        var admin = new AdminDash(txtUserName.Text.Trim());
                        admin.Visible = true;

                    }
                    else
                    { MessageBox.Show("Invalid Id or Password"); }
                }
                else if (user.UserName.Substring(0, 1) == "R" || user.UserName.Substring(0, 1) == "r")
                {
                    if (userRep.UserLoginReciptionist(user))
                    {
                        //MessageBox.Show("Hey There");
                        var reciption = new ReceptionistDash(txtUserName.Text.Trim());
                        //this.Visible = false;
                        this.Hide();
                        reciption.Show();
                        //reciption.Visible = true;
                    }
                    else
                    { MessageBox.Show("Invalid Id or Password"); }
                }
                else if (user.UserName.Substring(0, 1) == "D" || user.UserName.Substring(0, 1) == "d")
                {
                    if (userRep.UserLoginDoctor(user))
                    {
                        MessageBox.Show("Welcome Doctor");
                        var doctor = new DoctorDash(txtUserName.Text.Trim());
                        this.Visible = false;
                        doctor.Visible = true;
                    }
                    else
                    { MessageBox.Show("Invalid Id or Password"); }

                }


            }



        }

        

        private void mbtnShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            if (ckbShowPass.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
