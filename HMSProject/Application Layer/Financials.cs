using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSProject.Repository_Layer;
using MetroFramework.Forms;

namespace HMSProject.Application_Layer
{
    public partial class Financials : MetroForm
    {
        private AdminDash admin;
        FinancialRepo re = new FinancialRepo();
        public Financials(AdminDash dash)
        {
            this.admin = dash;
            InitializeComponent();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFilter.SelectedItem.ToString()=="Today")
            {
                re.SalesToday(mgvResult);
                txtSumTotal.Text = re.SumTotalToday();
            }
            if (cmbFilter.SelectedItem.ToString() == "This Month")
            {
                re.SalesThisMonth(mgvResult);
                txtSumTotal.Text = re.SumTotalMonth();
            }
            if(cmbFilter.SelectedItem.ToString() == "This Week")
            {
                re.SalesThisWeek(mgvResult);
                txtSumTotal.Text = re.SumTotalWeek();
            }
        }

        private void Financials_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            string date = dtpDate.Value.Date.ToString("yyyy-MM-dd");
            re.SalesByDate(mgvResult,date);
            txtSumTotal.Text = re.SumTotalDate(date);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbFilter.Text = "";
            dtpDate.Text = "";
        }

        private void Financials_Load(object sender, EventArgs e)
        {
            re.SalesToday(mgvResult);
        }
    }
}
