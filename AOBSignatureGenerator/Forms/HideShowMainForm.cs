
using CESDK;
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
    /// HideShowMainForm
    /// </summary>
    public partial class HideShowMainForm : Form
    {
        /// <summary>
        /// Hides Main Form or Shows main form
        /// </summary>
        public HideShowMainForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// checkBoxOnTop_CheckedChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxOnTop_CheckedChanged(object sender, EventArgs e)
        {
            var lua = CESDK.CESDK.currentPlugin.sdk.lua;
            try
            {
                if (checkBoxOnTop.Checked == true)
                {
                    checkBoxShowHide.Enabled = false;
                    checkBoxHideAll.Enabled = false;
                    labelWindowStatus.ForeColor = System.Drawing.Color.Green;
                    labelWindowStatus.Text = "Status: Main Window On Top Mode";
                    lua.DoString("getMainForm().formStyle='fsSystemStayOnTop'");
                }
                else
                {
                    checkBoxShowHide.Enabled = true;
                    checkBoxHideAll.Enabled = true;
                    labelWindowStatus.ForeColor = System.Drawing.Color.Black;
                    labelWindowStatus.Text = "Status:";
                    lua.DoString("getMainForm().formStyle='0'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// checkBoxShowHide_CheckedChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            var lua = CESDK.CESDK.currentPlugin.sdk.lua;
            try
            {
                if (checkBoxShowHide.Checked == true)
                {
                    checkBoxOnTop.Enabled = false;
                    checkBoxHideAll.Enabled = false;
                    labelWindowStatus.ForeColor = System.Drawing.Color.Blue;
                    labelWindowStatus.Text = "Status: Main Window is Hidden";
                    lua.DoString("getMainForm().hide()");
                }
                else
                {
                    checkBoxOnTop.Enabled = true;
                    checkBoxHideAll.Enabled = true;
                    labelWindowStatus.ForeColor = System.Drawing.Color.Black;
                    labelWindowStatus.Text = "Status:";
                    lua.DoString("getMainForm().show()");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Hide All Forms Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxHideAll_CheckedChanged(object sender, EventArgs e)
        {
            var lua = CESDK.CESDK.currentPlugin.sdk.lua;
            try
            {
                if (checkBoxHideAll.Checked == true)
                {
                    checkBoxOnTop.Enabled = false;
                    checkBoxShowHide.Enabled = false;
                    labelWindowStatus.ForeColor = System.Drawing.Color.Red;
                    labelWindowStatus.Text = "Status: All Windows are hidden";

                    //atom0s from forum.cheatengine.org gave me a better way to write the above
                    lua.DoString(@"f = hideForms();");

                }
                else
                {
                    checkBoxOnTop.Enabled = true;
                    checkBoxShowHide.Enabled = true;
                    labelWindowStatus.ForeColor = System.Drawing.Color.Black;
                    labelWindowStatus.Text = "Status:";
                    lua.DoString(@"showForms(f);");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Changed Opcaity Slider Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slider_valueChanged(object sender, EventArgs e)
        {
            var lua = CESDK.CESDK.currentPlugin.sdk.lua;
            lua.DoString($@"local cnt = getFormCount();
                           for x = 0, cnt - 1 do
                                local frm = getForm(x);
                                frm.setLayeredAttributes(0x0000FF, {255 - trackBarOpaque.Value}, 3)
                            end");
        }

        /// <summary>
        /// buttonUpdateTitle_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateTitle_Click(object sender, EventArgs e)
        {
            var lua = CESDK.CESDK.currentPlugin.sdk.lua;
            if (String.IsNullOrEmpty(textBoxUpdateTitle.Text))
            {
                MessageBox.Show("Title cannot be blank", "error");
            }
            else
            {
                lua.DoString($"getMainForm().Caption = '{textBoxUpdateTitle.Text}'");
                lua.DoString($"getApplication().Title = '{textBoxUpdateTitle.Text}'");
                labelWindowStatus.ForeColor = System.Drawing.Color.Black;
                labelWindowStatus.Text = "Status: Cheat Engine Title Updated";
            }
        }
    }
}
