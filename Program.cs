using System;
using System.Windows.Forms;

namespace CourseworkForAri
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); //Maybe start programm from settings form, and ask what mode should be?
        }
    }
}
