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
    public partial class AdminDash : MetroForm
    {
        
        private string adminName;
        AdminDashRepo re = new AdminDashRepo();
        public string AdminName
        {
            set { this.adminName = value; }
            get { return this.adminName; }
        }

        public AdminDash()
        {
            InitializeComponent();
        }
        
        public AdminDash(string name)
        {
            this.AdminName = name;
            InitializeComponent();  
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            this.lblUser.Text = AdminName;

            var en = re.Credentials(AdminName);
            
            txtId.Text = en.Id;
            txtName.Text = en.Name;
            txtAge.Text = en.Age;
            txtSex.Text = en.Sex;
            txtReference.Text = en.Reference;
            txtUsername.Text = en.Username;
            txtPassword.Text = en.Password;
            txtAddress.Text = en.Address;
            txtPhone.Text = en.Phone;


        }

        private void AdminDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void addAdmin_Click(object sender, EventArgs e)
        {
            var addAdmin = new AddAdmin(this);
            this.Hide();
            addAdmin.Show();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            var addDoctor = new AddDoctor(this);
            this.Hide();
            addDoctor.Show();
        }

        private void btnAddReceptionist_Click(object sender, EventArgs e)
        {
            var addReceptionist = new AddReceptionist(this);
            this.Hide();
            addReceptionist.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = true;
            pnlMain.Visible = false;
        }

        private void btnLogoutA_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnManageAdmin_Click(object sender, EventArgs e)
        {
            ManageAdmin manage = new ManageAdmin(this);
            this.Hide();
            manage.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ??", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (ValidToUpdate() == true)
                {
                    var en = new AdminDashEntity();
                    var re = new AdminDashRepo();

                    en.Id = txtId.Text;
                    en.Name = txtName.Text;
                    en.Age = txtAge.Text;
                    en.Sex = txtSex.Text;
                    en.Reference = txtReference.Text;
                    en.Phone = txtPhone.Text;
                    en.Username = txtUsername.Text;
                    en.Password = txtPassword.Text;
                    en.Address = txtAddress.Text;

                    re.Update(en);
                    lblUser.Text = en.Username;
                    AdminName = en.Username;
                }
                else
                {
                    MessageBox.Show("Invalid Input.");
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlMain.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnManageDoctor_Click(object sender, EventArgs e)
        {
            ManageDoctor manage = new ManageDoctor(this);
            this.Hide();
            manage.Show();
        }

        private void btnManageReceptionist_Click(object sender, EventArgs e)
        {
            ManageReceptionist receptionist = new ManageReceptionist(this);
            this.Hide();
            receptionist.Show();

        }

        private void btnManageAppointment_Click(object sender, EventArgs e)
        {
            ManageAppointment appointment = new ManageAppointment(this);
            this.Hide();
            appointment.Show();
        }

        private void btnMangeTest_Click(object sender, EventArgs e)
        {
            ManageTest test = new ManageTest(this);
            this.Hide();
            test.Show();
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            Financials financials = new Financials(this);
            this.Hide();
            financials.Show();

        }

        public bool ValidToUpdate()
        {
            if(Validation.IsStringValid(txtName.Text) && Validation.IsIntValid(txtAge.Text)
                && Validation.IsStringValid(txtSex.Text) && Validation.IsStringValid(txtReference.Text)
                && Validation.IsStringValid(txtAddress.Text) && Validation.IsPhoneValid(txtPhone.Text)
                && Validation.IsStringValid(txtUsername.Text) && Validation.IsStringValid(txtPassword.Text))
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
