using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSProject.Entity_Layer;
using HMSProject.Repository_Layer;
using HMSProject.Validation_Layer;
using MetroFramework.Forms;

namespace HMSProject.Application_Layer
{
    public partial class AddAdmin : MetroForm
    {

        private AdminDash ad;
        AddAdminEntity en = new AddAdminEntity();
        AddAdminRepo re = new AddAdminRepo();
        public AdminDash Admin
        {
            get { return ad; }
            set { this.ad = value; }
        }


        public AddAdmin()
        {
            InitializeComponent();
        }

        public AddAdmin(AdminDash admin)
        {
            Admin = admin;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtReference.Text = "";
            txtAddress.Text = "";
            txtPhoneNo.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            cmbSex.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var en = new AddAdminEntity();
            var re = new AddAdminRepo();

            if (ValidateToSave() == true)
            {
                en.GeneratedId = txtId.Text;
                en.Name = txtName.Text;
                en.Age = int.Parse(txtAge.Text);
                en.Sex = cmbSex.SelectedItem.ToString();
                en.Reference = txtReference.Text;
                en.Address = txtAddress.Text;
                en.Phone = txtPhoneNo.Text;
                en.UserName = txtUserName.Text;
                en.Password = txtPassword.Text;

                lblId.Text = txtId.Text;
                mtxtName.Text = txtName.Text;
                mtxtAge.Text = txtAge.Text;
                mtxtUserName.Text = txtUserName.Text;
                mtxtPassword.Text = txtPassword.Text;
                mtxtSex.Text = cmbSex.SelectedItem.ToString();
                mtxtReference.Text = txtReference.Text;
                mtxtAddress.Text = txtAddress.Text;
                mtxtPhone.Text = txtPhoneNo.Text;

                re.AddAdmin(en);
                pnlDetails.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }


        public void AutoId()
        {
            string id = re.AutoGenerateId();
            en.AdminId = id;
            txtId.Text = en.AdminId;
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            AutoId();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var en = new AddAdminEntity();
            var re = new AddAdminRepo();

            en.GeneratedId = lblId.Text;
            en.Name = mtxtName.Text;
            en.Age = int.Parse(mtxtAge.Text);
            en.Sex = mtxtSex.Text;
            en.Reference = mtxtReference.Text;
            en.Address = mtxtAddress.Text;
            en.Phone = mtxtPhone.Text;
            en.UserName = mtxtUserName.Text;
            en.Password = mtxtPassword.Text;

            re.UpdateInfo(en);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Show();
        }

        private void AddAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Show();
        }

        private bool ValidateToSave()
        {
            if (Validation.IsStringValid(txtName.Text) && Validation.IsStringValid(txtReference.Text)
                && Validation.IsStringValid(txtAddress.Text) && Validation.IsStringValid(txtUserName.Text) && Validation.IsStringValid(txtPassword.Text)
                && Validation.IsPhoneValid(txtPhoneNo.Text) && Validation.IsIntValid(txtAge.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
