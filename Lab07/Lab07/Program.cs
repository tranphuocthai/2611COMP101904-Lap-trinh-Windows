using System;
using System.Windows.Forms;

namespace Lab07
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin loginForm = new FrmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMain(loginForm.LoggedInUser));
            }
        }
    }
}