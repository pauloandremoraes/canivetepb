using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addons
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           //Creating an object
            //AddMenu oAddingMenuItems = null;

            //oAddingMenuItems = new AddMenu();

            //  Start Message Loop
           // System.Windows.Forms.Application.Run(); 


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
