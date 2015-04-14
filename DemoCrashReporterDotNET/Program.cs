using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CrashReporterDotNET;

namespace DemoCrashReporterDotNET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Konfigurasi CrashReporter.NET

            Application.ThreadException += delegate(object sender, System.Threading.ThreadExceptionEventArgs e)
            {
                new ReportCrashConfig(e.Exception);
            };

            AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
            {
                new ReportCrashConfig((Exception)e.ExceptionObject);
                Environment.Exit(0);
            };

            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
