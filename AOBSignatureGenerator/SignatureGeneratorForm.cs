using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOBSignatureGenerator
{
    public partial class SignatureGeneratorForm : Form
    {
        public SignatureGeneratorForm()
        {
            InitializeComponent();
        }

        private void buttonAOB_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == string.Empty)
            {
                MessageBox.Show("Please enter some hex data first.", "No Data");
            }
            else
            {
                // Call IsValidHexData() method and check if data we are using contains valid hex values
                if (IsValidHexData())
                {
                    // Get number of rows with data in textbox
                    int getLineCount = NumberOfRows();

                    //Create list to save cleaned data.
                    List<string> lines = new List<string>();

                    //Find the shortest line in textBoxInput.Lines
                    int minLen = textBoxInput.Lines[0].Length;  //Set initial value
                    foreach (string line in textBoxInput.Lines)
                    {
                        string l = line.Replace(" ", string.Empty);
                        if (l.Length < minLen && l.Length > 0)
                        {
                            minLen = l.Length;
                        }
                    }

                    //Loop through text from inputTextbox, clean strings, save update lines list
                    for (int i = 0; i < getLineCount; i++)
                    {
                        //if line is blank, skip and dont add to list
                        if (!String.IsNullOrEmpty(textBoxInput.Lines[i]))
                        {
                            string tmpText = textBoxInput.Lines[i].Replace(" ", string.Empty);
                            //Make sure all strings being added to list has the same length
                            lines.Add(tmpText.Substring(0, minLen));
                        }
                    }

                    createSignature(getLineCount, minLen, lines);  // Call method to generate AOB Signature
                }
                // If data contains non hex values, let user no to fix data
                else
                {
                    MessageBox.Show("Please check your data, non hex values found and cannot be used", "Bad Hex Values");
                }
            }
        }

        //Create AOB Signature from cleaned data stored in the lines list
        private void createSignature(int lCount, int mlen, List<string> lines)
        {
            string aobSignature = "";
            List<string> signature = new List<string>();

            for (int i = 0; i < mlen; i++)
            {
                //setup to tmp strings
                string tmp = "";
                string tmpChar = "";
                for (int j = 0; j < lCount; j++)
                {
                    if (String.IsNullOrEmpty(tmpChar))
                    {
                        tmpChar = lines[j][i].ToString().ToUpper();
                    }
                    if (tmpChar == lines[j][i].ToString().ToUpper())
                    {
                        tmp = lines[j][i].ToString().ToUpper();
                    }
                    else
                    {
                        tmp = "?";
                        break;
                    }

                }
                signature.Add(tmp);  //Update our signature list with temp values
            }
            string res = string.Join("", signature);
            //add spacing to the aobSignature
            aobSignature = Regex.Replace(res, @"(.{2})", "$1 ");
            ////update the output text boxes
            textBoxOutput.Text = aobSignature;
            textBoxOutput2.Text = res;
        }

        //Get number of rows in inputTextBox
        private int NumberOfRows()
        {
            // Get number of rows with data in textbox
            int getLineCount = 0;
            foreach (string t in textBoxInput.Lines)
            {
                if (t.Length > 0)
                {
                    getLineCount += 1;
                }
            }
            return getLineCount;
        }

        //Check if textboxInput data is valid hex values
        private bool IsValidHexData()
        {
            string validHexValues = "0123456789ABCDEF";
            bool isValid = true;

            // Check of each char is a valid hex value, return true, else return false
            foreach (char text in Regex.Replace(textBoxInput.Text, @"\s", string.Empty))
            {
                if (validHexValues.Contains(Char.ToUpper(text)))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }

}
