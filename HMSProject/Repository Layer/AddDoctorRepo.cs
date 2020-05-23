using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSProject.Data_layer;
using HMSProject.Entity_Layer;

namespace HMSProject.Repository_Layer
{
    class AddDoctorRepo
    {

        public String AutoGenerateId()
        {
            var sql = "select isnull(max(cast(increment as int)),0)+1 from doctor;";
            var data = DataAccess.GetDataTable(sql);
            string id = data.Rows[0][0].ToString();
            return id;
        }

        public void AddDoctor(AddDoctorEntity en)
        {
            try
            {
                var sql = "insert into doctor values ('" + en.GeneratedId + "','" + en.Name + "','" + en.Age + "','" + en.Sex + "','" + en.Reference + "','" + en.Address + "','" + en.Phone + "','"+en.Speciality+"','" + en.UserName + "','" + en.Password + "','"+en.Available+ "','" + en.Time + "');";
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

        public void UpdateInfo(AddDoctorEntity en)
        {
            var sql = "update doctor set name= '" + en.Name + "', age = '" + en.Age + "', sex = '" + en.Sex + "',reference = '" + en.Reference + "',phone = '" + en.Phone + "', address = '" + en.Address + "',speciality = '"+en.Speciality+"', username = '" + en.UserName + "', password = '" + en.Password + "' ,available = '"+en.Available+"', time = '"+en.Time+"' where id = '" + en.GeneratedId + "'; ";
            var ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }


    }
}
