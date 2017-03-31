using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgeLauncher
{
    public partial class ProgressDialog : Form
    {
        string url = null;
        string latest_version = null;
        string current_version = null;

        bool exit = false;
        bool complete = false;

        public ProgressDialog(string uri, string lv, string cv)
        {
            InitializeComponent();
            url = uri;
            latest_version = lv;
            current_version = cv;

            downloadFile();
        }

        public ProgressDialog()
        {
            InitializeComponent();
        }

        public void downloadFile()
        {
            try {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += downloadChanged;
                client.DownloadFileCompleted += downloadCompleted;
                client.DownloadFileAsync(new Uri(url), "ForgeLauncher.exe");
                Console.WriteLine(new Uri(url));
            }
            catch (WebException we)
            {
                MessageBox.Show("Download failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void downloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //Console.WriteLine(e.ProgressPercentage);
            progressBarDownload.Value = e.ProgressPercentage;
            labelPercent.Text = e.ProgressPercentage + "%";
        }

        private void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            complete = true;
            try {
                string exePath = System.Reflection.Assembly.GetEntryAssembly().Location;
                string destination = Launcher.systemPath + "\\ForgeLauncher\\old\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + current_version + ".exe.old";

                if (File.Exists(destination))
                {
                    File.Delete(destination);
                }

                File.Move(exePath, destination);
                //File.Move(Directory.GetCurrentDirectory() + "\\ForgeLauncher" + latest_version + ".exe", Directory.GetCurrentDirectory() + "\\ForgeLauncher.exe");

                MessageBox.Show("ForgeLauncher up-to-date");
                Process.Start(Directory.GetCurrentDirectory() + "\\ForgeLauncher.exe");
                Application.Exit();
            }
            catch (IOException ioe)
            {

            }
        }

        private void ProgressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!complete)
            {
                if (!exit)
                {
                    if (MessageBox.Show("Do you really want to close ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        exit = true;
                        Application.Exit();
                    }
                }
            }
        }

        private void ProgressDialog_Load(object sender, EventArgs e)
        {
            
        }
    }

}
