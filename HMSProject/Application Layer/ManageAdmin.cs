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
using HMSProject.Validation_Layer;
using MetroFramework.Forms;

namespace HMSProject.Application_Layer
{
    public partial class ManageAdmin : MetroForm
    {
        private AdminDash adminDash;
        ManageAdminRepo re = new ManageAdminRepo();

        public ManageAdmin(AdminDash dash)
        {
            this.adminDash = dash;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var en = new ManageAdminEntity();
            var re = new ManageAdminRepo();
            if (ValidateToSave() == true)
            {
                en.Id = txtId.Text;
                en.Name = txtName.Text;
                en.Phone = txtPhone.Text;

                re.Search(en, mgvAdmin);
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDash.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (mgvAdmin.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a row first");
            }
            else
            {
                txtAid.Text = mgvAdmin.CurrentRow.Cells["id"].Value.ToString();
                txtAname.Text = mgvAdmin.CurrentRow.Cells["name"].Value.ToString();
                txtAage.Text = mgvAdmin.CurrentRow.Cells["age"].Value.ToString();
                txtAsex.Text = mgvAdmin.CurrentRow.Cells["sex"].Value.ToString();
                txtAreference.Text = mgvAdmin.CurrentRow.Cells["reference"].Value.ToString();
                txtAaddress.Text = mgvAdmin.CurrentRow.Cells["address"].Value.ToString();
                txtAphone.Text = mgvAdmin.CurrentRow.Cells["phone"].Value.ToString();

                pnlEdit.Visible = true;
                pnlMain.Visible = false;
            }
        }

        private void btnAback_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            pnlMain.Visible = true;
        }

        private void btnAlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(mgvAdmin.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a row first.");
            }
            else
            {
                var en = new ManageAdminEntity();
                var re = new ManageAdminRepo();

                en.Id = mgvAdmin.CurrentRow.Cells["id"].Value.ToString();
                
                if(MessageBox.Show("Are you sure ??", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    re.Delete(en);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var en = new ManageAdminEntity();
            var re = new ManageAdminRepo();
            if (ValidateToUpdate() == true)
            {
                en.Id = txtAid.Text;
                en.Name = txtAname.Text;
                en.Age = txtAage.Text;
                en.Sex = txtAsex.Text;
                en.Reference = txtAreference.Text;
                en.Phone = txtAphone.Text;
                en.Address = txtAaddress.Text;

                if (MessageBox.Show("Are you sure ??", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    re.Update(en);
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void ManageAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            re.LoadAll(mgvAdmin);
        }

        private bool ValidateToSave()
        {
            if (Validation.IsStringValid(txtName.Text) || Validation.IsPhoneValid(txtPhone.Text) || Validation.IsStringValid(txtId.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool ValidateToUpdate()
        {
            if (Validation.IsStringValid(txtAname.Text) && Validation.IsStringValid(txtAreference.Text)
                && Validation.IsStringValid(txtAaddress.Text) 
                && Validation.IsPhoneValid(txtAphone.Text) && Validation.IsIntValid(txtAage.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
