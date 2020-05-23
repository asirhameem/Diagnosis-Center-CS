using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSProject.Entity_Layer
{
    class UserLoginEntity
    {
        private string userName;
        private string userPass;

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string UserPass
        {
            get { return this.userPass; }
            set { this.userPass = value; }
        }
    }
}
