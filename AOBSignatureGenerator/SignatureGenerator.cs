using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CESDK;

namespace AOBSignatureGenerator
{
    public class SignatureGenerator : CESDKPluginClass
    {
        public override string GetPluginName()
        {
            return "  Misc Plugins for CE 7.1+ - written by HawkeyeZAR";
        }

        public override bool DisablePlugin() //called when disabled
        {

            return true;
        }

        public override bool EnablePlugin() //called when enabled
        {
            //you can use sdk here
            //sdk.lua.dostring("print('I am alive')");
            sdk.lua.Register("AOBSignature", LoadGUI);
            sdk.lua.DoString(@"local m=MainForm.Menu
                local topm=createMenuItem(m)
                topm.Caption='Misc Utils'
                m.Items.insert(MainForm.miHelp.MenuIndex,topm)
                local mf1=createMenuItem(m)
                mf1.Caption='AOB Sig Creator .Net';
                mf1.OnClick=function(s)
                local newthread=MessageDialog('Open the form in a new thread? (If not it will open inside the main GUI)',mtConfirmation,mbYes,mbNo)==mrYes
                local i=AOBSignature(newthread)
                end
                topm.add(mf1)");
            return true;
        }

        //Create Main Form
        public void AOBSignatureForm()
        {
            int i = sdk.lua.GetTop();
            SignatureGeneratorForm formGen = new SignatureGeneratorForm();

            try
            {
                System.Windows.Forms.Application.Run(formGen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int LoadGUI()
        {
            if (sdk.lua.ToBoolean(1))
            {
                //run in a thread
                Thread thr = new Thread(AOBSignatureForm);
                thr.Start();
            }
            else
            {
                //run in the current thread (kinda)
                AOBSignatureForm();
            }
            return 1;
        }
    }
}
