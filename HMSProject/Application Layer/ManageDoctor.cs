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
    public partial class ManageDoctor : MetroForm
    {
        private AdminDash admin;
        ManageDoctorRepo re = new ManageDoctorRepo();
        public ManageDoctor(AdminDash dash)
        {
            this.admin = dash;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.Show();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbFilter.SelectedItem.ToString();

            var re = new ManageDoctorRepo();
            
            if(type == "Male" || type == "Female")
            {
                re.FilterSex(type,mgvDoctor);
            }
            if(type == "ENT")
            {
                re.FilterSpeciality(type,mgvDoctor);
            }
            if (type == "Skin")
            {
                re.FilterSpeciality(type, mgvDoctor);
            }
            if (type == "Dental")
            {
                re.FilterSpeciality(type, mgvDoctor);
            }
            if (type == "Eye")
            {
                re.FilterSpeciality(type, mgvDoctor);
            }
            if (type == "Arthopedic")
            {
                re.FilterSpeciality(type, mgvDoctor);
            }
            if (type == "Urology")
            {
                re.FilterSpeciality(type, mgvDoctor);
            }
            if (type == "Gynocology")
            {
                re.FilterSpeciality(type, mgvDoctor);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            cmbFilter.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var en = new ManageDoctorEntity();
            var re = new ManageDoctorRepo();
            en.Id = txtId.Text;
            en.Name = txtName.Text;
            en.Phone = txtPhone.Text;
            re.Search(en,mgvDoctor);

        }

        private void ManageDoctor_Load(object sender, EventArgs e)
        {
            re.LoadDoctor(mgvDoctor);
        }

        private void ManageDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDid.Text = mgvDoctor.CurrentRow.Cells["id"].Value.ToString();
            txtDname.Text = mgvDoctor.CurrentRow.Cells["name"].Value.ToString();
            txtDage.Text = mgvDoctor.CurrentRow.Cells["age"].Value.ToString();
            txtDsex.Text = mgvDoctor.CurrentRow.Cells["sex"].Value.ToString();
            txtDreference.Text = mgvDoctor.CurrentRow.Cells["reference"].Value.ToString();
            txtDaddress.Text = mgvDoctor.CurrentRow.Cells["address"].Value.ToString();
            txtDphone.Text = mgvDoctor.CurrentRow.Cells["phone"].Value.ToString();
            txtDspeciality.Text = mgvDoctor.CurrentRow.Cells["speciality"].Value.ToString();
            txtDavailable.Text = mgvDoctor.CurrentRow.Cells["available"].Value.ToString();
            dtpTime.Text = mgvDoctor.CurrentRow.Cells["time"].Value.ToString();

            pnlDoctor.Visible = true;
            pnlMain.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var re = new ManageDoctorRepo();
            string id = mgvDoctor.CurrentRow.Cells["id"].Value.ToString();

            if (mgvDoctor.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a row.");
            }
            else
            {
                if(MessageBox.Show("Are you sure ?","Confirmation",MessageBoxButtons.YesNo)==DialogResult.No)
                {
                    return;
                }
                else
                {
                    
                    re.Delete(id);
                }
            }
        }

        private void btnAback_Click(object sender, EventArgs e)
        {
            pnlDoctor.Visible = false;
            pnlMain.Visible = true;

        }

        private void btnLogoutD_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var en = new ManageDoctorEntity();
            var re = new ManageDoctorRepo();

            en.Id = txtDid.Text;
            en.Name = txtDname.Text;
            en.Age = txtDage.Text;
            en.Sex = txtDsex.Text;
            en.Reference = txtDreference.Text;
            en.Speciality = txtDspeciality.Text;
            en.Available = txtDavailable.Text;
            en.Address = txtDaddress.Text;
            en.Phone = txtDphone.Text;
            en.Time = dtpTime.Value.ToString("hh:mm tt");

            re.Update(en);
        }
    }
}
