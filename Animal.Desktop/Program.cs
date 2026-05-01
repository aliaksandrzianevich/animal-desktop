using System;
using System.Windows.Forms;
using Animal.Desktop.Form;

namespace Animal.Desktop
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgresBar());
        }
    }
}
