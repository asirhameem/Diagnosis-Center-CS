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
    public partial class Bill : MetroForm
    {
        private Test test;
        private string userName;
        private BillEntity en;
        BillRepo re = new BillRepo();

        

        
        public string Id
        {
            get; set;
        }
        
        public Bill()
        {
            InitializeComponent();
        }
        public Bill(Test t,string id)
        {
            this.test = t;
            this.Id = id;
            this.userName = test.userName;
            InitializeComponent();
            //View(id);
        }
        private void View(string no)
        {
            BillRepo re = new BillRepo();
            BillEntity en = re.Credentials(no);

            txtPatient.Text = en.Name;
            txtAge.Text = en.Age.ToString();
            txtSex.Text = en.Sex;
            txtReference.Text = en.Reference;
            txtTests.Text = en.Tests;
            txtPrice.Text = en.Price;
            txtTotal.Text = en.Total;
            txtDiscount.Text = en.Discount;
            dtpDate.Text = en.Date;
            dtpTime.Text = en.Time;
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            txtTestNo.Text = Id;

            en = re.Credentials(Id);

            txtPatient.Text = en.Name;
            txtAge.Text = en.Age.ToString();
            txtSex.Text = en.Sex;
            txtReference.Text = en.Reference;
            txtTests.Text = en.Tests;
            txtPrice.Text = en.Price;
            txtTotal.Text = en.Total;
            txtDiscount.Text = en.Discount;
            dtpDate.Text = en.Date;
            dtpTime.Text = en.Time;
        }
        


        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ReceptionistDash dash = new ReceptionistDash(userName);
            this.Hide();
            dash.Show();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            test.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BillEntity en = new BillEntity();
            BillRepo re = new BillRepo();
            en.Id = txtTestNo.Text;
            en.Name = txtPatient.Text;
            en.Date = dtpDate.Value.ToString("yyyy-MM-dd");
            en.Age = int.Parse(txtAge.Text);
            en.Sex = txtSex.Text;
            en.Time = dtpTime.Value.ToString("hh:mm tt");
            en.Reference = txtReference.Text;

            re.UpdateOrders(en);
        }
    }
}
