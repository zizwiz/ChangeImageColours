using System;
using System.Windows.Forms;
using CenteredMessagebox;

namespace ColourChanger.utils
{
    class NumberUtils
    {
        /// <summary>
        /// Check if the textbox value is an integer
        /// </summary>
        /// <param name="myTextBox"></param>
        /// <returns>bool</returns>
        public static bool isInteger(TextBox myTextBox)
        {
            int parsedValue;
            if (int.TryParse(myTextBox.Text, out parsedValue))
            {
                return true;
            }
            else
            {
                // The input is not a valid integer
               MsgBox.Show("You need to choose an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// Check if the textbox value is an double
        /// </summary>
        /// <param name="myTextBox"></param>
        /// <returns>bool</returns>
        public static bool isDouble(TextBox myTextBox)
        {
            Double parsedValue;
            if (Double.TryParse(myTextBox.Text, out parsedValue))
            {
                return true;
            }
            else
            {
                // The input is not a valid integer
                MsgBox.Show("You need to choose a Double", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// Check if the textbox value is a float
        /// </summary>
        /// <param name="myTextBox"></param>
        /// <returns>bool</returns>
        public static bool isFloat(TextBox myTextBox)
        {
            float parsedValue;
            if (float.TryParse(myTextBox.Text, out parsedValue))
            {
                return true;
            }
            else
            {
                // The input is not a valid integer
                MsgBox.Show("You need to choose a Float", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// Check if the textbox value is a float
        /// </summary>
        /// <param name="myTextBox"></param>
        /// <returns>bool</returns>
        public static bool IsNumeric(TextBox myTextBox)
        {
            int parsedValue;
            if (int.TryParse(myTextBox.Text, out parsedValue))
            {
                return true;
            }
            else
            {
                // The input is not a valid integer
                MsgBox.Show("You need to choose a Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }



    }
}
