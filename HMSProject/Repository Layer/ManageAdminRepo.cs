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
    class ManageAdminRepo
    {

        public void Search(ManageAdminEntity en, MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,reference,address,phone from admin where id ='"+en.Id+ "' or name ='"+en.Name+ "' or phone = '"+en.Phone+"';  ";
            DataAccess.PopulateGridView(mgv, sql) ;
        }

        public void LoadAll(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,reference,address,phone from admin;  ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void EditAdmin()
        {

        }

        public void Delete(ManageAdminEntity en)
        {
            var sql = "delete from admin where id = '"+en.Id+"';";
            var ex = DataAccess.ExecuteQuery(sql);
            if(ex == 1)
            {
                MessageBox.Show("Deleted");
            }
        }

        public void Update(ManageAdminEntity en)
        {
            var sql = "update admin set name = '"+en.Name+"', age = '"+en.Age+"', sex = '"+en.Sex+"', reference = '"+en.Reference+"', phone = '"+en.Phone+"', address = '"+en.Address+"' where id = '" + en.Id + "';";
            var ex = DataAccess.ExecuteQuery(sql);
            if (ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }
    }
}
