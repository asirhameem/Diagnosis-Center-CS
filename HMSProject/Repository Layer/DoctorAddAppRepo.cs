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
    class DoctorAddAppRepo
    {

        public string AutoGenerateId()
        {
            var sql = "select isnull(max(cast(increment as int)),0)+1 from appointment;";
            var data = DataAccess.GetDataTable(sql);
            string id = data.Rows[0][0].ToString();
            return id;
        }

        public void InsertAppoinment(DoctorAddAppEntity an)
        {
            try
            {
                string sql = "insert into appointment values('" + an.AutoId + "','" + an.Name + "','" + an.Age + "','" + an.Sex + "','" + an.Reference + "','" + an.Date + "','" + an.Doctor + "','" + an.Time + "')";
                int data = DataAccess.ExecuteQuery(sql);
                if (data == 1)
                {
                    MessageBox.Show("Appoinment Reserved");
                }
                else
                { MessageBox.Show("Something's not right."); }
            }
            catch (Exception e)
            { MessageBox.Show("INSERT EX"); }
        }

        public void LoadDoctor(MetroGrid mgv)
        {
            var sql = "select id,name,sex,speciality,available,time from doctor;";
            DataAccess.PopulateGridView(mgv,sql);
            
        }

    }
}
