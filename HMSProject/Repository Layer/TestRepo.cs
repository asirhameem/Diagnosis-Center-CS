using HMSProject.Data_layer;
using HMSProject.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSProject.Application_Layer;
using MetroFramework.Controls;
using System.Data;

namespace HMSProject.Repository_Layer
{
    class TestRepo
    {
        public string LoadId()
        {
            try
            {
                var sql = "select isnull(max(cast(increment as int)),0)+1 from test;";
                var data = DataAccess.GetDataTable(sql);
                string id = data.Rows[0][0].ToString();
                return id;
            }
            catch(Exception ex)
            {
                return "Id";
            }
        }
       
        public void AddToCart(TestEntity tn)
        {
            if (CheckIfExists(tn.TestName) == true)
            {
                string sql = "insert into cart values('" + tn.TestId + "','" + tn.TestName + "','" + tn.Price + "','" + tn.Date + "')";
                int e = DataAccess.ExecuteQuery(sql);
                if (e == 1)
                {
                    MessageBox.Show("Added");
                }
            }
            else
            {
                MessageBox.Show("Tesr Is Already Selected.");
            }

        }

        public void RefreshCart(MetroGrid m)
        {
            string query = "select * from cart;";
            DataAccess.PopulateGridView(m,query);
          
        }

        private string list;

        public String  MakeList()
        {

            string query = "select stuff((select ', ' + name from cart for xml path ('')), 1, 2, '') as tests;";
            var dl = DataAccess.GetDataTable(query);
            list = ConvertTests(dl.Rows[0]);
            //list = dl.Rows[0].ToString();
            //MessageBox.Show(String.Format("tests: {0}",list));
            return list;
        }

        public String ConvertTests(DataRow row)
        {
            if (row == null)
            {
                MessageBox.Show("Cannot convert to Entity");
            }
            //var t = new Test();

            string s = row["tests"].ToString();
            return s;


        }
        private double bill;
        public double MakeBill()
        {
            string query = "select sum(price)bill from cart;";
            var dl = DataAccess.GetDataTable(query);
            bill = ConvertBill(dl.Rows[0]);
            //list = dl.Rows[0].ToString();
            //MessageBox.Show(String.Format("tests: {0}",list));
            return bill;

        }
        public double ConvertBill (DataRow row)
        {
            if (row == null)
            {
                MessageBox.Show("Fill up!!");
            }
            
            string a = row["bill"].ToString();
            double bill = double.Parse(a);
           
            return bill;
        }

        public void InsertToOrder(TestEntity n)
        {
            try
            {
                string tests = MakeList();
                double cost = MakeBill();

                string sql = "insert into test values('" + n.IdGenerated + "','" + n.PatientName + "','" + n.PatientAge + "','" + n.Sex + "','" + n.Reference + "','" + tests + "','" + cost + "','"+n.Discount+ "','"+n.Total+"','" + n.Date + "', '"+n.Time+"')";
                //MessageBox.Show(String.Format("tests: {0}", tests));
                int execute = DataAccess.ExecuteQuery(sql);
                if (execute == 1)
                {
                    MessageBox.Show("Order Completed");
                }
            }
            catch(Exception e)
            {

            }
        }

        public void ClearCart()
        {
            string query = "delete from cart;";
            int del = DataAccess.ExecuteQuery(query);
            if(del >= 1)
            {
                MessageBox.Show("Successful");
            }
        }

        public void DeleteItem(TestEntity entity)
        {
            var sql = "delete from cart where name = '"+entity.TestName+"';";
            var exe = DataAccess.ExecuteQuery(sql);
            
            if(exe >= 1)
            {
                MessageBox.Show("Deleted");
                //RefreshCart(grid);
            }
            
        }

        public bool CheckIfExists(string testname)
        {
            var sql = "select name from cart where name = '"+testname+"'";
            var data = DataAccess.GetDataTable(sql);
            if( data.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
