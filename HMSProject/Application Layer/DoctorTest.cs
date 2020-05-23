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
    public partial class DoctorTest : MetroForm
    {
        private DoctorDash dd;
        DoctorTestRepo repo = new DoctorTestRepo();
        public DoctorTest(DoctorDash dash)
        {
            this.dd = dash;
            InitializeComponent();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbFilter.SelectedItem.ToString();

            var re = new DoctorTestRepo();

            if (type == "Male" || type == "Female")
            {
                re.SexFilter(type, mgvTest);
            }
            else if (type == "Child")
            {
                re.ChildFilter(mgvTest);
            }
            else if (type == "Youth")
            {
                re.YouthFilter(mgvTest);
            }
            else if (type == "Adult")
            {
                re.AdultFilter(mgvTest);
            }
            else if (type == "Senior")
            {
                re.SeniorFilter(mgvTest);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            dd.Show();
        }

        private void DoctorTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DoctorTest_Load(object sender, EventArgs e)
        {
            repo.LoadAll(mgvTest);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //var sql = "select id,name,age,sex,tests,date,time from test where id ";
            var en = new DoctorTestEntity();
            var re = new DoctorTestRepo();

            en.Id = txtId.Text;
            en.Name = txtName.Text;
            en.Date = dtpDate.Value.ToString("yyyy-MM-dd");

            re.Search(en,mgvTest);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            dtpDate.Text = "";
            cmbFilter.SelectedIndex = -1;
        }
    }
}
