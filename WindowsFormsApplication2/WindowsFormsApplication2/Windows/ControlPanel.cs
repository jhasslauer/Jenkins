using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ForgeLauncher
{
    public partial class ControlPanel : Form
    {
        Launcher mainWindow = null;
        
        string idHostServer = null;
        string ipConnServer = "";
        string nameConnServer = "";
        string gamePath = "";

        int pidServer = 0;
        int pidClient = 0;
        int idConnServer = -1;

        bool serverRunning = false;
        bool clientRunning = false;
        bool isRefreshing = false;

        List<string> txtLines = new List<string>();
        List<Control> controlsToDisable = new List<Control>();
        List<Server> servers = new List<Server>();


        PlayerList pl = null;
        Player player = null;

        Thread threadRefresh = null;
        Thread threadPing = null;
        Thread threadProcessServer = null;
        Thread threadProcessClient = null;
        Thread threadClient = null;
        Thread threadServer = null;

        public delegate void ThreadDelegate();
        public ThreadDelegate delegateProcessServer;
        public ThreadDelegate delegateProcessClient;
        public ThreadDelegate delegateRefresh;
        public ThreadDelegate delegatePing;

        WebService ws = null;

        public ControlPanel(Launcher mw, Player p)
        {
            InitializeComponent();

            controlsToDisable.Add(kComboBoxMap);
            controlsToDisable.Add(kComboBoxMode);
            controlsToDisable.Add(textBoxServerName);
            controlsToDisable.Add(textBoxAdminPassword);
            controlsToDisable.Add(kBtnHost);
            controlsToDisable.Add(kBtnConnectLocal);
            controlsToDisable.Add(kBtnConnect);

            ws = new WebService();
            mainWindow = mw;
            player = p;

            //initialiqation des delegate
            delegateProcessServer = new ThreadDelegate(closeServer);
            delegateProcessClient = new ThreadDelegate(disconnectServer);
            delegateRefresh = new ThreadDelegate(refreshServerList);
            //delegatePing = new ThreadDelegate(calculatePing);
        }

        private void kBtnHost_Click(object sender, EventArgs e)
        {
            if (textBoxServerName.Text != "")
            {
                if (!serverRunning)
                {
                    startServer(Launcher.ipUser);
                }
                else
                {
                    closeServer(Launcher.ipUser);
                }
            }
            else
            {
                MessageBox.Show("Enter a server name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void kBtnConnect_Click(object sender, EventArgs e)
        {
            if (!clientRunning)
            {
                try
                {
                    connectServer(false);

                    Process proc = new Process();
                    proc.StartInfo.FileName = gamePath;
                    proc.StartInfo.Arguments = ipConnServer + ":7777 -game";
                    proc.Start();
                    pidClient = proc.Id;
                    clientRunning = true;
                    kBtnConnect.Text = "DISCONNECT";

                    threadProcessClient = new Thread(new ThreadStart(ThreadFunctionProcessClient));
                    threadProcessClient.Start();
                }
                catch (Win32Exception we)
                {
                    MessageBox.Show("Forge executable not found\nplease set path in \"Config\" tab", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (pidClient != 0)
                    {
                        Process proc = Process.GetProcessById(pidClient);
                        proc.Kill();
                    }

                }
                catch (InvalidOperationException ioe) { }
                catch (ArgumentException ae) { }

                disconnectServer();
            }
        }

        private void Control_Load(object sender, EventArgs e)
        {
            fixedTabControl1.SelectTab(2);
            kHeader.ValuesPrimary.Heading = player.Username;

            modifyControl(false);

            if (File.Exists(Launcher.saveConfigPath))
            {
                XmlReader reader = XmlReader.Create(Launcher.saveConfigPath);
                try
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Path")
                        {
                            while (reader.NodeType != XmlNodeType.EndElement)
                            {
                                reader.Read();
                                if (reader.Name == "Forge")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                        {
                                            gamePath = reader.Value;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    reader.Close();
                }
                catch(XmlException xe)
                {
                    reader.Close();
                }
                

                //gamePath = File.ReadAllText(Launcher.saveConfigPath);
                if (gamePath == "")
                {
                    modifyControl(false);
                    fixedTabControl1.SelectTab(2);
                }
                else
                {
                    if (File.Exists(gamePath))
                    {
                        int buildPart = FileVersionInfo.GetVersionInfo(gamePath).ProductBuildPart;
                        if (buildPart != 9953)
                        {
                            modifyControl(false);
                            
                            //File.WriteAllText(Launcher.saveConfigPath, "");
                            try
                            {
                                XmlWriterSettings settings = new XmlWriterSettings();
                                settings.Indent = true;
                                XmlWriter writer = XmlWriter.Create(Launcher.saveConfigPath, settings);
                                writer.WriteStartDocument();
                                writer.WriteStartElement("Path");
                                writer.WriteElementString("Forge", "");
                                writer.WriteEndElement();
                                writer.WriteEndDocument();

                                writer.Flush();
                                writer.Close();
                            }
                            catch (InvalidOperationException ioe)
                            {
                                //Message write error
                            }
                        }
                        else
                        {
                            modifyControl(true);
                            fixedTabControl1.SelectTab(0);
                        }
                    }
                    else
                    {
                        modifyControl(false);
                        //File.WriteAllText(Launcher.saveConfigPath, "");
                        try
                        {
                            XmlWriterSettings settings = new XmlWriterSettings();
                            settings.Indent = true;
                            XmlWriter writer = XmlWriter.Create(Launcher.saveConfigPath, settings);
                            writer.WriteStartDocument();
                            writer.WriteStartElement("Path");
                            writer.WriteElementString("Forge", "");
                            writer.WriteEndElement();
                            writer.WriteEndDocument();

                            writer.Flush();
                            writer.Close();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            //Message write error
                        }
                    }

                }
            }
            else if (Directory.Exists(Launcher.systemPath + "\\ForgeLauncher"))
            {
                //File.Create(Launcher.saveConfigPath);
            }
            else
            {
                Directory.CreateDirectory(Launcher.systemPath + "\\ForgeLauncher");
            }

            populateCombo();
            refreshServerList();

            threadRefresh = new Thread(new ThreadStart(ThreadFunctionRefresh));
            threadRefresh.Start();

            threadClient = new Thread(new ThreadStart(ThreadFunctionClient));
            threadClient.Start();
        }

        public void populateCombo()
        {
            kComboBoxMap.Items.Add("CapitalSiege_Market_Arena");
            kComboBoxMap.Items.Add("CapitalSiege_Market_Spawns");
            kComboBoxMap.Items.Add("CapitalSiege_NoSewers");
            kComboBoxMap.Items.Add("CapitalSiege_Sewers");
            kComboBoxMap.Items.Add("DenofFenric");
            kComboBoxMap.Items.Add("ForestAmbush_ARENA");
            kComboBoxMap.Items.Add("ForestAmbush_Spawns");
            kComboBoxMap.Items.Add("PracticeArena");
            kComboBoxMap.Items.Add("TempleVsTemple");
            kComboBoxMap.Items.Add("TempleVsTemple_Arena");
            kComboBoxMap.Items.Add("TutorialArena_ARENA");

            kComboBoxMode.Items.Add("TDM");
            kComboBoxMode.Items.Add("Coop");
            kComboBoxMode.Items.Add("CTF");
            kComboBoxMode.Items.Add("KOTH");
            kComboBoxMode.Items.Add("Arena");
        }

        public async void startServer(string ip)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (kComboBoxMap.SelectedIndex > -1 && kComboBoxMode.SelectedIndex > -1)
            {
                Server server = new Server();
                server.Name = textBoxServerName.Text;
                server.Admin = player.Username;
                server.Password = textBoxAdminPassword.Text;
                server.Ip = ip;
                server.Port = 7777;
                server.Players = 0;
                server.Date = DateTime.Now.ToString("dd/MM/yyyy");
                server.Hour = DateTime.Now.ToString("HH:mm:ss");
                string json = JsonConvert.SerializeObject(server);
                json = json.Insert(0, "{\"create_server\":[");
                json = json.Insert(json.Length, "]}");

                string result = await ws.postJsonAsync("server.php", json);
                if (result == "server_creation_failed")
                {
                    MessageBox.Show(result);
                }
                else if (result == "server_already_running")
                {
                    MessageBox.Show(result);
                }
                else if (result.Equals("error"))
                {
                    MessageBox.Show("Connection error");
                }
                else
                {
                    idHostServer = result;

                    Process proc = new Process();
                    proc.StartInfo.FileName = gamePath;
                    proc.StartInfo.Arguments = "Map_" + kComboBoxMap.SelectedItem.ToString() + "?listen?game=ForgeGame.ForgeGameInfo" + kComboBoxMode.SelectedItem.ToString() + "?numplay=6 -game -NoVSync -WINDOWED -ResX=640 -ResY=480";
                    proc.Start();
                    pidServer = proc.Id;

                    refreshServerList();

                    kBtnHost.Text = "STOP";
                    serverRunning = true;
                    textBoxServerName.Enabled = false;
                    textBoxAdminPassword.Enabled = false;
                    kComboBoxMap.Enabled = false;
                    kComboBoxMode.Enabled = false;

                    threadProcessServer = new Thread(new ThreadStart(ThreadFunctionProcessServer));
                    threadProcessServer.Start();

                    threadServer = new Thread(new ThreadStart(ThreadFunctionServer));
                    threadServer.Start();
                }
            }
            else
            {
                MessageBox.Show("Please select a map and a mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void connectServer(bool isLan)
        {
            if (isLan)
            {
                ipConnServer = Launcher.ipUser;
                nameConnServer = textBoxServerName.Text;
                int.TryParse(idHostServer, out idConnServer);
                updateServer(1);
                updatePlayer();
            }
            else
            {
                if (listViewServer.SelectedItems.Count > 0)
                {
                    ipConnServer = listViewServer.SelectedItems[0].SubItems[4].Text;
                    nameConnServer = listViewServer.SelectedItems[0].SubItems[0].Text;
                    idConnServer = int.Parse(listViewServer.SelectedItems[0].SubItems[5].Text);

                    updateServer(1);
                    updatePlayer();

                }
            }

        }

        public void disconnectServer()
        {
            if (threadProcessClient != null && threadProcessClient.IsAlive)
            {
                threadProcessClient.Abort();
            }

            updateServer(-1);
            idConnServer = -1;
            updatePlayer();

            pidClient = 0;
            clientRunning = false;

            kBtnConnect.Text = "CONNECT";

        }

        public async void closeServer(string ip)
        {
            if (threadServer != null && threadServer.IsAlive)
            {
                threadServer.Abort();
            }

            serverRunning = false;
            kBtnHost.Text = "HOST";
            textBoxServerName.Enabled = true;
            textBoxAdminPassword.Enabled = true;
            kComboBoxMap.Enabled = true;
            kComboBoxMode.Enabled = true;
            kBtnConnect.Enabled = true;

            try
            {
                if (pidServer != 0)
                {
                    Process proc = Process.GetProcessById(pidServer);
                    proc.Kill();
                }
            }
            catch (InvalidOperationException ioe) { }
            catch (ArgumentException ae) { }

            pidServer = 0;

            string json = "{\"name\":\"" + textBoxServerName.Text + "\", \"ip\":\"" + ip + "\"}";
            json = json.Insert(0, "{\"drop_server\":[");
            json = json.Insert(json.Length, "]}");

            string result = await ws.postJsonAsync("server.php", json);

            refreshServerList();
        }


        public async void refreshServerList()
        {
            if (!isRefreshing)
            {
                isRefreshing = true;

                int idServerSelected = 0;
                if (listViewServer.SelectedItems.Count > 0)
                {
                    idServerSelected = listViewServer.SelectedItems[0].Index;
                }

                string result = await ws.getJsonAsync("server.php?servers");

                listViewServer.Items.Clear();

                if (result.Equals("error"))
                {
                    DialogResult dr = MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    while (dr != DialogResult.OK)
                    {
                        Console.ReadKey();
                        Console.WriteLine("freeze");
                    }


                }
                else if (result != "")
                {
                    /* result = result.Replace("\n", "");
                     result = result.Replace("\\", "");
                     result = result.Remove(0, result.IndexOf("["));
                     result = result.Remove(result.IndexOf("]") + 1);*/

                    List<Server> myServers = JsonConvert.DeserializeObject<List<Server>>(result);
                    listViewServer.Items.Clear();

                    foreach (Server s in myServers)
                    {
                        string pingLength = "> 400";
                        long pl = 0;

                        List<string> listOfIP = new List<string>();
                        listOfIP.Add(s.Ip);
                        listOfIP.Add(s.Ip);
                        listOfIP.Add(s.Ip);

                        PingReply[] myPings = await PingAsync(listOfIP);

                        long[] pings = new long[3];
                        int cpt = 0;
                        int sucessNumber = 0;
                        foreach (PingReply pr in myPings)
                        {
                            if (pr.Status == IPStatus.Success)
                            {
                                sucessNumber++;
                                pings[cpt] = pr.RoundtripTime;
                            }
                            cpt++;
                        }

                        if (sucessNumber > 0)
                        {
                            pl = (pings[0] + pings[1] + pings[2]) / sucessNumber;
                            pingLength = pl.ToString();
                        }

                        string[] temp = new string[8];
                        temp[0] = s.Name;
                        temp[1] = s.Admin;
                        temp[2] = s.Players.ToString();
                        temp[3] = pingLength;
                        temp[4] = s.Ip;
                        temp[5] = s.Id.ToString();
                        temp[6] = s.Date;
                        temp[7] = s.Hour;
                        ListViewItem lvi = new ListViewItem(temp);
                        listViewServer.Items.Add(lvi);
                    }


                    if (idServerSelected != 0)
                    {
                        listViewServer.Items[idServerSelected].Selected = true;
                        //listViewServer.Focus();
                    }
                    servers = myServers;
                }

                isRefreshing = false;
            }
        }

        public async void updateServer(int nbPlayers)
        {
            string json = "{\"name\":\"" + nameConnServer + "\", \"id\":\"" + idConnServer + "\", \"players\":\"" + nbPlayers + "\"}";
            json = json.Insert(0, "{\"update_server\":[");
            json = json.Insert(json.Length, "]}");

            string result = await ws.postJsonAsync("server.php", json);
            if (result.Equals("error"))
            {
                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async void updatePlayer()
        {
            string json = "{\"id\":\"" + player.Id + "\", \"id_server\":\"" + player.IdServer + "\"}";
            json = json.Insert(0, "{\"update_id_server\":[");
            json = json.Insert(json.Length, "]}");

            string result = await ws.postJsonAsync("user.php", json);

            /*string json = "{\"id\":\"" + player.Id + "\", \"username\":\"" + player.Username + "\", \"login\":\"" + player.Login + "\", \"password\":\"" + player.Password + "\", \"email\":\"" + player.Email + "\" \"id_server\":\"" + idConnServer + "\"}";
            json = json.Insert(0, "{\"update_user\":[");
            json = json.Insert(json.Length, "]}");

            string result = await ws.postJsonAsync("user.php", json);*/
        }

        private void kBtnRefresh_Click(object sender, EventArgs e)
        {
            refreshServerList();
        }

        private async Task<PingReply[]> PingAsync(List<string> listOfIP)
        {
            Ping pingSender = new Ping();
            var tasks = listOfIP.Select(ip => new Ping().SendPingAsync(ip, 400));

            PingReply[] results = await Task.WhenAll(tasks);
            
            return results;
        }

        /*public void calculatePing()
        {
            Ping pingSender = new Ping();
            int timeout = 400;

            for(int j = 0; j < servers.Count; j++)
            {
                long[] pings = new long[4];

                for (int  i = 0; i < 4; i++)
                {
                    PingReply reply = pingSender.Send("forge-reborn.fleaw.5gbfree.com", timeout);
                    if (reply.Status == IPStatus.Success)
                    {
                        pings[i] = reply.RoundtripTime;
                    }
                }

                long pingLength = (pings[0] + pings[1] + pings[2] + pings[3]) / 4;
                //diviser par nombre de ping réussi

                listViewServer.Items[j].SubItems[3].Text = pingLength.ToString();
            }
        }*/

        private async void listViewServer_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewServer.SelectedItems.Count > 0)
            {
                kBtnConnect.Enabled = true;
                buttonConfigServer.Enabled = true;

                listViewPlayersOnServer.Items.Clear();

                string result = await ws.getJsonAsync("user.php?server_id=" + listViewServer.SelectedItems[0].SubItems[5].Text);

                if (result.Equals("error"))
                {
                    MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<Player> myPlayers = JsonConvert.DeserializeObject<List<Player>>(result);

                    foreach (Player s in myPlayers)
                    {
                        string[] temp = new string[1];
                        temp[0] = s.Username;
                        ListViewItem lvi = new ListViewItem(temp);
                        listViewPlayersOnServer.Items.Add(lvi);
                    }
                }
            }
            else
            {
                kBtnConnect.Enabled = false;
                buttonConfigServer.Enabled = false;
            }
        }

        public async void logout()
        {
            if (threadRefresh != null && threadRefresh.IsAlive)
            {
                threadRefresh.Abort();
            }

            if (threadProcessClient != null && threadProcessClient.IsAlive)
            {
                threadProcessClient.Abort();
            }

            if (threadProcessServer != null && threadProcessServer.IsAlive)
            {
                threadProcessServer.Abort();
            }

            if (threadClient != null && threadClient.IsAlive)
            {
                threadClient.Abort();
            }

            if (threadServer != null && threadServer.IsAlive)
            {
                threadServer.Abort();
            }

            if (pl != null)
            {
                pl.Close();
            }

            if (serverRunning)
            {
                closeServer(Launcher.ipUser);
            }

            if (clientRunning)
            {
                disconnectServer();
            }
            
            string json = "{\"id\":\"" + player.Id + "\"}";
            json = json.Insert(0, "{\"logout_user\":[");
            json = json.Insert(json.Length, "]}");

            string result = await ws.postJsonAsync("user.php", json);

            mainWindow.Show();
            this.Close();
        }

        private void kBtnConnectLocal_Click(object sender, EventArgs e)
        {
            if (!clientRunning)
            {
                try
                {
                    connectServer(true);
                    Process proc = new Process();
                    proc.StartInfo.FileName = gamePath;
                    proc.StartInfo.Arguments = "127.0.0.1:7777 -game";
                    proc.Start();
                    pidClient = proc.Id;
                    clientRunning = true;
                    kBtnConnectLocal.Text = "DISCONNECT";
                }
                catch(Win32Exception we)
                {
                    MessageBox.Show("Forge executable not found\nplease set path in \"Config\" tab", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                try
                {
                    if (pidClient != 0)
                    {
                        Process proc = Process.GetProcessById(pidClient);
                        proc.Kill();
                    }
                }
                catch (InvalidOperationException ioe) { }
                catch (ArgumentException ae) { }

                disconnectServer();
                kBtnConnectLocal.Text = "CONNECT";
            }
        }

        private void kBtnLocate_Click(object sender, EventArgs e)
        {
            locateForge();   
        }

        private void modifyControl(Boolean forgeLocated)
        {
            if (forgeLocated)
            {
                kBtnLocate.StateNormal.Back.Color1 = Color.DarkGreen;
                kBtnLocate.StateNormal.Back.Color2 = Color.SeaGreen;
                kBtnLocate.StateTracking.Back.Color1 = Color.SeaGreen;
                kBtnLocate.StateTracking.Back.Color2 = Color.SeaGreen;
                kBtnLocate.StatePressed.Back.Color1 = Color.DarkGreen;
                kBtnLocate.StatePressed.Back.Color1 = Color.DarkGreen;

                foreach (Control c in controlsToDisable)
                {
                    c.Enabled = true;
                }
            }
            else
            {
                foreach (Control c in controlsToDisable)
                {
                    c.Enabled = false;
                }

                kBtnLocate.StateNormal.Back.Color1 = Color.Red;
                kBtnLocate.StateNormal.Back.Color2 = Color.Red;
                kBtnLocate.StateTracking.Back.Color1 = Color.Red;
                kBtnLocate.StateTracking.Back.Color2 = Color.Maroon;
                kBtnLocate.StatePressed.Back.Color1 = Color.FromArgb(192, 0, 0);
                kBtnLocate.StatePressed.Back.Color1 = Color.FromArgb(192, 0, 0);
            }
            
        }

        public void locateForge()
        {
            int buildPart = 0;
            if (openFileDialogPath.ShowDialog() == DialogResult.OK)
            {
                gamePath = openFileDialogPath.FileName;
                buildPart = FileVersionInfo.GetVersionInfo(gamePath).ProductBuildPart;
                if (buildPart != 9953)
                {
                    modifyControl(false);

                    MessageBox.Show("Please select Forge executable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    modifyControl(true);
                    //File.WriteAllText(Launcher.saveConfigPath, gamePath);
                    try
                    {
                        XmlWriterSettings settings = new XmlWriterSettings();
                        settings.Indent = true;
                        XmlWriter writer = XmlWriter.Create(Launcher.saveConfigPath, settings);
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Path");
                        writer.WriteElementString("Forge", gamePath);
                        writer.WriteEndElement();
                        writer.WriteEndDocument();

                        writer.Flush();
                        writer.Close();
                    }
                    catch(InvalidOperationException ioe)
                    {
                        //Message write error
                    }
                }
            }
        }

        private void kBtnLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void kBtnPlayersOnline_Click(object sender, EventArgs e)
        {
            if (pl == null)
            {
                pl = new PlayerList(ws);
            }
            else
            {
                pl.Close();
                pl = new PlayerList(ws);
            }
            // pl.Hide();
            // pl.ShowInTaskbar = false;
            pl.Location = new Point(this.Location.X + this.Width, this.Location.Y);

            pl.StartPosition = FormStartPosition.Manual;
            pl.Show();
        }

        private void ControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            logout();
        }

        public void closeServer()
        {
            closeServer(Launcher.ipUser);
        }

        private void buttonConfigServer_Click(object sender, EventArgs e)
        {
            if (listViewServer.SelectedItems.Count > 0)
            {
                if(listViewServer.SelectedItems[0].SubItems[1].Text == player.Username)
                {
                    PopupConfigServer pcs = new PopupConfigServer(this, listViewServer.SelectedItems[0].SubItems[0].Text, listViewServer.SelectedItems[0].SubItems[5].Text);
                    pcs.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You are not the owner ot this server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
               
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            Report fenReport = new Report(player.Username);
            fenReport.ShowDialog();
        }

        private async void kBtnSavePassword_Click(object sender, EventArgs e)
        {
            if (textBoxCurrentPass.Text.Equals(player.Password))
            {
                if (textBoxPass.Text != "" && textBoxPassConfirm.Text != "")
                {
                    if (textBoxPass.Text.Equals(textBoxPassConfirm.Text))
                    {
                        string json = "{\"id\":\"" + player.Id + "\", \"password\":\"" + textBoxPass.Text + "\"}";
                        json = json.Insert(0, "{\"update_password\":[");
                        json = json.Insert(json.Length, "]}");

                        string result = await ws.postJsonAsync("user.php", json);

                        if (result.Contains("error"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Password changed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            logout();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPass.Clear();
                        textBoxPassConfirm.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void kBtnSaveEmail_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != "" && textBoxEmailConfirm.Text != null)
            {
                if (textBoxEmail.Text.Equals(textBoxEmailConfirm.Text))
                {

                    string result = await ws.getJsonAsync("user.php?email_exist=" + textBoxEmail.Text);
                    if (result.Contains("email_exist"))
                    {
                        MessageBox.Show("Email already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string json = "{\"id\":\"" + player.Id + "\", \"email\":\"" + textBoxEmail.Text + "\"}";
                        json = json.Insert(0, "{\"update_email\":[");
                        json = json.Insert(json.Length, "]}");

                        result = await ws.postJsonAsync("user.php", json);

                        if (result.Contains("error"))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Email changed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            logout();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Email not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEmail.Clear();
                    textBoxEmailConfirm.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a new email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //*****************************************************************************************************//
        //                                       Creation des threads                                          //
        //*****************************************************************************************************//
        private void ThreadFunctionProcessServer()
        {
            ThreadProcessServer tp = new ThreadProcessServer(this, pidServer);
            tp.Run();
        }

        private void ThreadFunctionProcessClient()
        {
            ThreadProcessClient tp = new ThreadProcessClient(this, pidClient);
            tp.Run();
        }

        private void ThreadFunctionClient()
        {
            ThreadClient tp = new ThreadClient(int.Parse(player.Id));
            tp.Run();
        }
        
        private void ThreadFunctionServer()
        {
            ThreadServer tp = new ThreadServer(int.Parse(idHostServer));
            tp.Run();
        }

        private void ThreadFunctionPing()
        {
            ThreadPing tp = new ThreadPing(this);
            tp.Run();
        }

        private void ThreadFunctionRefresh()
        {
            ThreadRefresh tr = new ThreadRefresh(this);
            tr.Run();
        }

        private void fixedTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPageIndex == 2)
            {
                labelEmail.Text = player.Email;
                labelTimePlayed.Text = player.TimePlayed;
                labelIp.Text = Launcher.ipUser;
            }
        }

        private void kBtnReport_Click(object sender, EventArgs e)
        {
            Report fenReport = new Report(player.Username);
            fenReport.ShowDialog();
        }
        
    }


    //*****************************************************************************************************//
    //                                       Classes threads                                               //
    //*****************************************************************************************************//
    public class ThreadClient
    {
        WebService ws = new WebService();
        int id_user;

        public ThreadClient(int id)
        {
            id_user = id;
        }

        public async void Run()
        {
            string jsonTimestamp = "{\"id\":\"" + id_user + "\"}";
            jsonTimestamp = jsonTimestamp.Insert(0, "{\"set_timestamp\":[");
            jsonTimestamp = jsonTimestamp.Insert(jsonTimestamp.Length, "]}");

            while (Thread.CurrentThread.IsAlive)
            {
                string result = await ws.postJsonAsync("user.php", jsonTimestamp);
                if (result.Contains("error"))
                {
                    result = await ws.postJsonAsync("user.php", jsonTimestamp);
                    if (result.Contains("error"))
                    {
                        MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                Thread.Sleep(30000);
            }
        }
    }

    public class ThreadServer
    {
        WebService ws = new WebService();
        int id_serv;

        public ThreadServer(int id)
        {
            id_serv = id;
        }

        public async void Run()
        {
            string json = "{\"id\":\"" + id_serv + "\"}";
            json = json.Insert(0, "{\"set_timestamp\":[");
            json = json.Insert(json.Length, "]}");

            while (Thread.CurrentThread.IsAlive)
            {
                string result = await ws.postJsonAsync("server.php", json);
                if (result.Contains("error"))
                {
                    result = await ws.postJsonAsync("server.php", json);
                    if (result.Contains("error"))
                    {
                        MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                
                Thread.Sleep(30000);
            }
        }
    }

    /*public class ThreadWeb
    {
        ControlPanel cp;

        public ThreadWeb(ControlPanel c)
        {
            cp = c;
        }

        public void Run()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                cp.Invoke(cp.delegateRefresh);
            }
        }
    }*/

    class ThreadRefresh
    {
        ControlPanel cp;

        public ThreadRefresh(ControlPanel c)
        {
            cp = c;
        }

        public void Run()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(10000);
                cp.Invoke(cp.delegateRefresh);
            }
        }
    }

    class ThreadPing
    {
        ControlPanel cp;

        public ThreadPing(ControlPanel c)
        {
            cp = c;
        }

        public void Run()
        {
            cp.Invoke(cp.delegatePing);
        }
    }

    class ThreadProcessServer
    {
        ControlPanel cp;
        int pid;

        public ThreadProcessServer(ControlPanel c, int pid)
        {
            cp = c;
            this.pid = pid;
        }

        public void Run()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(3000);
                try
                {
                    if (Process.GetProcessById(pid).ProcessName == "ForgeGame")
                    {
                    }
                    else
                    {
                        cp.Invoke(cp.delegateProcessServer);
                        Thread.CurrentThread.Abort();
                    }
                }
                catch (ArgumentException ae)
                {
                    cp.Invoke(cp.delegateProcessServer);
                    Thread.CurrentThread.Abort();
                }
            }
        }

    }

    class ThreadProcessClient
    {
        ControlPanel cp;
        int pid;

        public ThreadProcessClient(ControlPanel c, int pid)
        {
            cp = c;
            this.pid = pid;
        }

        public void Run()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(3000);
                try
                {
                    if (Process.GetProcessById(pid).ProcessName == "ForgeGame")
                    {
                    }
                    else
                    {
                        cp.Invoke(cp.delegateProcessClient);
                        Thread.CurrentThread.Abort();
                    }
                }
                catch (ArgumentException ae)
                {
                    cp.Invoke(cp.delegateProcessClient);
                    Thread.CurrentThread.Abort();
                }
            }
        }
    }
}
