using HMSProject.Data_layer;
using HMSProject.Entity_Layer;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSProject.Repository_Layer
{
    class DoctorUpdateAppRepo
    {

        public void Search(MetroGrid mgv, DoctorUpdateAppEntity entity)
        {
            var sql = "select * from appointment where name = '" + entity.Name + "' or id = '" + entity.AppNo + "' or doctor = '" + entity.Doctor + "'";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void Update(DoctorUpdateAppEntity en, MetroGrid mgv)
        {
            var sql = "update appointment set name = '" + en.Name + "', age = '" + en.Age + "', sex = '" + en.Sex + "', reference = '" + en.Reference + "',doctor = '" + en.Doctor + "', date = '" + en.Date + "',time = '" + en.Time + "' where id = '" + en.AppNo + "';";
            int exe = DataAccess.ExecuteQuery(sql);
            if (exe == 1)
            {
                MessageBox.Show("Updated");
            }
            var query = "select * from appointment where id = '" + en.AppNo + "';";
            DataAccess.PopulateGridView(mgv, query);


        }
       



        public void Delete(DoctorUpdateAppEntity en)
        {
            var sql = "delete from appointment where id ='" + en.AppNo + "'; ";
            int ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Deleted Successful");
            }

        }

        public void LoadAll(MetroGrid mgv)
        {
            var sql = "select * from appointment;";
            DataAccess.PopulateGridView(mgv, sql);
        }


    }
}
