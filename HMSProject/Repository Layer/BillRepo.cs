using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSProject.Application_Layer;
using HMSProject.Data_layer;
using HMSProject.Entity_Layer;

namespace HMSProject.Repository_Layer
{
    class BillRepo
    {


        public void UpdateOrders(BillEntity en)
        {
            var sql = "update test set name = '" + en.Name + "', age = '" + en.Age + "', sex = '" + en.Sex + "', reference = '" + en.Reference + "', date = '" + en.Date + "',time = '"+en.Time+"' where id = '" + en.Id + "';";
            int exe = DataAccess.ExecuteQuery(sql);
            if (exe == 1)
            {
                MessageBox.Show("Updated");
            }
            else
            { MessageBox.Show("Not Updated"); }
        }


        public BillEntity Credentials(string id)
        {
            var query = "select * from test where id = '" + id + "';";
            var data = DataAccess.GetDataTable(query);
            if (data.Rows.Count ==1)
            {
                return this.ConvertToEntity(data.Rows[0]);
            }
            else
            {
                MessageBox.Show("No Data");
                return null;
            }
        }

        public BillEntity ConvertToEntity(DataRow row)
        {
            if(row == null)
            {
                return null;
            }
            var en = new BillEntity();

            en.Name = row["name"].ToString();
            en.Age = int.Parse(row["age"].ToString());
            en.Sex = row["sex"].ToString();
            en.Reference = row["reference"].ToString();
            en.Tests = row["tests"].ToString();
            en.Price = row["price"].ToString();
            en.Discount = row["discount"].ToString();
            en.Total = row["total"].ToString();
            en.Date = row["date"].ToString();
            en.Time = row["time"].ToString();

            return en;
        }











    }
}
