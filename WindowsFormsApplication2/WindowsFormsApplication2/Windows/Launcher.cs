using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ForgeLauncher
{
    public partial class Launcher : Form
    {
        public static string saveConfigPath = null;
        public static string systemPath = null;
        public static string domain = "http://forge-reborn.fleaw.5gbfree.com/";
        public static string scriptsFolder = "http://forge-reborn.fleaw.5gbfree.com/scripts/";
        public static string download_directory = "http://fleaw.5gbfree.com/downloads/latest_version/";
        /*public static string domain = "http://forge-reborn.alwaysdata.net/";
        public static string scriptsFolder = "http://forge-reborn.alwaysdata.net/scripts/";
        public static string download_directory = "http://forge-reborn.alwaysdata.net/downloads/latest_version/";*/
        public static string adminEmail = "forgelauncher@gmail.com";
        public static string emailLogin = "forgelauncher";
        public static string emailPassword = "Forgeandco";
        public static string ipUser = null;
        public string testJenkins = "Ajout d'une modification";

        public WebService ws = null;

        public Launcher()
        {
            InitializeComponent();
            ws = new WebService();
            systemPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Directory.CreateDirectory(systemPath + "\\ForgeLauncher");
            saveConfigPath = systemPath + "\\ForgeLauncher\\config.xml";
            if (!File.Exists(saveConfigPath))
            {
                StreamWriter newFile = File.CreateText(saveConfigPath);
                newFile.Close();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                kBtnLogin.Enabled = true;
            }
            else
            {
                kBtnLogin.Enabled = false;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                kBtnLogin.Enabled = true;
            }
            else
            {
                kBtnLogin.Enabled = false;
            }
        }

        public async void checkUpdate()
        {
            string last = await ws.getStringAsync("check_update.php");

            if (!last.Contains("error"))
            {
                if (last.Length > 0)
                {
                    Version current_version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    Version latest_version = new Version(last);
                    if (latest_version > current_version)
                    {
                        if (MessageBox.Show("New Launcher available, download it now ?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string downloadUrl = Launcher.download_directory + "ForgeLauncher.exe";

                            try
                            {
                                ProgressDialog progress = new ProgressDialog(downloadUrl, latest_version.ToString(), current_version.ToString());
                                //progress.Parent = ActiveControl;
                                progress.StartPosition = FormStartPosition.CenterParent;
                                progress.ShowDialog();

                            }
                            catch (WebException we)
                            {
                                MessageBox.Show("Download failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Application.Exit();
                            }
                            catch (IOException ioe)
                            {

                            }

                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot check update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            try
            {
                ipUser = client.DownloadString("http://icanhazip.com");
                ipUser = ipUser.Remove(ipUser.Length - 2, 2);
            }
            catch(WebException we)
            {
                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            
            checkUpdate();
        }

        private async void kBtnLogin_Click(object sender, EventArgs e)
        {
            User user = new User("", textBoxLogin.Text, textBoxPassword.Text, "", ipUser, "1");
            string json = JsonConvert.SerializeObject(user);
            json = json.Insert(0, "{\"login_user\":[");
            json = json.Insert(json.Length, "]}");

            //string result = ws.sendJson("/user.php", json);
            string result = await ws.postJsonAsync("user.php", json);

            /*result = result.Replace("\\n", "");
            result = result.Replace("\\", "");
            result = result.Remove(0, result.IndexOf("[") + 1);
            result = result.Remove(result.IndexOf("]"));*/

            if (result.Contains("login_error"))
            {
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                MessageBox.Show("Wrong name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Equals("error"))
            {
                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Open control panel
                result = await ws.getJsonAsync("user.php?user_id=" + result);

                Player[] player = JsonConvert.DeserializeObject<Player[]>(result);

                ControlPanel cp = new ControlPanel(this, player[0]);
                this.Hide();
                cp.ShowDialog();
            }
        }

        private void kBtnRegister_Click(object sender, EventArgs e)
        {
            Register winRegister = new Register(ws);
            winRegister.ShowDialog();

            /*User user = new User("", textBoxLogin.Text, textBoxPassword.Text, "", "0");
            string json = JsonConvert.SerializeObject(user);
            json = json.Insert(0, "{\"create_user\":[");
            json = json.Insert(json.Length, "]}");

            //string result = ws.sendJson("/user.php", json);
            string result = await ws.postJsonAsync("user.php", json);

            if (result.Equals("exist"))
            {
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                MessageBox.Show("Name already taken !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result.Equals("error"))
            {
                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                MessageBox.Show("Registration success !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void kBtnReport_Click(object sender, EventArgs e)
        {
            Report fenReport = new Report("");
            fenReport.ShowDialog();
        }

        private void forgotAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountRecovery fenRecovery = new AccountRecovery();
            fenRecovery.Show();
        }
    }
}
