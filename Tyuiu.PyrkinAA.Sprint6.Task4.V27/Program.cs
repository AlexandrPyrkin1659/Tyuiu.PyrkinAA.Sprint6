using System;
using System.Windows.Forms;

namespace Tyuiu.PyrkinAA.Sprint6.Task4.V27
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}