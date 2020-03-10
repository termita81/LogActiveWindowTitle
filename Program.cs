using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LogActiveWindowTitle
{
    static class Program
    {
        const string MutexName = "ASDLnup8c2342346@#$@$Esdf";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsNew())
            {
                Application.Run(new TheForm(args.FirstOrDefault()));
            } else
            {
                MessageBox.Show("Already running?");
            }
        }

        static bool IsNew()
        {
            var mutex = new Mutex(true, MutexName, out bool createdNew);
            return createdNew;
        }
    }
}
