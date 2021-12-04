using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CESDK;
using AOBSignatureGenerator.Forms;

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
            sdk.lua.Register("MainWindowDisplayUtils", LoadShowHide);

            sdk.lua.DoString(@"local m=MainForm.Menu
                local topm=createMenuItem(m)
                topm.Caption='Misc Utils'
                m.Items.insert(MainForm.miHelp.MenuIndex,topm)
                local mf1=createMenuItem(m)
                mf1.Caption='AOB Sig Creator .Net';
                mf1.OnClick=function(s)
                local i=AOBSignature(1)
                end
                topm.add(mf1)

                local mf2=createMenuItem(m)
                mf2.Caption='Change MainWindow Display Options';
                mf2.OnClick=function(s)
                local i=MainWindowDisplayUtils(1)
                end
                topm.add(mf2)");

            //atom0s from forum.cheatengine.org gave me a better way to save the Forms
            sdk.lua.DoString(@"function hideForms()
                            local ret = {};
                            local cnt = getFormCount();
                            for x = 0, cnt - 1 do
                                local frm = getForm(x);
                                if (frm ~= nil and frm.getVisible()) then
                                    frm.hide();
                                    local addr = readIntegerLocal(tonumber(tostring(frm):sub(11), 16));
                                    table.insert(ret, addr);
                                end
                            end
                            return ret;
                        end");
            sdk.lua.DoString(@"function showForms(t)
                            local function hasval(t, val)
                                for _, v in pairs(t) do
                                                if (v == val) then
                                        return true;
                                        end
                                    end
                                return false;
                                        end
                                        local cnt = getFormCount();
                                        for x = 0, cnt - 1 do
                                                local frm = getForm(x);
                                if (frm ~= nil) then
                                    local addr = readIntegerLocal(tonumber(tostring(frm):sub(11), 16));
                                        if (hasval(t, addr)) then
                                        frm.show();
                                        end
                                    end
                            end
                        end");
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

        //Create Second Form for HideShow Main Screen function
        public void HideShowForm()
        {
            int i = sdk.lua.GetTop();
            HideShowMainForm hideShow = new HideShowMainForm();
            try
            {
                System.Windows.Forms.Application.Run(hideShow);
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
            return 1;
        }

        int LoadShowHide()
        {
            if (sdk.lua.ToBoolean(1))
            {
                //run in a thread
                Thread thr = new Thread(HideShowForm);
                thr.Start();
            }
            return 1;

        }
    }
}