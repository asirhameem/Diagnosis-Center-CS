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
    class DoctorTestRepo
    {
        public void LoadAll(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,tests,date,time from test;";
            DataAccess.PopulateGridView(mgv,sql);
        }

        public void Search(DoctorTestEntity en, MetroGrid grid)
        {
            var sql = "select id,name,age,sex,tests,date,time from test where id = '" + en.Id + "' or name = '" + en.Name + "' or date = '" + en.Date + "'";
            DataAccess.PopulateGridView(grid, sql);
        }
        public void SexFilter(string sex, MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,tests,date,time from test where sex = '" + sex + "';";
            DataAccess.PopulateGridView(mgv, sql);
        }
        public void ChildFilter(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,tests,date,time from test where age <='14'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void YouthFilter(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,tests,date,time from test where age > '14' and age <= '24'; ";
            DataAccess.PopulateGridView(mgv, sql);

        }

        public void AdultFilter(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,tests,date,time from test where age > '24' and age <= '64'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void SeniorFilter(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,tests,date,time from test where age >='65'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

    }
}
