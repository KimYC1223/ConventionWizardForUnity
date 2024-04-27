using System;
using System.Windows.Forms;

namespace ConventionWizardForUnity
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new MainForm());
            }
            catch (System.ObjectDisposedException e)
            {
                e.ToString();
                Console.WriteLine("프로그램 종료");
            }
        }
    }
}