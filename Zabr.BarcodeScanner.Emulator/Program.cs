using System;
using System.Windows.Forms;
using Zabr.BarcodeScanner.Emulator.Forms;

namespace Zabr.BarcodeScanner.Emulator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
