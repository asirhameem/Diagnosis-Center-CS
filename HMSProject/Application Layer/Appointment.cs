using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSProject.Data_layer;
using HMSProject.Application_Layer;
using HMSProject.Entity_Layer;
using HMSProject.Repository_Layer;
using MetroFramework.Forms;

namespace HMSProject.Application_Layer
{
    public partial class Appointment : MetroForm
    {
        
        private string patientName;
        private string age;
        private string sex;
        private string reference;
        private string date;
        private string patientDoctor;
        
        private ReceptionistDash re;
        AppointmentRepo repo = new AppointmentRepo();
        AppointmentEntity entity = new AppointmentEntity();
        public string PatientName
        {
            get { return this.patientName; }
            set { this.patientName = value; }
        }

        public string Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public string Reference
        {
            get { return this.reference; }
            set { this.reference = value; }
        }

        public string Date
        {
            get { return this.date; }
            set { date = value;  }
        }
        
        public string PatientDoctor
        {
            get { return this.patientDoctor; }
            set { this.patientDoctor = value; }
        }
        public Appointment()
        {
            InitializeComponent();
        }
        public Appointment(string patientName, string age, string sex, string reference, ReceptionistDash r)
        {
            this.re = r;
            this.PatientName = patientName;
            this.Sex = sex;
            this.Age = age;
            this.Reference = reference;
            
            InitializeComponent();
        }

        private void Appointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

        private void Appointment_Load(object sender, EventArgs e)
        {
            this.lblName.Text = PatientName;
            this.lblAge.Text = Age;
            this.lblSex.Text = Sex;
            this.lblRefer.Text = Reference;
            repo.AppointmentGrid(mgvDoctorAppointment);
            AutoIdGenerate();
            mgvDoctorAppointment.ClearSelection();
        }

        private void AutoIdGenerate()
        {
            var id = repo.IdGenerate();
            entity.PatientId = id;
            this.txtId.Text = entity.PatientId;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void mbtnInsert_Click(object sender, EventArgs e)
        {
            var entity = new AppointmentEntity();
            var repo = new AppointmentRepo();
            //var app = new Appoinment();
            //entity.ConvertToEntity(this);
            entity.GeneratedId = this.txtId.Text;
            entity.PatientName = this.lblName.Text;
            entity.PatientAge = Int32.Parse(this.lblAge.Text);
            entity.PatientSex = this.lblSex.Text;
            entity.PatientReference = this.lblRefer.Text;
            entity.AppoinmentDate = this.mdtAppoinmentDate.Value.Date.ToString("yyyy-MM-dd");
            entity.PatientDoctor = mgvDoctorAppointment.CurrentRow.Cells["name"].Value.ToString();
            entity.Time = this.dtpTime.Value.ToString();
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            { return; }
            else
            {
                repo.InsertAppoinment(entity);
                this.Hide();
                re.Show();
                re.Clear();
            }


        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept = this.cmbDepartment.SelectedItem.ToString();
            //MessageBox.Show(String.Format("{0}", dept));
            repo.AppointmentGridRefresh(mgvDoctorAppointment,dept);
        }

        private void mbtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            re.Show();
            re.Clear();
        }

        
    }
}
