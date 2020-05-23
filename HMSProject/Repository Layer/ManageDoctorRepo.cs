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
    class ManageDoctorRepo
    {
        public void LoadDoctor(MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,reference,speciality,available,time,address,phone from doctor";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void Search(ManageDoctorEntity en, MetroGrid mgv)
        {
            var sql = "select id,name,age,sex,reference,speciality,available,time,address,phone from doctor where id = '" + en.Id + "' or name = '" + en.Name + "' or phone = '" + en.Phone + "'; ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void FilterSex(string sex, MetroGrid mgv)
        {
            var sql = "select id, name, age, sex, reference, speciality, available, time, address, phone from doctor where sex = '" + sex + "' ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void FilterSpeciality(string speciality, MetroGrid mgv)
        {
            var sql = "select id, name, age, sex, reference, speciality, available, time, address, phone from doctor where speciality = '" + speciality + "';  ";
            DataAccess.PopulateGridView(mgv, sql);
        }

        public void Delete(string id)
        {
            var sql = "delete from doctor where id = '"+id+"';";
            var ex = DataAccess.ExecuteQuery(sql);
            if(ex == 1)
            {
                MessageBox.Show("Deleted");
            }
        }

        public void Update(ManageDoctorEntity en)
        {
            var sql = "update doctor set name = '"+en.Name+ "', age = '" + en.Age + "', sex = '" + en.Sex + "',reference = '" + en.Reference + "',address = '" + en.Address + "',phone = '" + en.Phone + "',speciality = '" + en.Speciality + "',available= '" + en.Available + "',time = '" + en.Time + "' where id = '" + en.Id + "'; ";
            var ex = DataAccess.ExecuteQuery(sql);
            if(ex == 1)
            {
                MessageBox.Show("Updated");
            }
        }
    }
}
