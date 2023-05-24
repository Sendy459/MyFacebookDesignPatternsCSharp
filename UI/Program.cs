using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace UI
{
    public static class Program
    {
        /// The main entry point for the application.
        [STAThread]
        public static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
