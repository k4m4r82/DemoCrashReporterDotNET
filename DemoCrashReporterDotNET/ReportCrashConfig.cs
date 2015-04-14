using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrashReporterDotNET;

namespace DemoCrashReporterDotNET
{
    public class ReportCrashConfig
    {
        public ReportCrashConfig(Exception exception)
        {
            ReportCrash(exception);
        }

        private void ReportCrash(Exception exception)
        {
            // informasi FromEmail, ToEmail, UserName dan Password menyesuaikan
            var reportCrash = new ReportCrash
            {
                FromEmail = "pengirim.bug@gmail.com",
                ToEmail = "penerima.bug@gmail.com",
                SmtpHost = "smtp.gmail.com",
                Port = 587,
                UserName = "pengirim.bug@gmail.com",
                Password = "DxMsx0bGkvQB1UzyB594",
                EnableSSL = true,
                AnalyzeWithDoctorDump = false
            };

            reportCrash.Send(exception);
        }
    }
}
