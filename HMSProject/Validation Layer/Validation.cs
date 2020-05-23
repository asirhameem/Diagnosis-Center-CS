using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSProject.Validation_Layer
{
    class Validation
    {

        public static bool IsStringValid(string value) // String Validation
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;

            else
                return true;
        }

        public static bool IsPhoneValid(string value)  //Phone Num valid for Bangladesh
        {

            if (value.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool IsIntValid(string value)   // Integar Validation
        {
            int x;
            return Int32.TryParse(value, out x);
        }


        public static bool IsComboBoxValid(MetroComboBox cmb )  //Check ComboBox Is Selected Metro
        {
            if (cmb.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsComboBoxValid(ComboBox cmb)  //Check ComboBox Is Selected Windows
        {
            if (cmb.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
