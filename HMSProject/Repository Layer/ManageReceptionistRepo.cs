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
    class ManageReceptionistRepo
    {
        public void Search(ManageReceptionistEntity en, MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,reference,address,phone from receptionist where id = '"+en.Id+ "' or name = '"+en.Name+ "' or phone = '"+en.Phone+"';  ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void LoadAll(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,reference,address,phone from receptionist;  ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void Delete(string id)
        {
            var sql = "delete from receptionist where id = '"+id+"'; ";
            var ex = DataAccess.ExecuteQuery(sql);
            if(ex == 1)
            {
                MessageBox.Show("Deleted");
            }
        }

        public void Update(ManageReceptionistEntity en)
        {
            var sql = "update receptionist set name = '"+en.Name+ "', age ='" + en.Age + "', sex = '" + en.Sex + "',reference = '" + en.Reference + "',address = '" + en.Address + "',phone = '" + en.Phone + "' where id = '" + en.Id + "';  ";
            var ex = DataAccess.ExecuteQuery(sql);
            if(ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }

        public void FilterBySex(string sex,MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,reference,address,phone from receptionist where sex = '"+sex+"';";
            DataAccess.PopulateGridView(mgv,sql);
        }

    }
}
