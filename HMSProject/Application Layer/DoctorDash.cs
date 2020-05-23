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
    public partial class DoctorDash : MetroForm
    {
        public DoctorDash()
        {
            InitializeComponent();
        }
        private string doctorName;

        public string DoctorName
        {
            get { return this.doctorName; }
            set { this.doctorName = value; }
        }
        public DoctorDash(string name)
        {
            this.DoctorName = name;
            InitializeComponent();
        }
        private void DoctorDash_Load(object sender, EventArgs e)
        {
            this.lblUser.Text = DoctorName;
        }

        private void DoctorDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var re = new DoctorDashRepo();
            var en = re.Credentials(DoctorName);

            txtId.Text = en.Id;
            txtName.Text = en.Name;
            txtAge.Text = en.Age;
            txtSex.Text = en.Sex;
            txtReference.Text = en.Reference;
            txtAddress.Text = en.Address;
            txtPhone.Text = en.Phone;
            txtSpeciality.Text = en.Speciality;
            txtUsername.Text = en.Username;
            txtPassword.Text = en.Password;
            txtAvailable.Text = en.Availability;
            dtpTime.Text = en.Time;

            pnlProfile.Visible = true;
            pnlDoctor.Visible = false;
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlDoctor.Visible = true;
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
            
            return day;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var re = new DoctorDashRepo();
            var en = new DoctorDashEntity();

            if (ValidateToSave() == true)
            {
                en.Id = txtId.Text;
                en.Name = txtName.Text;
                en.Age = txtAge.Text;
                en.Sex = txtSex.Text;
                en.Reference = txtReference.Text;
                en.Address = txtAddress.Text;
                en.Phone = txtPhone.Text;
                en.Username = txtUsername.Text;
                en.Password = txtPassword.Text;
                en.Time = dtpTime.Value.ToString("hh:mm tt");
                //en.Availability = this.Available();

                if (ckbThr.Checked == false && ckbWed.Checked == false && ckbTue.Checked == false && ckbMon.Checked == false && ckbSun.Checked == false && ckbSat.Checked == false && ckbFri.Checked == false)
                { en.Availability = txtAvailable.Text; }
                else
                { en.Availability = this.Available(); }

                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    re.Update(en);
                }
                //re.Credentials(DoctorName);
                lblUser.Text = en.Username;
                DoctorName = en.Username;

            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnLogoutProfile_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var re = new DoctorDashRepo();
            var en = re.Credentials(DoctorName);

            txtId.Text = en.Id;
            txtName.Text = en.Name;
            txtAge.Text = en.Age;
            txtSex.Text = en.Sex;
            txtReference.Text = en.Reference;
            txtAddress.Text = en.Address;
            txtPhone.Text = en.Phone;
            txtSpeciality.Text = en.Speciality;
            txtUsername.Text = en.Username;
            txtPassword.Text = en.Password;
            txtAvailable.Text = en.Availability;
            dtpTime.Text = en.Time;
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            
            DoctorAppointment dapp = new DoctorAppointment(this,DoctorName);
            this.Hide();
            dapp.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DoctorTest test = new DoctorTest(this);
            this.Hide();
            test.Show();
        }


        private bool ValidateToSave()
        {
            if (Validation.IsStringValid(txtName.Text) && Validation.IsStringValid(txtReference.Text)
                && Validation.IsStringValid(txtAddress.Text) && Validation.IsStringValid(txtUsername.Text) && Validation.IsStringValid(txtPassword.Text)
                && Validation.IsPhoneValid(txtPhone.Text) && Validation.IsIntValid(txtAge.Text))
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
