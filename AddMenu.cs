using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addons
{
    class AddMenu
    {
        //private SAPbouiCOM.Application SBO_Apllication;
        //private SAPbouiCOM.Application oForm;

        //private void SetApplication()
        //{
        //    SAPbouiCOM.SboGuiApi SboGuiApi = null;
        //    string SConnectionString = null;

        //    SboGuiApi = new SAPbouiCOM.SboGuiApi();
        //    SConnectionString = System.Convert.ToString(Environment.GetCommandLineArgs().GetValue(1));

        //    try 
        //    {
        //        SboGuiApi.Connect(SConnectionString);
        //    }
        //    catch 
        //    {
        //        System.Windows.Forms.MessageBox.Show("O sap não está aberto!!");
        //        System.Environment.Exit(0);
        //    }

        //    SBO_Apllication = SboGuiApi.GetApplication(-1);


        //}

        private void AddMenuItems()
        {

        //    SAPbouiCOM.Menus oMenus = null;
        //    SAPbouiCOM.MenuItem oMenuItem = null;

        //    int i = 0; // to be used as counter
        //    int lAddAfter = 0;
        //    string sXML = null; 

        //    oMenus = SBO_Apllication.Menus;


        //    SAPbouiCOM.MenuCreationParams oCreationPackage = null;
        //    oCreationPackage = ((SAPbouiCOM.MenuCreationParams)(SBO_Apllication.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams)));
        //    oMenuItem = SBO_Apllication.Menus.Item("43520");
                

        //    string sPath = null;

        //    sPath = Application.StartupPath;
        //    sPath = sPath.Remove(sPath.Length - 9, 9);

        //    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP;
        //    oCreationPackage.UniqueID = "Meu_Menu_01";
        //    oCreationPackage.String = "Exemplo Menu";
        //    oCreationPackage.Enabled = true;
        //    oCreationPackage.Image = sPath + "UI.BMP";
        //    oCreationPackage.Position = 15;

        //    oMenus = oMenuItem.SubMenus;

        //    try {
        //        oMenus.AddEx(oCreationPackage);

        //        oMenuItem = SBO_Apllication.Menus.Item("Meu_Menu_01");
        //        oMenus = oMenuItem.SubMenus;

        //        oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
        //        oCreationPackage.UniqueID = "Meu_SubMenu";
        //        oCreationPackage.String = "Exemplo Submenu";
        //        oMenus.AddEx(oCreationPackage);

        //    }
        //    catch(Exception er) 
            
        //    {

        //        SBO_Apllication.MessageBox("O menu já existe", 1, "ok", "", "");
            
            
        //    }


        }














    }
}
