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
    class DoctorDashRepo
    {

        public DoctorDashEntity Credentials(string username)
        {
            var query = "select * from doctor where username = '"+username+"'";
            var data = DataAccess.GetDataTable(query);
            return this.ConvertToEntity(data.Rows[0]);

        }

        public DoctorDashEntity ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            else
            {
                var en = new DoctorDashEntity();

                en.Id = row["id"].ToString();
                en.Name = row["name"].ToString();
                en.Age = row["age"].ToString();
                en.Sex = row["sex"].ToString();
                en.Reference = row["reference"].ToString();
                en.Address = row["address"].ToString();
                en.Phone = row["phone"].ToString();
                en.Speciality = row["speciality"].ToString();
                en.Username = row["username"].ToString();
                en.Password = row["password"].ToString();
                en.Availability = row["available"].ToString();
                en.Time = row["time"].ToString();

                return en;
            }
        }

        public void Update(DoctorDashEntity en)
        {
            var sql = "update doctor set name ='"+en.Name+ "', age ='"+en.Age+ "', sex='"+en.Sex+ "', reference='"+en.Reference+ "', address ='"+en.Address+ "', phone ='"+en.Phone+ "', username ='"+en.Username+ "', password ='"+en.Password+ "', available ='"+en.Availability+ "', time ='"+en.Time+ "' where id ='"+en.Id+"'; ";
            var ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }

        
       
    }
}
