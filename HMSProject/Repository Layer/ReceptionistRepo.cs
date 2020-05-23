using HMSProject.Application_Layer;
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
    class ReceptionistRepo
    {

        public ReceptionistEntity Credentials(string username)
        {
            var query = "select * from receptionist where username = '" + username +"';";
            var data = DataAccess.GetDataTable(query);
            return this.ConvertToEntity(data.Rows[0]);


        }

        public ReceptionistEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            else
            {
                ReceptionistEntity en = new ReceptionistEntity();

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

        public void Update(ReceptionistEntity en)
        {
            var query = "update receptionist set name = '"+en.Name+"', age = '"+en.Age+"', sex = '"+en.Sex+"', reference = '"+en.Reference+"', address = '"+en.Address+"', username = '"+en.Username+"', password = '"+en.Password+"' where id = '"+en.Id+"'; ";
            var ex = DataAccess.ExecuteQuery(query);
            if (ex == 1)
            {
                MessageBox.Show("Updated");
            }

        }



    }
}
