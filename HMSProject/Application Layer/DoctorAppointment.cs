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
using MetroFramework.Forms;

namespace HMSProject.Application_Layer
{
    public partial class DoctorAppointment : MetroForm
    {
        private DoctorDash dd;
        DoctorAppoinmentRepo repo = new DoctorAppoinmentRepo();
        private string docName;
        public DoctorAppointment(DoctorDash dash,string doc)
        {
            this.dd = dash;
            this.docName = doc;
            InitializeComponent();
        }

        private void DoctorAppointment_Load(object sender, EventArgs e)
        {

            repo.AllAppointments(mgvAppointment,docName);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var en = new DoctorAppoinmentEntity();
            var re = new DoctorAppoinmentRepo();

            en.Name = txtName.Text;
            en.Id = txtId.Text;
            en.Date = dtpDate.Value.ToString("yyyy-MM-dd");
            en.Doctor = txtDoctorName.Text;

            re.Search(en, mgvAppointment);
        }

        private void DoctorAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbFilter.SelectedItem.ToString();

            var re = new DoctorAppoinmentRepo();
            
            if(type == "Male" || type == "Female")
            {
                re.SexFilter(type,mgvAppointment);
            }
            else if (type == "Child")
            {
                re.ChildFilter(mgvAppointment);
            }
            else if (type == "Youth")
            {
                re.YouthFilter(mgvAppointment);
            }
            else if (type == "Adult")
            {
                re.AdultFilter(mgvAppointment);
            }
            else if (type == "Senior")
            {
                re.SeniorFilter(mgvAppointment);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            dd.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorUpdateAppointment upapp = new DoctorUpdateAppointment(this);
            this.Hide();
            upapp.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpDate.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            cmbFilter.SelectedIndex = -1;
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorAddAppointment addApp = new DoctorAddAppointment(this);
            this.Hide();
            addApp.Show();
        }
    }
}
