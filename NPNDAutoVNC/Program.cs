using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NPNDAutoVNC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CTLConfig.GetConfiguration();
            char x = (char) 19;
            Application.Run(new Form1());
        }
    }
}
