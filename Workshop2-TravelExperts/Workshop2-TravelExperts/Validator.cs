using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop2_TravelExperts
{
    class Validator
    {
        
            private static string title = "ERROR";

            public static string Title
            {
                get { return title; }
                set { title = value; }
            }

        public static bool IsPresent(TextBox tb, string name)
        {
            bool valid = true; //"innocent untill proven guilty"
            if (tb.Text == "")
            {
                valid = false;
                //System.Windows.Forms.MessageBox.Show(name + " is required.", "Input ERROR");
                tb.Focus();
            }
            return valid;
        }// Checks whether the user entered data into a text box.

        public static bool IsDecimal(TextBox tb, string name)
        {
            bool valid = true;
            decimal val;
            if (!Decimal.TryParse(tb.Text, out val)) // not a double value
            {
                valid = false;
                //MessageBox.Show(name + " must be a number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        } //Checks if what they entered is a decimal

        public static bool IsInt32(TextBox tb, string name)
        {
            bool valid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val)) // not an int
            {
                valid = false;
                //MessageBox.Show(name + " must be  a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return valid;
        }
        ///
        ///Below is Non Negative
        ///
        public static bool IsNonNegativeDecimal(TextBox tb, string name) //Makes sure number cant be less that 0
        {
            bool valid = true;
            decimal val;

            if (!Decimal.TryParse(tb.Text, out val))//not an int
            {
                valid = false;
                //MessageBox.Show(name + " must be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                valid = false;
                //MessageBox.Show(name + " must be greater than zero.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }

            return valid;

        }
        public static bool IsNonNegativeInt(TextBox tb, string name) //Makes sure number cant be less that 0
        {
            bool valid = true;
            int val;

            if (!Int32.TryParse(tb.Text, out val))//not an int
            {
                valid = false;
                //MessageBox.Show(name + " must be a whole number", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                valid = false;
               // MessageBox.Show(name + " must be greater than zero.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }

            return valid;

        }

    }
}
