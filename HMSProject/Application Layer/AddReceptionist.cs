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
    public partial class AddReceptionist : MetroForm
    {
        AddReceptionistEntity en = new AddReceptionistEntity();
        AddReceptionistRepo re = new AddReceptionistRepo();
        private AdminDash ad;

        public AdminDash Admin
        {
            get { return ad; }
            set { this.ad = value; }
        }
        
        public AddReceptionist()
        {
            InitializeComponent();
        }
        public AddReceptionist(AdminDash admin)
        {
            this.Admin = admin;
            
            InitializeComponent();
        }


        public void AutoId()
        {
            string id = re.AutoGenerateId();
            en.ReceptionistId = id;
            txtId.Text = en.ReceptionistId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var en = new AddReceptionistEntity();
            var re = new AddReceptionistRepo();

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

                re.AddReceptionist(en);
                pnlDetails.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        private void AddReceptionist_Load(object sender, EventArgs e)
        {
            AutoId();
            /*
            mtxtName.Text = txtName.Text;
            mtxtAge.Text = txtAge.Text;
            mtxtUserName.Text = txtUserName.Text;
            mtxtPassword.Text = txtPassword.Text;
            mtxtSex.Text = cmbSex.SelectedItem.ToString();
            mtxtReference.Text = txtReference.Text;
            mtxtAddress.Text = txtAddress.Text;
            mtxtPhone.Text = txtPhoneNo.Text;
            */
        }

        private void AddReceptionist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var en = new AddReceptionistEntity();
            var re = new AddReceptionistRepo();

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

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Show();
        }

        private bool ValidateToSave()
        {
            if (Validation.IsStringValid(txtName.Text) && Validation.IsStringValid(txtReference.Text)
                && Validation.IsStringValid(txtAddress.Text) 
                && Validation.IsStringValid(txtUserName.Text) && Validation.IsStringValid(txtPassword.Text)
                && Validation.IsPhoneValid(txtPhoneNo.Text) && Validation.IsIntValid(txtAge.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
