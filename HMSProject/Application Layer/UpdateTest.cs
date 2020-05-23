using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSProject.Entity_Layer;
using HMSProject.Repository_Layer;
using MetroFramework.Forms;

namespace HMSProject.Application_Layer
{
    public partial class UpdateTest : MetroForm
    {
        public ReceptionistDash Receptionist
        {
            get;
            set;
        }
        UpdateTestRepo re = new UpdateTestRepo();
        public UpdateTest()
        {
            InitializeComponent();
        }
        public UpdateTest(ReceptionistDash rd)
        {
            this.Receptionist = rd;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var en = new UpdateTestEntity();
            var re = new UpdateTestRepo();

            en.PatientName = txtName.Text;
            en.TestId = txtTestNo.Text;
            en.Date = dtpDate.Value.ToString("yyyy-MM-dd");

            re.Search(mgvUpdateTest,en);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                var en = new UpdateTestEntity();
                var re = new UpdateTestRepo();

                en.TestId = mgvUpdateTest.CurrentRow.Cells["id"].Value.ToString();
                en.PatientName = mgvUpdateTest.CurrentRow.Cells["name"].Value.ToString();
                en.Age = int.Parse(mgvUpdateTest.CurrentRow.Cells["age"].Value.ToString());
                en.Sex = mgvUpdateTest.CurrentRow.Cells["sex"].Value.ToString();
                en.Reference = mgvUpdateTest.CurrentRow.Cells["reference"].Value.ToString();
                en.Date = DateTime.Parse(mgvUpdateTest.CurrentRow.Cells["date"].Value.ToString()).ToString("yyyy-MM-dd");

                re.Update(en, mgvUpdateTest);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                var en = new UpdateTestEntity();
                var re = new UpdateTestRepo();

                en.TestId = mgvUpdateTest.CurrentRow.Cells["id"].Value.ToString();

                re.Delete(en);
                re.LoadAll(mgvUpdateTest);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtTestNo.Text = "";
            this.dtpDate.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist.Show();
            Receptionist.Clear();
        }

        private void UpdateTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateTest_Load(object sender, EventArgs e)
        {
            re.LoadAll(mgvUpdateTest);
            mgvUpdateTest.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            re.LoadAll(mgvUpdateTest);
        }
    }
}
