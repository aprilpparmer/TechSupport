using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.Controller
{
    //Validates information entered into a form
    class Validator
    {
        private static string title = "Entry Error";

        //Gets and sets the title of the invalidation error
        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        //Checks if a value in the form is present
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", Title);
                    comboBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
