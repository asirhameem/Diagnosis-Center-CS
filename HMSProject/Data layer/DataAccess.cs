using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MetroFramework.Controls;

namespace HMSProject.Data_layer
{
    class DataAccess
    {

        private static SqlConnection sqcon;

        public static SqlConnection Sqcon
        {
            get
            {
                if (sqcon == null)
                {
                    sqcon = new SqlConnection(@"Data Source=LAPTOP-1PCVJHI9;Initial Catalog=""hospital management"";Integrated Security=True");
                }
                else if (sqcon.State != ConnectionState.Open)
                {
                    sqcon.Open();
                }
                return sqcon;
            }
        }

        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            int i = sqcom.ExecuteNonQuery();
            return i;
        }

        public static void PopulateGridView(MetroGrid m ,string query)
        {
            var da = DataAccess.GetDataSet(query);

            m.AutoGenerateColumns = false;
            m.DataSource = da.Tables[0];
        }


    }
}
