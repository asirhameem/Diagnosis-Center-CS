﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSProject.Entity_Layer
{
    class AddAdminEntity
    {
        private string adminId;
        public string AdminId
        {
            get { return adminId; }
            set { this.adminId = "A-" + value.PadLeft(4, '0'); }
        }
        public string GeneratedId
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
        public string Address
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
    }
}
