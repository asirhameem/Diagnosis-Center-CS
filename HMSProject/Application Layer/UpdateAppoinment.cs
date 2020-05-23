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
    public partial class UpdateAppoinment : MetroForm
    {
        public ReceptionistDash Rdash
        {
            get;
            set;
        }
        UpdateAppointmentRepo repo = new UpdateAppointmentRepo();
        public UpdateAppoinment()
        {
            InitializeComponent();
        }
        public UpdateAppoinment(ReceptionistDash rd)
        {
            this.Rdash = rd;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var re = new UpdateAppointmentRepo();
            var en = new UpdateAppointmentEntity();
            en.Name = txtName.Text;
            en.Doctor = txtDoctor.Text;
            en.AppNo = txtAppointment.Text;
            re.Search(mgvUpdateAppoinment, en);

        }


        private void UpdateAppoinment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var en = new UpdateAppointmentEntity();
            var re = new UpdateAppointmentRepo();
            
            en.Name = mgvUpdateAppoinment.CurrentRow.Cells["name"].Value.ToString();
            en.Age = int.Parse(mgvUpdateAppoinment.CurrentRow.Cells["age"].Value.ToString());
            en.Sex = mgvUpdateAppoinment.CurrentRow.Cells["sex"].Value.ToString();
            en.Reference = mgvUpdateAppoinment.CurrentRow.Cells["reference"].Value.ToString();
            en.Date = mgvUpdateAppoinment.CurrentRow.Cells["date"].Value.ToString();
            en.AppNo = mgvUpdateAppoinment.CurrentRow.Cells["id"].Value.ToString();
            en.Time = mgvUpdateAppoinment.CurrentRow.Cells["time"].Value.ToString();
            en.Doctor = mgvUpdateAppoinment.CurrentRow.Cells["doctor"].Value.ToString();

            re.Update(en,mgvUpdateAppoinment);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var en = new UpdateAppointmentEntity();
            var re = new UpdateAppointmentRepo();

            en.AppNo = this.mgvUpdateAppoinment.CurrentRow.Cells["id"].Value.ToString();
            re.Delete(en);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAppointment.Text = "";
            this.txtDoctor.Text = "";
            this.txtName.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rdash.Show();
        }

        private void UpdateAppoinment_Load(object sender, EventArgs e)
        {
            repo.LoadAll(mgvUpdateAppoinment);
        }
    }
}
