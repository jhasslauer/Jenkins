using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgeLauncher
{
    public partial class PopupConfigServer : Form
    {
        string serverName = null;
        
        string idServer;

        ControlPanel cp = null;
        WebService ws = null;

        public PopupConfigServer()
        {
            InitializeComponent();
        }

        public PopupConfigServer(ControlPanel c, string name, string i)
        {
            InitializeComponent();

            cp = c;
            ws = new WebService();
            serverName = name;
            idServer = i;
            textBoxServerName.Text = serverName;
        }

        private async void buttonRename_Click(object sender, EventArgs e)
        {
            if(textBoxServerName.Text != "")
            {
                string json = "{\"name\":\"" + textBoxServerName.Text + "\", \"id\":\"" + idServer + "\", \"players\":\"" + "0" + "\"}";
                json = json.Insert(0, "{\"update_server\":[");
                json = json.Insert(json.Length, "]}");

                string result = await ws.postJsonAsync("server.php", json);
                cp.refreshServerList();
            }
        }
    }
}
