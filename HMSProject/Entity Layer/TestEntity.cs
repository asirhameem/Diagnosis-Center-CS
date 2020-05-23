using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSProject.Entity_Layer
{
    class TestEntity
    {
        private string patientName;
        private int patientAge;
        private string patientSex;
        private string reference;
        private string date;
        private int discount;
        private string testName;
        private string testId;
        private float price;
        private double total;
        
        public double Total
        {
            get { return this.total; }
            set { this.total = value; }
        }
        public string TestName
        { 
            get { return this.testName; }
            set { this.testName = value; }
            
        }
        public string TestId
        {
            get { return this.testId; }
            set { this.testId ="T-" + value.PadLeft(4,'0'); }
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
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

        public string Sex
        {
            get { return this.patientSex; }
            set { this.patientSex = value; }
        }

        public string Reference
        {
            get { return this.reference; }
            set { this.reference = value; }
        }

        public string Date
        {
            get { return this.date; }
            set { date = value; }
        }
        public int Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }

        public string IdGenerated
        {
            get;
            set;
        }

        public string Time
        {
            get;
            set;
        }
        public string List
        {
            get;
            set;
        }


    }
}