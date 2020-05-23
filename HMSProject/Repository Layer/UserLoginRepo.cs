using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMSProject.Entity_Layer;
using HMSProject.Data_layer;

namespace HMSProject.Repository_Layer
{
    class UserLoginRepo
    {
        /*
        public bool UserFetch(string userType)
        {
            try
            {
                UserLoginEntity ue = new UserLoginEntity();
                string sql = "select * from reciptionist where username ='" + ue.UserName + "' and password = '" + ue.UserPass + "'";
                var ds = DataAccess.GetDataSet(sql);
                if (ds.Tables[0].Rows.Count == 1)

                { return true; }

                else { return false; }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
       }
        */
        
        
        public bool UserLoginReciptionist(UserLoginEntity u)
        {
            try
            {
               
                   //this.UserFetch("reciptionist");

                   
                    string sql = "select * from receptionist where username ='" + u.UserName + "' and password = '" + u.UserPass + "'";
                    var ds = DataAccess.GetDataSet(sql);
                    if (ds.Tables[0].Rows.Count == 1)
                    { 
                        return true;
                    }

                    else { return false; }

                }
                
            catch (Exception e)
            {
                return false;
            }
            return false;
        }


        public bool UserLoginAdmin(UserLoginEntity u)
        {
            try
            {

                //this.UserFetch("reciptionist");


                string sql = "select * from admin where username ='" + u.UserName + "' and password = '" + u.UserPass + "'";
                var ds = DataAccess.GetDataSet(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    return true;
                }

                else { return false; }

            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public bool UserLoginDoctor(UserLoginEntity u)
        {
            try
            {

                //this.UserFetch("reciptionist");


                string sql = "select * from doctor where username ='" + u.UserName + "' and password = '" + u.UserPass + "'";
                var ds = DataAccess.GetDataSet(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    return true;
                }

                else { return false; }

            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}
