using System;
using System.Windows.Forms;

namespace WeddingGreeting
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfig.LoadGuests();

            Application.Run(new MainForm());
        }
    }
}