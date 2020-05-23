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
    public partial class ManageAppointment : MetroForm
    {
        private AdminDash admin;

        ManageAppointmentRepo re = new ManageAppointmentRepo();
        public ManageAppointment(AdminDash dash)
        {
            this.admin = dash;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtName.Text = "";
            //this.txtPhone.Text = "";
            this.cmbFilter.SelectedIndex = -1;
            this.dtpDate.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var en = new ManageAppointmentEntity();
            var re = new ManageAppointmentRepo();

            en.Id = txtId.Text;
            en.Name = txtName.Text;
            en.Doctor = txtDoctorName.Text;
            en.Date = dtpDate.Value.Date.ToString("yyyy-MM-dd");

            re.Search(mgvAppointment,en);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var re = new ManageAppointmentRepo();
            string type = cmbFilter.SelectedItem.ToString();
            if (type == "Male" || type == "Female")
            {
                re.FilterBySex(type, mgvAppointment);
            }
            if (type == "Child")
            {
                re.ChildFilter(mgvAppointment);
            }
            if (type == "Youth")
            {
                re.YouthFilter(mgvAppointment);
            }
            if(type == "Adult")
            {
                re.AdultFilter(mgvAppointment);
            }
            if(type == "Senior")
            {
                re.SeniorFilter(mgvAppointment);
            }    

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                var re = new ManageAppointmentRepo();
                var id = mgvAppointment.CurrentRow.Cells["id"].Value.ToString();
                re.Delete(id);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;

            txtAppId.Text = mgvAppointment.CurrentRow.Cells["id"].Value.ToString();
            txtAppName.Text = mgvAppointment.CurrentRow.Cells["name"].Value.ToString();
            txtAppAge.Text = mgvAppointment.CurrentRow.Cells["age"].Value.ToString();
            txtAppSex.Text = mgvAppointment.CurrentRow.Cells["sex"].Value.ToString();
            txtAppReference.Text = mgvAppointment.CurrentRow.Cells["reference"].Value.ToString();
            txtAppDoctor.Text = mgvAppointment.CurrentRow.Cells["doctor"].Value.ToString();
            dtpAppDate.Text = mgvAppointment.CurrentRow.Cells["date"].Value.ToString();
            dtpAppTime.Text = mgvAppointment.CurrentRow.Cells["time"].Value.ToString();

            pnlDetails.Visible = true;
        }

        private void ManageAppointment_Load(object sender, EventArgs e)
        {
            re.LoadAll(mgvAppointment);
            mgvAppointment.ClearSelection();
        }

        private void btnAppBack_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
            pnlDetails.Visible = false;
            re.LoadAll(mgvAppointment);
            mgvAppointment.ClearSelection();
        }

        private void btnAppUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                var re = new ManageAppointmentRepo();
                var en = new ManageAppointmentEntity();
                if (ValidateToSave() == true)
                {
                    en.Id = txtAppId.Text;
                    en.Name = txtAppName.Text;
                    en.Age = int.Parse(txtAppAge.Text);
                    en.Sex = txtAppSex.Text;
                    en.Reference = txtAppReference.Text;
                    en.Doctor = txtAppDoctor.Text;
                    en.Date = dtpAppDate.Value.Date.ToString("yyyy-MM-dd");
                    en.Time = dtpAppTime.Value.ToString("hh:mm tt");
                    re.Update(en);
                   
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
        }

        private void btnAppLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void ManageAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private bool ValidateToSave()
        {
            if (Validation.IsStringValid(txtAppName.Text) && Validation.IsStringValid(txtAppReference.Text)
               
                && Validation.IsStringValid(txtAppDoctor.Text) && Validation.IsIntValid(txtAppAge.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add = new DoctorAddAppointment(this);
            this.Hide();
            add.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
