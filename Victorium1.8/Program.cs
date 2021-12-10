using System;
using System.Windows.Forms;

namespace Victorium1P8
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form)new Victorium1p8());
        }
    }
}
