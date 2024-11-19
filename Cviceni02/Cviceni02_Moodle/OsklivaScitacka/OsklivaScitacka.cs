using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OsklivaScitacka
{
    static class OsklivaScitacka
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OsklivaScitackaForm1());
        }
    }
}
