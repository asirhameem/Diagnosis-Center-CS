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
    class ManageAppointmentRepo
    {
        public void LoadAll(MetroGrid mgv)
        {
            var sql = "select * from appointment;";
            DataAccess.PopulateGridView(mgv,sql);
        }

        public void Search(MetroGrid mgv, ManageAppointmentEntity en)
        {
            var sql = "select * from appointment where id = '"+en.Id+ "' or name = '" + en.Name + "' or date = '" + en.Date + "' or doctor = '"+en.Doctor+"'; ";
            DataAccess.PopulateGridView(mgv,sql);
        }

        public void FilterBySex(string sex,MetroGrid mgv)
        {
            var sql = "select * from appointment where sex = '" + sex + "'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void ChildFilter(MetroGrid mgv)
        {
            var sql = "select * from appointment where age <='14'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void YouthFilter(MetroGrid mgv)
        {
            var sql = "select * from appointment where age > '14' and age <= '24'; ";
            DataAccess.PopulateGridView(mgv, sql);

        }

        public void AdultFilter(MetroGrid mgv)
        {
            var sql = "select * from appointment where age > '24' and age <= '64'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void SeniorFilter(MetroGrid mgv)
        {
            var sql = "select * from appointment where age >='65'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void Delete(string id)
        {
            var sql = "delete from appointment where id = '" + id + "';";
            var ex = DataAccess.ExecuteQuery(sql);
            if(ex == 1 )
            {
                MessageBox.Show("Deleted");
            }
        }

        public void Update(ManageAppointmentEntity en)
        {
            var sql = "update appointment set name = '" + en.Name + "',age= '" + en.Age + "',sex = '" + en.Sex + "',reference = '" + en.Reference + "',date = '" + en.Date + "',doctor ='" + en.Doctor + "',time = '" + en.Time + "' where id = '" + en.Id + "'; ";
            var ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }




    }
}
