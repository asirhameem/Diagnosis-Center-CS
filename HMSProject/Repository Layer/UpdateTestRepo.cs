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
    class UpdateTestRepo
    {
        public void Search(MetroGrid mgv, UpdateTestEntity entity)
        {
            var sql = "select * from test where name = '" + entity.PatientName + "' or id = '" + entity.TestId + "' or date = '"+entity.Date+"'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }


        public void Update(UpdateTestEntity en, MetroGrid mgv)
        {
            var sql = "update test set name = '" + en.PatientName + "', age = '" + en.Age + "', sex = '" + en.Sex + "', reference = '" + en.Reference + "', date = '" + en.Date + "' where id = '" + en.TestId + "';";
            int exe = DataAccess.ExecuteQuery(sql);
            if (exe >= 1)
            {
                MessageBox.Show("Updated");
            }
            var query = "select * from test where id = '" + en.TestId + "';";
            DataAccess.PopulateGridView(mgv, query);
        }


        public void Delete(UpdateTestEntity en)
        {
            var sql = "delete from test where id ='" + en.TestId + "'; ";
            int ex = DataAccess.ExecuteQuery(sql);
            if (ex >= 1)
            {
                MessageBox.Show(" Deleted ");
            }
        }

        public void LoadAll(MetroGrid mgv)
        {
            var sql = "select * from test;";
            DataAccess.PopulateGridView(mgv, sql);
        }
    }
}
