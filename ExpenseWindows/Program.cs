using System;
using System.Windows.Forms;

namespace ExpenseWindows
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        internal static MainForm frmMain;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMain = new MainForm();
            Application.Run(frmMain);
        }
    }
}
