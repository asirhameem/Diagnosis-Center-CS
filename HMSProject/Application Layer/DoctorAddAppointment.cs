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
    public partial class DoctorAddAppointment : MetroForm
    {
        private DoctorAppointment appointment;
        private ManageAppointment adminApp;

        DoctorAddAppEntity en = new DoctorAddAppEntity();
        DoctorAddAppRepo re = new DoctorAddAppRepo();

        public DoctorAddAppointment(DoctorAppointment dapp)
        {
            this.appointment = dapp;
            //this.btnBack.Visible = true;
            InitializeComponent();
            this.btnBack.Visible = true;
        }

        public DoctorAddAppointment(ManageAppointment appointment)
        {
            this.adminApp = appointment;
            //this.btnAdminBack.Visible = true;
            InitializeComponent();
            this.btnAdminBack.Visible = true;
        }

        public void IdGenerate ()
        {
            string id = re.AutoGenerateId();
            en.Id = id;
            txtId.Text = en.Id;
        }

        private void DoctorAddAppointment_Load(object sender, EventArgs e)
        {
            IdGenerate();
            re.LoadDoctor(mgvDoctor);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var en = new DoctorAddAppEntity();
            var re = new DoctorAddAppRepo();
            if (ValidateToSave() == true)
            {
                en.AutoId = txtId.Text;
                en.Name = txtName.Text;
                en.Age = int.Parse(txtAge.Text);
                en.Sex = cmbSex.SelectedItem.ToString();
                en.Reference = txtReference.Text;
                en.Date = dtpDate.Value.Date.ToString("yyyy-MM-dd");
                en.Doctor = mgvDoctor.CurrentRow.Cells["name"].Value.ToString();
                en.Time = dtpTime.Value.ToString("hh:mm tt");

                re.InsertAppoinment(en);
                IdGenerate();
                Clear();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            appointment.Show();
        }

        private void DoctorAddAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtName.Text = "";
            txtReference.Text = "";
            cmbSex.SelectedIndex = -1;
            //dtpDate.Value.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Clear ()
        {
            txtAge.Text = "";
            txtName.Text = "";
            txtReference.Text = "";
            cmbSex.SelectedIndex = -1;
        }
        private bool ValidateToSave()
        {
            if (Validation.IsStringValid(txtName.Text) && Validation.IsStringValid(txtReference.Text)
                
                && Validation.IsComboBoxValid(cmbSex) && Validation.IsIntValid(txtAge.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminApp.Show();
        }
    }
}
