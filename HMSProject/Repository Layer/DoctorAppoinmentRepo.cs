using HMSProject.Data_layer;
using HMSProject.Entity_Layer;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSProject.Repository_Layer
{
    class DoctorAppoinmentRepo
    {
        public void Search(DoctorAppoinmentEntity en, MetroGrid grid)
        {
            var sql = "select id,name,age,sex,date,time from appointment where id = '" + en.Id + "' or name = '" + en.Name + "' or date = '" + en.Date + "' or doctor ='" + en.Doctor + "'";
            DataAccess.PopulateGridView(grid, sql);
        }
        public void SexFilter(string sex, MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,date,time from appointment where sex = '" + sex + "';";
            DataAccess.PopulateGridView(mgv, sql);
        }
        public void ChildFilter(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,date,time from appointment where age <='14'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void YouthFilter(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,date,time from appointment where age > '14' and age <= '24'; ";
            DataAccess.PopulateGridView(mgv, sql);

        }

        public void AdultFilter(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,date,time from appointment where age > '24' and age <= '64'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void SeniorFilter(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,date,time from appointment where age >='65'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }
        public String DocName(string user)
        {
            var sql = "select name from doctor where username = '"+user+"'";
            var data = DataAccess.GetDataTable(sql);
            string dname = data.Rows[0][0].ToString();
            return dname;

        }
        public void AllAppointments(MetroGrid mgv,string username)
        {
            string doc = DocName(username);
            var sql = "select id,name,age,sex,date,time from appointment where doctor = '"+doc+ "' and date = CONVERT(date, getdate());";
            DataAccess.PopulateGridView(mgv,sql); ;
        }
    }
}
