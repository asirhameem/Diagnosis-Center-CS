using HMSProject.Data_layer;
using HMSProject.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSProject.Repository_Layer
{
    class AddReceptionistRepo
    {
        public String AutoGenerateId()
        {
            var sql = "select isnull(max(cast(increment as int)),0)+1 from receptionist;";
            var data = DataAccess.GetDataTable(sql);
            string id = data.Rows[0][0].ToString();
            return id;
        }

        public void AddReceptionist(AddReceptionistEntity en)
        {
            try
            {
                var sql = "insert into receptionist values ('" + en.GeneratedId + "','" + en.Name + "','" + en.UserName + "','" + en.Password + "','" + en.Age + "','" + en.Address + "','" + en.Sex + "','" + en.Reference + "','" + en.Phone + "');";
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

        public void UpdateInfo(AddReceptionistEntity en)
        {
            var sql = "update receptionist set name= '"+en.Name+ "', age = '"+en.Age+ "', sex = '"+en.Sex+ "',reference = '"+en.Reference+ "',phone = '"+en.Phone+"', address = '" + en.Address+ "', username = '"+en.UserName+ "', password = '"+en.Password+ "' where id = '"+en.GeneratedId+"'; ";
            var ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }

    }
}
