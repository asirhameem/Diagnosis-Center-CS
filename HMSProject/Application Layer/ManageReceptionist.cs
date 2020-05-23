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
    public partial class ManageReceptionist : MetroForm
    {
        private AdminDash admin;
        ManageReceptionistRepo re = new ManageReceptionistRepo();
        public ManageReceptionist(AdminDash dash)
        {
            this.admin = dash;
            InitializeComponent();
        }

        private void btnRback_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlMain.Visible = true;
            re.LoadAll(mgvReceptionist);
            mgvReceptionist.ClearSelection();
        }

        private void btnRupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                var en = new ManageReceptionistEntity();
                var re = new ManageReceptionistRepo();
                en.Id = txtRid.Text;
                en.Name = txtRname.Text;
                en.Age = txtRage.Text;
                en.Sex = txtRsex.Text;
                en.Reference = txtRreference.Text;
                en.Address = txtRaddress.Text;
                en.Phone = txtRphone.Text;

                re.Update(en);
            }
        }

        private void btnLogoutR_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Show();
            login.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtName.Text = "";
            this.txtPhone.Text = "";
            this.cmbFilter.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var en = new ManageReceptionistEntity();
            var re = new ManageReceptionistRepo();

            en.Id = txtId.Text;
            en.Name = txtName.Text;
            en.Phone = txtPhone.Text;

            re.Search(en,mgvReceptionist);
            mgvReceptionist.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mgvReceptionist.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select a row first");
            }
            else
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    string id = mgvReceptionist.CurrentRow.Cells["id"].Value.ToString();
                    re.Delete(id);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;

            txtRid.Text = mgvReceptionist.CurrentRow.Cells["id"].Value.ToString();
            txtRname.Text = mgvReceptionist.CurrentRow.Cells["name"].Value.ToString();
            txtRage.Text = mgvReceptionist.CurrentRow.Cells["age"].Value.ToString();
            txtRsex.Text = mgvReceptionist.CurrentRow.Cells["sex"].Value.ToString();
            txtRreference.Text = mgvReceptionist.CurrentRow.Cells["reference"].Value.ToString();
            txtRaddress.Text = mgvReceptionist.CurrentRow.Cells["address"].Value.ToString();
            txtRphone.Text = mgvReceptionist.CurrentRow.Cells["phone"].Value.ToString();

            pnlDetails.Visible = true;
        }

        private void ManageReceptionist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManageReceptionist_Load(object sender, EventArgs e)
        {
            re.LoadAll(mgvReceptionist);
            mgvReceptionist.ClearSelection();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbFilter.SelectedItem.ToString();

            if(type == "Male" || type == "Female")
            {
                re.FilterBySex(type, mgvReceptionist);
            }
        }
    }
}
