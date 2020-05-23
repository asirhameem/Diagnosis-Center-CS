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
    public partial class Test : MetroForm
    {
        private string patientName;
        private string age;
        private string sex;
        private string reference;
        public string userName;
        private ReceptionistDash re;
        
        TestEntity tn = new TestEntity();
        TestRepo tr = new TestRepo();

        
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
        
        public Test()
        {
            
            InitializeComponent();
        }

        public Test(string name , string age, string sex, string reference, ReceptionistDash r)
        {
            this.re = r;
            this.PatientName = name;
            this.Age = age;
            this.Sex = sex;
            this.Reference = reference;
            this.userName = r.UserName;
            InitializeComponent();
            //AutoGenerateId();
        }

       

        private void Test_Load(object sender, EventArgs e)
        {
            AutoGenerateId();
            this.lblName.Text = PatientName;
            this.lblAge.Text = Age;
            this.lblSex.Text = Sex;
            this.lblReference.Text = Reference;
        }

        private void AutoGenerateId()
        {
            var i = tr.LoadId();
            tn.TestId = i;
            mtxtTestId.Text = tn.TestId; 
        }

        private void mbtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            re.Show();
            re.Clear();

        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mbtnAddToCart_Click(object sender, EventArgs e)
        {
            
        }
        private double CalculateBill(double price, double discount)
        {
            double total;
            double convert = discount / 100;
            double dis = price * convert;
            total = price - dis;
            return total;
        }
        public void ClearBoxes()
        {
            AutoGenerateId();
            cmbTest.Text = "";
            mtxtDiscount.Text = "";
            mtxtTestPrice.Text = "";
        }
        private void mbtnGenerateInovice_Click(object sender, EventArgs e)
        {
            if (mgvCart.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select Test");
            }
            else
            {
                var en = new TestEntity();
                var re = new TestRepo();

                en.IdGenerated = mtxtTestId.Text;
                en.PatientName = this.PatientName;
                en.PatientAge = int.Parse(this.Age);
                en.Sex = this.Sex;
                en.Reference = this.Reference;

                if (this.mtxtDiscount.Text == "")
                {
                    en.Discount = 0;
                }
                else
                {
                    en.Discount = int.Parse(this.mtxtDiscount.Text.Trim());
                }

                var pay = re.MakeBill();
                var dis = en.Discount;
                en.Total = CalculateBill(pay, dis);
                en.Date = dtpDate.Value.ToString("yyyy-MM-dd");
                en.Time = dtpTime.Value.ToString("hh:mm tt");

                re.InsertToOrder(en);
                re.ClearCart();
                re.RefreshCart(mgvCart);

                var bill = new Bill(this, mtxtTestId.Text);
                this.Hide();
                ClearBoxes();
                bill.Show();
            }
        }
        

        private void cmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTest.SelectedItem.ToString().Equals("CBC"))
            {
                this.mtxtTestPrice.Text = "550";
            }
            else if(cmbTest.SelectedItem.ToString().Equals("HEMATOLOGY"))
            {
                this.mtxtTestPrice.Text = "600";
            }
            else if(cmbTest.SelectedItem.ToString().Equals("URINE"))
            {
                this.mtxtTestPrice.Text = "500";
            }
            else if(cmbTest.SelectedItem.ToString().Equals("BLOOD"))
            {
                this.mtxtTestPrice.Text = "500";
            }
            else if(cmbTest.SelectedItem.ToString().Equals("ULTRASONOGRAM"))
            {
                this.mtxtTestPrice.Text = "700";
            }
            else if(cmbTest.SelectedItem.ToString().Equals("X-RAY"))
            {
                this.mtxtTestPrice.Text = "450";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mgvCart.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select the specific test");
            }
            else
            {
                var en = new TestEntity();
                var re = new TestRepo();
                en.TestName = mgvCart.CurrentRow.Cells["name"].Value.ToString();
                re.DeleteItem(en);
                re.RefreshCart(mgvCart);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var repository = new TestRepo();
            var grid = new Test();
            repository.ClearCart();
            repository.RefreshCart(mgvCart);
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            if (this.mtxtTestPrice.Text == "" || this.cmbTest.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Test First");
            }
            else
            {
                var en = new TestEntity();
                var repo = new TestRepo();

                en.TestName = this.cmbTest.Text.Trim();
                en.TestId = this.mtxtTestId.Text.Trim();
                en.Price = float.Parse(this.mtxtTestPrice.Text.Trim());
                en.Date = this.dtpDate.Value.Date.ToString("yyyy-MM-dd");
                //en.Discount = iRnt.Parse(this.mtxtDiscount.Text.Trim());

                repo.AddToCart(en);
                repo.RefreshCart(mgvCart);
            }
        }
    }
}
