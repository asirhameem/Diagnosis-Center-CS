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
    public partial class AddDoctor : MetroForm
    {
        private AdminDash ad;
        AddDoctorEntity en = new AddDoctorEntity();
        AddDoctorRepo re = new AddDoctorRepo();


        public AdminDash Admin
        {
            get { return ad; }
            set { this.ad = value; }
        }

        public AddDoctor()
        {
            InitializeComponent();
        }

        public AddDoctor(AdminDash admin)
        {
            Admin = admin;
            InitializeComponent();
        }

        public void AutoId()
        {
            string id = re.AutoGenerateId();
            en.DoctorId = id;
            txtId.Text = en.DoctorId;
        }


        public String Available()
        {
            string day = "";

            if (ckbSat.Checked)
            {
                if (day != "")
                {
                    day += ",Sat";
                }
                else
                {
                    day += "Sat";
                }
            }
            if (ckbSun.Checked)
            {
                if (day != "")
                {
                    day += ",Sun";
                }
                else
                {
                    day += "Sun";
                }
            }
            if (ckbMon.Checked)
            {
                if (day != "")
                {
                    day += ",Mon";
                }
                else
                {
                    day += "Mon";
                }
            }
            if (ckbTue.Checked)
            {
                if (day != "")
                {
                    day += ",Tue";
                }
                else
                {
                    day += "Tue";
                }
            }
            if (ckbWed.Checked)
            {
                if (day != "")
                {
                    day += ",Wed";
                }
                else
                {
                    day += "Wed";
                }
            }
            if (ckbThr.Checked)
            {
                if (day != "")
                {
                    day += ",Thr";
                }
                else
                {
                    day += "Thr";
                }
            }
            if (ckbFri.Checked)
            {
                if (day != "")
                {
                    day += ",Fri";
                }
                else
                {
                    day += "Fri";
                }
            }
            txtAvailable.Text = day;
            return day;
        }






        

        private void AddDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var en = new AddDoctorEntity();
            var re = new AddDoctorRepo();

            if (ValidateToSave() == true)
            {
                en.GeneratedId = txtId.Text;
                en.Name = txtName.Text;
                en.Age = int.Parse(txtAge.Text);
                en.Sex = cmbSex.SelectedItem.ToString();
                en.Reference = txtReference.Text;
                en.Speciality = txtSpeciality.Text;
                en.Address = txtAddress.Text;
                en.Phone = txtPhoneNo.Text;
                en.UserName = txtUserName.Text;
                en.Password = txtPassword.Text;
                en.Time = dtpTime.Value.ToString("hh:mm tt");
                en.Available = Available();

                lblId.Text = txtId.Text;
                mtxtName.Text = txtName.Text;
                mtxtAge.Text = txtAge.Text;
                mtxtUserName.Text = txtUserName.Text;
                mtxtPassword.Text = txtPassword.Text;
                mtxtSex.Text = cmbSex.SelectedItem.ToString();
                mtxtReference.Text = txtReference.Text;
                mtxtAddress.Text = txtAddress.Text;
                mtxtPhone.Text = txtPhoneNo.Text;
                mtxtSpeciality.Text = txtSpeciality.Text;
                mtxtAvailable.Text = txtAvailable.Text;
                mtxtTime.Text = dtpTime.Value.ToString("hh:mm tt");

                re.AddDoctor(en);
                pnlDetails.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var en = new AddDoctorEntity();
            var re = new AddDoctorRepo();

            en.GeneratedId = lblId.Text;
            en.Name = mtxtName.Text;
            en.Age = int.Parse(mtxtAge.Text);
            en.Sex = mtxtSex.Text;
            en.Reference = mtxtReference.Text;
            en.Address = mtxtAddress.Text;
            en.Phone = mtxtPhone.Text;
            en.UserName = mtxtUserName.Text;
            en.Password = mtxtPassword.Text;
            en.Speciality = mtxtSpeciality.Text;
            en.Available = mtxtAvailable.Text;
            en.Time = mtxtTime.Text;

            re.UpdateInfo(en);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Show();
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
            txtSpeciality.Text = "";
            cmbSex.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin.Show();
        }


        private bool ValidateToSave()
        {
            if(Validation.IsStringValid(txtName.Text) && Validation.IsStringValid(txtReference.Text) 
                && Validation.IsStringValid(txtAddress.Text) && Validation.IsStringValid(txtSpeciality.Text)
                && Validation.IsStringValid(txtUserName.Text) && Validation.IsStringValid(txtPassword.Text)
                && Validation.IsPhoneValid(txtPhoneNo.Text) && Validation.IsIntValid(txtAge.Text) && Validation.IsComboBoxValid(cmbSex) )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            AutoId();
        }
    }
}