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
    class ManageTestRepo
    {
        public void Search(ManageTestEntity en,MetroGrid mgv)
        {
            var sql = @"select * from test where 
                        name = '" + en.Name + @"' or
                        id = '" + en.Id + @"' or
                        reference = '" + en.Reference + @"' or
                        date = '" + en.Date + @"';";
            DataAccess.PopulateGridView(mgv, sql); 
        }

        public void LoadAll(MetroGrid mgv)
        {
            var sql = "select * from test; ";
            DataAccess.PopulateGridView(mgv,sql);
        }

        public void Delete(string id)
        {
            var sql = "delete from test where id = '"+id+"';";
            var ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Deleted");
            }
        }

        public void Update(ManageTestEntity en)
        {
            var sql = "update test set name = '" + en.Name + "',age = '" + en.Age + "',sex = '" + en.Sex + "',reference = '" + en.Reference + "',date = '" + en.Date + "',time = '" + en.Time + "' where id = '" + en.Id + "'; ";
                   
            var ex = DataAccess.ExecuteQuery(sql);
            if(ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }


        public void FilterBySex(string sex, MetroGrid mgv)
        {
            var sql = "select * from test where sex = '" + sex + "'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void ChildFilter(MetroGrid mgv)
        {
            var sql = "select * from test where age <='14'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void YouthFilter(MetroGrid mgv)
        {
            var sql = "select * from test where age > '14' and age <= '24'; ";
            DataAccess.PopulateGridView(mgv, sql);

        }

        public void AdultFilter(MetroGrid mgv)
        {
            var sql = "select * from test where age > '24' and age <= '64'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void SeniorFilter(MetroGrid mgv)
        {
            var sql = "select * from test where age >='65'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }






    }
}
