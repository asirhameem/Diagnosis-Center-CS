using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Schema;
using HMSProject.Application_Layer;

namespace HMSProject.Entity_Layer
{
    class AppointmentEntity
    {
        private string patientId;
        private string patientName;
        private int patientAge;
        private string patientSex;
        private string patientReference;
        private  string appoinmentDate;
        private string patientDoctor;

        public string PatientId
        {
            get { return this.patientId; }
            set { this.patientId = "P-" + value.PadLeft(4, '0'); }
        }
        public string PatientName
        {
            get { return this.patientName; }
            set { this.patientName = value; }
        }
        public int PatientAge
        {
            get { return this.patientAge; }
            set { this.patientAge = value; }
        }
        public string PatientSex
        {
            get { return this.patientSex; }
            set { this.patientSex = value; }
        }
        public string PatientReference
        {
            get { return this.patientReference; }
            set { this.patientReference = value; }
        }

        public string AppoinmentDate
        {
            get { return appoinmentDate; }
            set { this.appoinmentDate = value; }
        }
        public string PatientDoctor
        {
            get { return this.patientDoctor; }
            set { this.patientDoctor = value; }
        }
        public string GeneratedId
        {
            get;
            set;
        }

        public string Time
        {
            get; set;
        }

        public void ConvertToEntity(Appointment a)
        {
            this.PatientName = a.PatientName;
            this.PatientAge = int.Parse(a.Age);
            this.PatientSex = a.Sex;
            this.PatientReference = a.Reference;
            this.AppoinmentDate = a.Date;
            this.PatientDoctor = a.PatientDoctor;

        }
    }
}
