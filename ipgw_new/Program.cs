using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StartupHelper;
using System.Diagnostics;

namespace ipgw_new
{
    static class Program
    {

        static string version = "1.0.2.2";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            switch (Startup.start(args, version))
            {
                case StartupResult.GetVersion:
                    return;
                case StartupResult.LegalLaunch:
                    break;
                case StartupResult.IllegalLaunch:
                    Process autoUpdate = new Process();
                    autoUpdate.StartInfo.FileName = "AutoUpdate.exe";
                    autoUpdate.Start();
                    autoUpdate.Close();
                    return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
