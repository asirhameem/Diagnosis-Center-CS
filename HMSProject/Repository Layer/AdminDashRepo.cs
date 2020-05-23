using HMSProject.Data_layer;
using HMSProject.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSProject.Repository_Layer
{
    class AdminDashRepo
    {

        public AdminDashEntity Credentials(string username)
        {
            var sql = "select * from admin where username = '"+username+"';";
            var data = DataAccess.GetDataTable(sql);
            return this.ConvertToEntity(data.Rows[0]);
        }

        public AdminDashEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            else
            {
                var en = new AdminDashEntity();

                en.Id = row["id"].ToString();
                en.Name = row["name"].ToString();
                en.Age = row["age"].ToString();
                en.Sex = row["sex"].ToString();
                en.Reference = row["reference"].ToString();
                en.Address = row["address"].ToString();
                en.Phone = row["phone"].ToString();
                en.Username = row["username"].ToString();
                en.Password = row["password"].ToString();
                return en;
            }
        }

        public void Update(AdminDashEntity en)
        {
            var sql = "update admin set name = '"+en.Name+ "', age = '"+en.Age+ "', sex = '"+en.Sex+ "',reference = '"+en.Reference+ "', phone ='" + en.Phone + "',address = '" + en.Address + "', username = '" + en.Username + "', password ='" + en.Password + "' where id = '" + en.Id + "'; ";
            var ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }

    }
}
