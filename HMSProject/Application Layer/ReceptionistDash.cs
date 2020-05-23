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
    public partial class ReceptionistDash : MetroForm
    {
        
        private string userName;

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public ReceptionistDash()
        {
            InitializeComponent();
        }

        public ReceptionistDash(string name)
        {
            this.UserName = name;
            //this.lblUser.Text = name;
            InitializeComponent();  
        }

        


        private void ReciptionistDash_Load(object sender, EventArgs e)
        {
            this.lblUser.Text = UserName;
            
        }

        private void ReciptionistDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void makeAppointment_Click(object sender, EventArgs e)
        {
            if (ValidateToSavePatient() == true)
            {
                if (txtPatientName.Text == "" || txtReference.Text == "")
                {
                    MessageBox.Show("Please Fill Up");
                }
                else
                {
                    this.Hide();
                    var appoinment = new Appointment(txtPatientName.Text, txtAge.Text, cmbSex.SelectedItem.ToString(), txtReference.Text, this);
                    appoinment.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please Fill Up Correctly.");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (ValidateToSavePatient() == true)
            {
                if (txtPatientName.Text == "" || txtReference.Text == "")
                {
                    MessageBox.Show("Please Fill Up");
                }
                else
                {
                    this.Hide();
                    var test = new Test(txtPatientName.Text, txtAge.Text, cmbSex.SelectedItem.ToString(), txtReference.Text, this);
                    //var test = new Test(this);
                    test.Show();
                }
            }
            else
            {
                MessageBox.Show("Please Fill Up Correctly");
            }
        }

        private void appoinmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var upApp = new UpdateAppoinment(this);
            this.Hide();
            upApp.Show();
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var updateTest = new UpdateTest(this);
            this.Hide();
            updateTest.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //pnlProfile.Visible = true;
            var re = new ReceptionistRepo();
            var en = re.Credentials(UserName);

            txtRname.Text = en.Name;
            txtRage.Text = en.Age;
            txtRsex.Text = en.Sex;
            txtRreference.Text = en.Reference;
            txtRaddress.Text = en.Address;
            txtRphone.Text = en.Phone;
            txtRusername.Text = en.Username;
            txtRpassword.Text = en.Password;
            txtRid.Text = en.Id;

            pnlProfile.Visible = true;

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlMain.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var en = new ReceptionistEntity();
            var re = new ReceptionistRepo();
            if (ValidateToSave() == true)
            {
                en.Id = txtRid.Text;
                en.Name = txtRname.Text;
                en.Age = txtRage.Text;
                en.Sex = txtRsex.Text;
                en.Reference = txtRreference.Text;
                en.Address = txtRaddress.Text;
                en.Phone = txtRphone.Text;
                en.Username = txtRusername.Text;
                en.Password = txtRpassword.Text;
                if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    re.Update(en);
                }
                UserName = en.Username;
                lblUser.Text = en.Username;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnLogoutMain_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        public void Clear()
        {
            txtPatientName.Text = "";
            txtAge.Text = "";
            cmbSex.SelectedIndex = -1;
            txtReference.Text = "";
        }


        private bool ValidateToSave()
        {
            if (Validation.IsStringValid(txtRname.Text) && Validation.IsStringValid(txtRreference.Text)
                && Validation.IsStringValid(txtRaddress.Text) && Validation.IsStringValid(txtRusername.Text) && Validation.IsStringValid(txtRpassword.Text)
                && Validation.IsPhoneValid(txtRphone.Text) && Validation.IsIntValid(txtRage.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool ValidateToSavePatient()
        {
            if (Validation.IsIntValid(txtAge.Text) && Validation.IsComboBoxValid(cmbSex))
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
