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
    public partial class ManageTest : MetroForm
    {
        private AdminDash admin;
        ManageTestRepo re = new ManageTestRepo();
        public ManageTest(AdminDash dash)
        {
            this.admin = dash;
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtReference.Text = "";
            cmbFilter.SelectedIndex = -1;
            dtpDate.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var en = new ManageTestEntity();
            var re = new ManageTestRepo();

            en.Id = txtId.Text;
            en.Reference = txtReference.Text;
            en.Name = txtName.Text;
            en.Date = dtpDate.Value.ToString("yyyy-MM-dd");

            re.Search(en, mgvTest);
        }

        private void ManageTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.Show();
        }

        private void ManageTest_Load(object sender, EventArgs e)
        {
            re.LoadAll(mgvTest);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.YesNo)== DialogResult.No)
            { return; }
            else
            {
                var re = new ManageTestRepo();
                string id = mgvTest.CurrentRow.Cells["id"].Value.ToString();
                re.Delete(id);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;

            txtTestId.Text = mgvTest.CurrentRow.Cells["id"].Value.ToString();
            txtTestName.Text = mgvTest.CurrentRow.Cells["name"].Value.ToString();
            txtTestAge.Text = mgvTest.CurrentRow.Cells["age"].Value.ToString();
            txtTestSex.Text = mgvTest.CurrentRow.Cells["sex"].Value.ToString();
            txtTestReference.Text = mgvTest.CurrentRow.Cells["reference"].Value.ToString();
            txtTests.Text = mgvTest.CurrentRow.Cells["tests"].Value.ToString();
            dtpTestDate.Text = mgvTest.CurrentRow.Cells["date"].Value.ToString();
            dtpTestTime.Text = mgvTest.CurrentRow.Cells["time"].Value.ToString();
            txtPrice.Text = mgvTest.CurrentRow.Cells["price"].Value.ToString();
            txtDiscount.Text = mgvTest.CurrentRow.Cells["discount"].Value.ToString();
            txtTotal.Text = mgvTest.CurrentRow.Cells["total"].Value.ToString();

            pnlDetails.Visible = true;
        }

        private void btnTestUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.YesNo)==DialogResult.No)
            { return; }
            else 
            {
                var en = new ManageTestEntity();
                var re = new ManageTestRepo();

                en.Id = txtTestId.Text;
                en.Name = txtTestName.Text;
                en.Age = int.Parse(txtTestAge.Text);
                en.Sex = txtTestSex.Text;
                en.Reference = txtTestReference.Text;
                en.Date = dtpTestDate.Value.ToString("yyyy-MM-dd");
                en.Time = dtpTestTime.Value.ToString("hh:mm tt");

                re.Update(en);
            }
        }

        private void btnTestBack_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlMain.Visible = true;
            re.LoadAll(mgvTest);
        }

        private void btnTestLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var re = new ManageTestRepo();
            string type = cmbFilter.SelectedItem.ToString();
            if (type == "Male" || type == "Female")
            {
                re.FilterBySex(type, mgvTest);
            }
            if (type == "Child")
            {
                re.ChildFilter(mgvTest);
            }
            if (type == "Youth")
            {
                re.YouthFilter(mgvTest);
            }
            if (type == "Adult")
            {
                re.AdultFilter(mgvTest);
            }
            if (type == "Senior")
            {
                re.SeniorFilter(mgvTest);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
