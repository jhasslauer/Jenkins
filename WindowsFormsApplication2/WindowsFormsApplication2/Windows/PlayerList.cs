using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForgeLauncher
{
    public partial class PlayerList : Form
    {
        WebService ws = null;

        public PlayerList(WebService ws)
        {
            InitializeComponent();
            this.ws = ws;
        }

        private void PlayerList_Load(object sender, EventArgs e)
        {
            refreshPlayerList();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshPlayerList();
        }

        public async void refreshPlayerList()
        {
            listViewPlayerList.Items.Clear();

            string result = await ws.getJsonAsync("user.php?users");

            List <Player> myPlayers = JsonConvert.DeserializeObject<List<Player>>(result);
            listViewPlayerList.Items.Clear();

            foreach (Player s in myPlayers)
            {
                string[] temp = new string[1];
                temp[0] = s.Username;
                ListViewItem lvi = new ListViewItem(temp);
                listViewPlayerList.Items.Add(lvi);
            }
        }
    }
}
