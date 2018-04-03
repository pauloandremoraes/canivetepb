using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAPbobsCOM;
//using SAPbouiCOM;


namespace Addons
{
    public class GlobalConection

    {
    
	public static void IncitalizeCompany()
    {

			
			oCompany = new SAPbobsCOM.Company();
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_Portuguese_Br;
			oCompany.UseTrusted = false;

    }

    public static SAPbobsCOM.Company oCompany;

    public static string sErrMsg = null;
    public static int lErrCode = 0;
    public static int lRetCode;


    }
}
