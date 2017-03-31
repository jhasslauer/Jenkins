using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgeLauncher
{
    public partial class Report : Form
    {
        String user = null;

        public Report(String name)
        {
            InitializeComponent();
            user = name;
            textBoxUsername.Text = user;
            if(user != "")
            {
                textBoxUsername.Enabled = false;
            }
        }

        private void buttonSendReport_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.TextLength > 0 && textBoxObject.TextLength > 0 && richTextBoxMessage.TextLength > 0)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(Launcher.adminEmail);
                    mail.To.Add(Launcher.adminEmail);
                    mail.Subject = textBoxObject.Text + " - " + textBoxUsername.Text;
                    mail.Body = richTextBoxMessage.Text;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(Launcher.emailLogin, Launcher.emailPassword);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Report sent");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
