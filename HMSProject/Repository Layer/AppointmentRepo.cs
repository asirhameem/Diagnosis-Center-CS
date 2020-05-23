using HMSProject.Application_Layer;
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
    class AppointmentRepo
    {

        public bool AppoinmentRegister(AppointmentEntity a)
        {
            var sql = "insert into appoinments values ('" + a.PatientName + "','" + a.PatientAge + "','" + a.PatientSex + "','" + a.PatientReference + "')";
            var ds = DataAccess.GetDataSet(sql);
            if ( ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
            { return false; }
            return false;
        }

        /* public static void PopulateGridView(MetroGrid m)
         {

             string sql = "select id,name,phone,specialist from doctor;";
             var da = DataAccess.GetDataSet(sql);

             m.AutoGenerateColumns = false;
             m.DataSource = da.Tables[0];

         }
         */
         public String IdGenerate()
        {
            var sql = "select isnull(max(cast(increment as int)),0)+1 from appointment;";
            var data = DataAccess.GetDataTable(sql);
            string id = data.Rows[0][0].ToString();
            return id;
        }

        

        public void AppointmentGrid(MetroGrid mg)
        {
            string sql = "select id,name,phone,speciality,available,time from doctor;";
            DataAccess.PopulateGridView(mg, sql);
        }

        public void InsertAppoinment(AppointmentEntity an)
        {
            try
            {
                string sql = "insert into appointment values('" + an.GeneratedId + "','" + an.PatientName + "','" + an.PatientAge + "','" + an.PatientSex + "','" + an.PatientReference + "','" + an.AppoinmentDate + "','" + an.PatientDoctor + "','"+an.Time+"')";
                int data = DataAccess.ExecuteQuery(sql);
                if (data == 1)
                {
                    MessageBox.Show("Appoinment Reserved");
                }
                else
                { MessageBox.Show("Something's not right."); }
            }
            catch(Exception e)
            { MessageBox.Show("INSERT EX"); }
        }
        public void AppointmentGridRefresh(MetroGrid m , string speciality)
        {
            string sql = "select id,name,phone,speciality,available,time from doctor where speciality = '" + speciality + "'";
            DataAccess.PopulateGridView(m,sql);
        }
        
    }
}
