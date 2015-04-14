using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoCrashReporterDotNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPembagian_Click(object sender, EventArgs e)
        {
            try
            {
                int nilaiA = Convert.ToInt32(txtNilaiA.Text);
                int nilaiB = Convert.ToInt32(txtNilaiB.Text);
                int hasil = nilaiA / nilaiB;

                txtHasil.Text = hasil.ToString();
            }
            catch (Exception ex)
            {
                new ReportCrashConfig(ex);
            }
        }

        private void btnBukaFile_Click(object sender, EventArgs e)
        {
            using (var fs = File.Open(txtNamaFile.Text, FileMode.Open))
            {
                // TODO : Add your code here!
            }
        }
    }
}
