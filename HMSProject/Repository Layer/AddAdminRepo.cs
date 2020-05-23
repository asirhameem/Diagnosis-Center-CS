using HMSProject.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMSProject.Data_layer;
using System.Windows.Forms;

namespace HMSProject.Repository_Layer
{
    class AddAdminRepo
    {
        public void AddAdmin(AddAdminEntity en)
        {
            try
            {
                var sql = "insert into admin values ('" + en.GeneratedId + "','" + en.Name + "','" + en.Age + "','" + en.Sex + "','" + en.Reference + "','" + en.Address + "','" + en.Phone + "','" + en.UserName + "','" + en.Password + "');";
                int ex = DataAccess.ExecuteQuery(sql);
                if (ex == 1)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occoured");
            }
        }


        public String AutoGenerateId()
        {
            var sql = "select isnull(max(cast(increment as int)),0)+1 from admin;";
            var data = DataAccess.GetDataTable(sql);
            string id = data.Rows[0][0].ToString();
            return id;
        }


        public void UpdateInfo(AddAdminEntity en)
        {
            var sql = "update admin set name= '" + en.Name + "', age = '" + en.Age + "', sex = '" + en.Sex + "',reference = '" + en.Reference + "',phone = '" + en.Phone + "', address = '" + en.Address + "', username = '" + en.UserName + "', password = '" + en.Password + "' where id = '" + en.GeneratedId + "'; ";
            var ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }




    }
}
