using HMSProject.Data_layer;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSProject.Repository_Layer
{
    class FinancialRepo
    {
        public string SumTotalToday()
        {
            var sql = "select SUM(total) from test where date = CONVERT(date, getdate());";
            var data = DataAccess.GetDataTable(sql);
            return data.Rows[0][0].ToString();
        }

        public string SumTotalWeek()
        {
            var sql = "select SUM(total) from test where datepart(week,date) = Datepart(week,GETDATE());";
            var data = DataAccess.GetDataTable(sql);
            return data.Rows[0][0].ToString();
        }

        public string SumTotalMonth()
        {
            var sql = "select SUM(total) from test where MONTH(date) = MONTH(GETDATE());";
            var data = DataAccess.GetDataTable(sql);
            return data.Rows[0][0].ToString();
        }
        public void SalesToday(MetroGrid mgv)
        {
            var sql = "select id,name,date,total from test where date =CONVERT(date, getdate());";
            DataAccess.PopulateGridView(mgv,sql);
                
        }

        public void SalesThisMonth(MetroGrid mgv)
        {
            var sql = "select id,name,date,total from test where MONTH(date) = MONTH(GETDATE());";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void SalesThisWeek(MetroGrid mgv)
        {
            var sql = "select id,name,date,total from test where datepart(week,date) = Datepart(week,GETDATE());";
            DataAccess.PopulateGridView(mgv, sql);


        }

        public void SalesByDate(MetroGrid mgv,string date)
        {
            var sql = "select id,name,date,total from test where date = '"+date+"';";
            DataAccess.PopulateGridView(mgv, sql);

        }

        public string SumTotalDate(string date)
        {
            var sql = "select SUM(total) from test where date = '"+date+"';";
            var data = DataAccess.GetDataTable(sql);
            return data.Rows[0][0].ToString();
        }

    }
}
