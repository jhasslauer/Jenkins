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
    public partial class AccountRecovery : Form
    {
        WebService ws = null;

        public AccountRecovery()
        {
            InitializeComponent();
            ws = new WebService();
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string json = "{\"email\":\"" + textBoxEmail.Text + "\"}";
            json = json.Insert(0, "{\"recover\":[");
            json = json.Insert(json.Length, "]}");

            string result = await ws.postJsonAsync("user.php", json);
            if (result.Contains("no_account_found"))
            {
                MessageBox.Show("No account found with this email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(Launcher.adminEmail);
                    mail.To.Add(textBoxEmail.Text);
                    mail.Subject = "ForgeLauncher account recovery";
                    mail.Body = "Hi,\nYour account informations :\n\n\tlogin : " + result.Split('|')[0] + "\n\tpassword : " + result.Split('|')[1] + "\n\nGood game.";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(Launcher.emailLogin, Launcher.emailPassword);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("An email with your account informations has been sent to :\n" + textBoxEmail.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AccountRecovery_Load(object sender, EventArgs e)
        {

        }
    }
}
