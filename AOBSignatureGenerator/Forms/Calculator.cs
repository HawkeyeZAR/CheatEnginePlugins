using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOBSignatureGenerator.Forms
{
    /// <summary>
    /// Calculator Main Form
    /// </summary>
    public partial class Calculator : Form
    {
        /// <summary>
        /// Load Form
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ToHex Button on click Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHex_Click(object sender, EventArgs e)
        {
            string toHex = textBoxInput.Text;
            toHex = toHex.Trim().Replace(" ", "");
            // Check if data is valid decimal
            if (IsValidDec(toHex))
            {
                textBoxInput.Text = Int64.Parse(toHex).ToString("X");
            }
        }
        /// <summary>
        /// To Decimal Button on click Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDec_Click(object sender, EventArgs e)
        {
            string toDec = textBoxInput.Text;
            toDec = toDec.Trim().Replace(" ", "");
            // Check if data is valid hex
            if (IsValidHex(toDec))
            {
                textBoxInput.Text = Convert.ToInt64(toDec, 16).ToString();
            }
        }

        /// <summary>
        /// Checks if buttonHex_Click is valid decimal data
        /// If valid decimal data, convert to hex
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True if valid decimal values else return false</returns>
        private bool IsValidDec(string data)
        {

            Int64 number;
            bool isValid = Int64.TryParse(data, out number);
            // If isValid is true, return true
            if (isValid && number <= 9223372036854775807)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Not a vaild decimal number or number is too long", "Not Decimal");
                return false;
            }
        }

        /// <summary>
        /// Checks if buttonDec_Click is using valid hex data
        /// If converted hex data is numeric, convert back to decimal
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True if hex data contains only numeric values, else False</returns>
        private bool IsValidHex(string data)
        {
            try
            {
                string toHex = Convert.ToInt64(data, 16).ToString();
                Int64 number;
                // Check if above hex data is numeric
                bool isValid = Int64.TryParse(toHex, out number);
                if (number <= 9223372036854775807 && number > 0)
                {
                    // If only numeric values, return true
                    if (isValid)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Not a vaild hex number or hex value too long", "Not Hex Number");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Number is too long. Max:\nDec: 9223372036854775807\nHex: 7FFFFFFFFFFFFFFF", "Number to long");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("This is not valid hex data", "Not Hex");
                return false;
            }

        }

    }
}
