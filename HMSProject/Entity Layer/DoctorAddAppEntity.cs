using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSProject.Entity_Layer
{
    class DoctorAddAppEntity
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { this.id = "P-" + value.PadLeft(4, '0'); }
        }

        public string AutoId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Sex
        {
            get;
            set;
        }
        public string Reference
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }
        public string Time
        {
            get;
            set;
        }
        public string Doctor
        {
            get;
            set;
        }

    }
}
