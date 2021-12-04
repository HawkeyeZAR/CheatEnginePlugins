
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
    public partial class HideShowMainForm : Form
    {
        public HideShowMainForm()
        {
            InitializeComponent();
            
        }

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
                    //lua.DoString(@"list = createStringlist()
                    //                list.Sorted=true
                    //                for i = 0, getFormCount() - 1 do
                    //                local frm = getForm(i)
                    //                if tostring(frm.getVisible())=='true' then
                    //                   list.add(frm.Caption)
                    //                   getForm(i).hide()
                    //                 end
                    //                end");

                    //atom0s from forum.cheatengine.org gave me a better way to write the above
                    lua.DoString(@"f = hideForms();");

                }
                else
                {
                    checkBoxOnTop.Enabled = true;
                    checkBoxShowHide.Enabled = true;
                    labelWindowStatus.ForeColor = System.Drawing.Color.Black;
                    labelWindowStatus.Text = "Status:";
                    //lua.DoString(@"for i = 0,list.Count-1 do
                    //                local frm = getForm(i)
                    //                getForm(frm).show()
                    //                end
                    //                list.clear()");
                    lua.DoString(@"showForms(f);");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void slider_valueChanged(object sender, EventArgs e)
        {
            var lua = CESDK.CESDK.currentPlugin.sdk.lua;
            lua.DoString($@"local cnt = getFormCount();
                           for x = 0, cnt - 1 do
                                local frm = getForm(x);
                                frm.setLayeredAttributes(0x0000FF, {trackBarOpaque.Value}, 3)
                            end");
        }
    }
}
