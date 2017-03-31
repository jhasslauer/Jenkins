namespace ForgeLauncher
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader columnHeader9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.kHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kBtnLogout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kBtnPlayersOnline = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialogPath = new System.Windows.Forms.OpenFileDialog();
            this.fixedTabControl1 = new ForgeLauncher.FixedTabControl();
            this.tabPageConnect = new System.Windows.Forms.TabPage();
            this.kBtnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kBtnConnectLocal = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kBtnConnect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listViewServer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPlayersOnServer = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageHost = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConfigServer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kComboBoxMode = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kComboBoxMap = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kBtnHost = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kBtnReport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelIp = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTimePlayed = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kBtnSavePassword = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmailConfirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassConfirm = new System.Windows.Forms.TextBox();
            this.kBtnSaveEmail = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCurrentPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kBtnLocate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.kHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHeader.Panel)).BeginInit();
            this.kHeader.Panel.SuspendLayout();
            this.kHeader.SuspendLayout();
            this.fixedTabControl1.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            this.tabPageHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kComboBoxMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kComboBoxMap)).BeginInit();
            this.tabPageConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "";
            // 
            // kHeader
            // 
            this.kHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.kHeader.Location = new System.Drawing.Point(0, 0);
            this.kHeader.Name = "kHeader";
            this.kHeader.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            // 
            // kHeader.Panel
            // 
            this.kHeader.Panel.Controls.Add(this.kBtnLogout);
            this.kHeader.Panel.Controls.Add(this.kBtnPlayersOnline);
            this.kHeader.Size = new System.Drawing.Size(667, 76);
            this.kHeader.StateNormal.Back.Image = global::ForgeLauncher.Properties.Resources.ForgeBandeau;
            this.kHeader.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kHeader.StateNormal.HeaderPrimary.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(46)))), ((int)(((byte)(14)))));
            this.kHeader.StateNormal.HeaderPrimary.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kHeader.TabIndex = 37;
            this.kHeader.ValuesPrimary.Heading = "Forge Launcher";
            this.kHeader.ValuesPrimary.Image = null;
            this.kHeader.ValuesSecondary.Heading = "";
            // 
            // kBtnLogout
            // 
            this.kBtnLogout.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnLogout.Location = new System.Drawing.Point(538, 5);
            this.kBtnLogout.Name = "kBtnLogout";
            this.kBtnLogout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnLogout.Size = new System.Drawing.Size(124, 27);
            this.kBtnLogout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnLogout.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnLogout.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnLogout.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.kBtnLogout.StateNormal.Back.Color2 = System.Drawing.Color.DarkBlue;
            this.kBtnLogout.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.kBtnLogout.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.kBtnLogout.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.kBtnLogout.StateTracking.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kBtnLogout.TabIndex = 6;
            this.kBtnLogout.Values.Text = "Logout";
            this.kBtnLogout.Click += new System.EventHandler(this.kBtnLogout_Click);
            // 
            // kBtnPlayersOnline
            // 
            this.kBtnPlayersOnline.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnPlayersOnline.Location = new System.Drawing.Point(3, 5);
            this.kBtnPlayersOnline.Name = "kBtnPlayersOnline";
            this.kBtnPlayersOnline.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnPlayersOnline.Size = new System.Drawing.Size(124, 27);
            this.kBtnPlayersOnline.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnPlayersOnline.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnPlayersOnline.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnPlayersOnline.StateNormal.Back.Color1 = System.Drawing.Color.DarkGreen;
            this.kBtnPlayersOnline.StateNormal.Back.Color2 = System.Drawing.Color.SeaGreen;
            this.kBtnPlayersOnline.StatePressed.Back.Color1 = System.Drawing.Color.DarkGreen;
            this.kBtnPlayersOnline.StatePressed.Back.Color2 = System.Drawing.Color.DarkGreen;
            this.kBtnPlayersOnline.StateTracking.Back.Color1 = System.Drawing.Color.SeaGreen;
            this.kBtnPlayersOnline.StateTracking.Back.Color2 = System.Drawing.Color.SeaGreen;
            this.kBtnPlayersOnline.TabIndex = 5;
            this.kBtnPlayersOnline.Values.Text = "Players Online";
            this.kBtnPlayersOnline.Click += new System.EventHandler(this.kBtnPlayersOnline_Click);
            // 
            // openFileDialogPath
            // 
            this.openFileDialogPath.DefaultExt = "exe";
            // 
            // fixedTabControl1
            // 
            this.fixedTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.fixedTabControl1.Controls.Add(this.tabPageConnect);
            this.fixedTabControl1.Controls.Add(this.tabPageHost);
            this.fixedTabControl1.Controls.Add(this.tabPageConfig);
            this.fixedTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedTabControl1.Location = new System.Drawing.Point(0, 76);
            this.fixedTabControl1.Name = "fixedTabControl1";
            this.fixedTabControl1.SelectedIndex = 0;
            this.fixedTabControl1.Size = new System.Drawing.Size(667, 431);
            this.fixedTabControl1.TabIndex = 4;
            this.fixedTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.fixedTabControl1_Selected);
            // 
            // tabPageConnect
            // 
            this.tabPageConnect.BackgroundImage = global::ForgeLauncher.Properties.Resources.imgTabHost;
            this.tabPageConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageConnect.Controls.Add(this.kBtnRefresh);
            this.tabPageConnect.Controls.Add(this.kBtnConnectLocal);
            this.tabPageConnect.Controls.Add(this.kBtnConnect);
            this.tabPageConnect.Controls.Add(this.listViewServer);
            this.tabPageConnect.Controls.Add(this.listViewPlayersOnServer);
            this.tabPageConnect.Location = new System.Drawing.Point(4, 4);
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnect.Size = new System.Drawing.Size(659, 405);
            this.tabPageConnect.TabIndex = 2;
            this.tabPageConnect.Text = "Connect Server";
            this.tabPageConnect.UseVisualStyleBackColor = true;
            // 
            // kBtnRefresh
            // 
            this.kBtnRefresh.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnRefresh.Location = new System.Drawing.Point(357, 29);
            this.kBtnRefresh.Name = "kBtnRefresh";
            this.kBtnRefresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnRefresh.Size = new System.Drawing.Size(87, 27);
            this.kBtnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnRefresh.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnRefresh.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnRefresh.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(89)))), ((int)(((byte)(28)))));
            this.kBtnRefresh.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(89)))), ((int)(((byte)(28)))));
            this.kBtnRefresh.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kBtnRefresh.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kBtnRefresh.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kBtnRefresh.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kBtnRefresh.TabIndex = 3;
            this.kBtnRefresh.Values.Text = "Refresh";
            this.kBtnRefresh.Click += new System.EventHandler(this.kBtnRefresh_Click);
            // 
            // kBtnConnectLocal
            // 
            this.kBtnConnectLocal.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnConnectLocal.Location = new System.Drawing.Point(224, 328);
            this.kBtnConnectLocal.Name = "kBtnConnectLocal";
            this.kBtnConnectLocal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnConnectLocal.Size = new System.Drawing.Size(220, 49);
            this.kBtnConnectLocal.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnConnectLocal.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnConnectLocal.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnConnectLocal.StateNormal.Back.Color1 = System.Drawing.Color.DarkRed;
            this.kBtnConnectLocal.StateNormal.Back.Color2 = System.Drawing.Color.IndianRed;
            this.kBtnConnectLocal.StatePressed.Back.Color1 = System.Drawing.Color.DarkRed;
            this.kBtnConnectLocal.StatePressed.Back.Color2 = System.Drawing.Color.DarkRed;
            this.kBtnConnectLocal.StateTracking.Back.Color1 = System.Drawing.Color.IndianRed;
            this.kBtnConnectLocal.StateTracking.Back.Color2 = System.Drawing.Color.IndianRed;
            this.kBtnConnectLocal.TabIndex = 2;
            this.kBtnConnectLocal.Values.Text = "CONNECT LOCAL\r\n";
            this.kBtnConnectLocal.Click += new System.EventHandler(this.kBtnConnectLocal_Click);
            // 
            // kBtnConnect
            // 
            this.kBtnConnect.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnConnect.Location = new System.Drawing.Point(44, 328);
            this.kBtnConnect.Name = "kBtnConnect";
            this.kBtnConnect.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnConnect.Size = new System.Drawing.Size(174, 49);
            this.kBtnConnect.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnConnect.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnConnect.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnConnect.StateNormal.Back.Color1 = System.Drawing.Color.DarkRed;
            this.kBtnConnect.StateNormal.Back.Color2 = System.Drawing.Color.IndianRed;
            this.kBtnConnect.StatePressed.Back.Color1 = System.Drawing.Color.DarkRed;
            this.kBtnConnect.StatePressed.Back.Color2 = System.Drawing.Color.DarkRed;
            this.kBtnConnect.StateTracking.Back.Color1 = System.Drawing.Color.IndianRed;
            this.kBtnConnect.StateTracking.Back.Color2 = System.Drawing.Color.IndianRed;
            this.kBtnConnect.TabIndex = 1;
            this.kBtnConnect.Values.Text = "CONNECT";
            this.kBtnConnect.Click += new System.EventHandler(this.kBtnConnect_Click);
            // 
            // listViewServer
            // 
            this.listViewServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.listViewServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewServer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            columnHeader9});
            this.listViewServer.FullRowSelect = true;
            this.listViewServer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewServer.HideSelection = false;
            this.listViewServer.Location = new System.Drawing.Point(44, 62);
            this.listViewServer.MultiSelect = false;
            this.listViewServer.Name = "listViewServer";
            this.listViewServer.Scrollable = false;
            this.listViewServer.Size = new System.Drawing.Size(400, 254);
            this.listViewServer.TabIndex = 97;
            this.listViewServer.UseCompatibleStateImageBehavior = false;
            this.listViewServer.View = System.Windows.Forms.View.Details;
            this.listViewServer.SelectedIndexChanged += new System.EventHandler(this.listViewServer_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Server Name";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Admin";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Players";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ping";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ip";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date";
            this.columnHeader7.Width = 84;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hour";
            this.columnHeader8.Width = 87;
            // 
            // listViewPlayersOnServer
            // 
            this.listViewPlayersOnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.listViewPlayersOnServer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10});
            this.listViewPlayersOnServer.FullRowSelect = true;
            this.listViewPlayersOnServer.Location = new System.Drawing.Point(453, 62);
            this.listViewPlayersOnServer.Name = "listViewPlayersOnServer";
            this.listViewPlayersOnServer.Size = new System.Drawing.Size(155, 254);
            this.listViewPlayersOnServer.TabIndex = 7;
            this.listViewPlayersOnServer.UseCompatibleStateImageBehavior = false;
            this.listViewPlayersOnServer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Players On Server";
            this.columnHeader10.Width = 150;
            // 
            // tabPageHost
            // 
            this.tabPageHost.BackgroundImage = global::ForgeLauncher.Properties.Resources.imgTabConnect;
            this.tabPageHost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageHost.Controls.Add(this.label5);
            this.tabPageHost.Controls.Add(this.buttonConfigServer);
            this.tabPageHost.Controls.Add(this.textBox1);
            this.tabPageHost.Controls.Add(this.kComboBoxMode);
            this.tabPageHost.Controls.Add(this.kComboBoxMap);
            this.tabPageHost.Controls.Add(this.kBtnHost);
            this.tabPageHost.Controls.Add(this.label4);
            this.tabPageHost.Controls.Add(this.textBoxAdminPassword);
            this.tabPageHost.Controls.Add(this.textBox4);
            this.tabPageHost.Controls.Add(this.textBox3);
            this.tabPageHost.Controls.Add(this.textBox2);
            this.tabPageHost.Controls.Add(this.label3);
            this.tabPageHost.Controls.Add(this.label2);
            this.tabPageHost.Controls.Add(this.textBoxServerName);
            this.tabPageHost.Controls.Add(this.labelServerName);
            this.tabPageHost.Location = new System.Drawing.Point(4, 4);
            this.tabPageHost.Name = "tabPageHost";
            this.tabPageHost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHost.Size = new System.Drawing.Size(659, 405);
            this.tabPageHost.TabIndex = 3;
            this.tabPageHost.Text = "Host Server";
            this.tabPageHost.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(201, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 106;
            this.label5.Text = "Password";
            this.label5.Visible = false;
            // 
            // buttonConfigServer
            // 
            this.buttonConfigServer.Enabled = false;
            this.buttonConfigServer.Location = new System.Drawing.Point(384, 367);
            this.buttonConfigServer.Name = "buttonConfigServer";
            this.buttonConfigServer.Size = new System.Drawing.Size(123, 30);
            this.buttonConfigServer.TabIndex = 105;
            this.buttonConfigServer.Text = "Config";
            this.buttonConfigServer.UseVisualStyleBackColor = true;
            this.buttonConfigServer.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(276, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 104;
            this.textBox1.Visible = false;
            // 
            // kComboBoxMode
            // 
            this.kComboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kComboBoxMode.DropDownWidth = 121;
            this.kComboBoxMode.Location = new System.Drawing.Point(240, 165);
            this.kComboBoxMode.Name = "kComboBoxMode";
            this.kComboBoxMode.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kComboBoxMode.Size = new System.Drawing.Size(81, 21);
            this.kComboBoxMode.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kComboBoxMode.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kComboBoxMode.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kComboBoxMode.TabIndex = 3;
            // 
            // kComboBoxMap
            // 
            this.kComboBoxMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kComboBoxMap.DropDownWidth = 190;
            this.kComboBoxMap.Location = new System.Drawing.Point(240, 127);
            this.kComboBoxMap.Name = "kComboBoxMap";
            this.kComboBoxMap.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kComboBoxMap.Size = new System.Drawing.Size(190, 21);
            this.kComboBoxMap.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kComboBoxMap.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kComboBoxMap.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kComboBoxMap.TabIndex = 2;
            // 
            // kBtnHost
            // 
            this.kBtnHost.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnHost.Location = new System.Drawing.Point(240, 220);
            this.kBtnHost.Name = "kBtnHost";
            this.kBtnHost.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnHost.Size = new System.Drawing.Size(164, 45);
            this.kBtnHost.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnHost.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnHost.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnHost.StateNormal.Back.Color1 = System.Drawing.Color.Blue;
            this.kBtnHost.StateNormal.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kBtnHost.StatePressed.Back.Color1 = System.Drawing.Color.DarkBlue;
            this.kBtnHost.StatePressed.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kBtnHost.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(15)))), ((int)(((byte)(189)))));
            this.kBtnHost.StateTracking.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kBtnHost.TabIndex = 4;
            this.kBtnHost.Values.Text = "HOST";
            this.kBtnHost.Click += new System.EventHandler(this.kBtnHost_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(222, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 99;
            this.label4.Text = "Admin password";
            this.label4.Visible = false;
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Location = new System.Drawing.Point(360, 341);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(122, 20);
            this.textBoxAdminPassword.TabIndex = 91;
            this.textBoxAdminPassword.Tag = "GroupEnable";
            this.textBoxAdminPassword.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 98;
            this.textBox4.Text = "map list";
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 377);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 97;
            this.textBox3.Text = "players";
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 351);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 96;
            this.textBox2.Text = "time";
            this.textBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(158, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 95;
            this.label3.Text = "Mode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(168, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Map :";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(240, 89);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(215, 20);
            this.textBoxServerName.TabIndex = 1;
            this.textBoxServerName.Tag = "GroupEnable";
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.BackColor = System.Drawing.Color.Transparent;
            this.labelServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerName.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelServerName.Location = new System.Drawing.Point(102, 88);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(116, 18);
            this.labelServerName.TabIndex = 93;
            this.labelServerName.Text = "Server Name :";
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageConfig.Controls.Add(this.groupBox1);
            this.tabPageConfig.Controls.Add(this.kBtnLocate);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 4);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Size = new System.Drawing.Size(659, 405);
            this.tabPageConfig.TabIndex = 4;
            this.tabPageConfig.Text = "Config ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kBtnReport);
            this.groupBox1.Controls.Add(this.labelIp);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.labelTimePlayed);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.kBtnSavePassword);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxEmailConfirm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPassConfirm);
            this.groupBox1.Controls.Add(this.kBtnSaveEmail);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxCurrentPass);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 330);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            // 
            // kBtnReport
            // 
            this.kBtnReport.Location = new System.Drawing.Point(562, 12);
            this.kBtnReport.Name = "kBtnReport";
            this.kBtnReport.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnReport.Size = new System.Drawing.Size(75, 25);
            this.kBtnReport.StateNormal.Back.Color1 = System.Drawing.Color.DarkGray;
            this.kBtnReport.StateNormal.Back.Color2 = System.Drawing.Color.DarkGray;
            this.kBtnReport.StatePressed.Back.Color1 = System.Drawing.Color.Gray;
            this.kBtnReport.StatePressed.Back.Color2 = System.Drawing.Color.Gray;
            this.kBtnReport.StateTracking.Back.Color1 = System.Drawing.Color.DarkGray;
            this.kBtnReport.StateTracking.Back.Color2 = System.Drawing.Color.Gray;
            this.kBtnReport.TabIndex = 125;
            this.kBtnReport.Values.Text = "Report bug";
            this.kBtnReport.Click += new System.EventHandler(this.kBtnReport_Click);
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(75, 41);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(15, 13);
            this.labelIp.TabIndex = 128;
            this.labelIp.Text = "ip";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 127;
            this.label15.Text = "Current ip :";
            // 
            // labelTimePlayed
            // 
            this.labelTimePlayed.AutoSize = true;
            this.labelTimePlayed.Location = new System.Drawing.Point(87, 65);
            this.labelTimePlayed.Name = "labelTimePlayed";
            this.labelTimePlayed.Size = new System.Drawing.Size(86, 13);
            this.labelTimePlayed.TabIndex = 126;
            this.labelTimePlayed.Text = "Not yet available";
            this.labelTimePlayed.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 125;
            this.label13.Text = "Time played :";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 122;
            this.label12.Text = "Email :";
            // 
            // kBtnSavePassword
            // 
            this.kBtnSavePassword.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnSavePassword.Location = new System.Drawing.Point(173, 284);
            this.kBtnSavePassword.Name = "kBtnSavePassword";
            this.kBtnSavePassword.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnSavePassword.Size = new System.Drawing.Size(73, 27);
            this.kBtnSavePassword.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnSavePassword.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnSavePassword.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnSavePassword.StateNormal.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.kBtnSavePassword.StateNormal.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kBtnSavePassword.StatePressed.Back.Color1 = System.Drawing.Color.Blue;
            this.kBtnSavePassword.StatePressed.Back.Color2 = System.Drawing.Color.Blue;
            this.kBtnSavePassword.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.kBtnSavePassword.StateTracking.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kBtnSavePassword.TabIndex = 5;
            this.kBtnSavePassword.Values.Text = "Save";
            this.kBtnSavePassword.Click += new System.EventHandler(this.kBtnSavePassword_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(327, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 121;
            this.label11.Text = "confirm email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(30, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 115;
            this.label8.Text = "confirm password :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(55, 16);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(31, 13);
            this.labelEmail.TabIndex = 123;
            this.labelEmail.Text = "email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(30, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 114;
            this.label7.Text = "new password :";
            // 
            // textBoxEmailConfirm
            // 
            this.textBoxEmailConfirm.Location = new System.Drawing.Point(421, 213);
            this.textBoxEmailConfirm.Name = "textBoxEmailConfirm";
            this.textBoxEmailConfirm.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmailConfirm.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(30, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 113;
            this.label6.Text = "current password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(137, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Change Password";
            // 
            // textBoxPassConfirm
            // 
            this.textBoxPassConfirm.Location = new System.Drawing.Point(143, 258);
            this.textBoxPassConfirm.Name = "textBoxPassConfirm";
            this.textBoxPassConfirm.Size = new System.Drawing.Size(131, 20);
            this.textBoxPassConfirm.TabIndex = 4;
            this.textBoxPassConfirm.UseSystemPasswordChar = true;
            // 
            // kBtnSaveEmail
            // 
            this.kBtnSaveEmail.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnSaveEmail.Location = new System.Drawing.Point(469, 239);
            this.kBtnSaveEmail.Name = "kBtnSaveEmail";
            this.kBtnSaveEmail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnSaveEmail.Size = new System.Drawing.Size(73, 27);
            this.kBtnSaveEmail.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnSaveEmail.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnSaveEmail.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnSaveEmail.StateNormal.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.kBtnSaveEmail.StateNormal.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kBtnSaveEmail.StatePressed.Back.Color1 = System.Drawing.Color.Blue;
            this.kBtnSaveEmail.StatePressed.Back.Color2 = System.Drawing.Color.Blue;
            this.kBtnSaveEmail.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.kBtnSaveEmail.StateTracking.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kBtnSaveEmail.TabIndex = 8;
            this.kBtnSaveEmail.Values.Text = "Save";
            this.kBtnSaveEmail.Click += new System.EventHandler(this.kBtnSaveEmail_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(143, 232);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(131, 20);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(452, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 116;
            this.label9.Text = "Change email";
            // 
            // textBoxCurrentPass
            // 
            this.textBoxCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPass.Location = new System.Drawing.Point(143, 187);
            this.textBoxCurrentPass.Name = "textBoxCurrentPass";
            this.textBoxCurrentPass.Size = new System.Drawing.Size(131, 23);
            this.textBoxCurrentPass.TabIndex = 2;
            this.textBoxCurrentPass.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(421, 187);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(327, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 117;
            this.label10.Text = "new email :";
            // 
            // kBtnLocate
            // 
            this.kBtnLocate.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnLocate.Location = new System.Drawing.Point(228, 353);
            this.kBtnLocate.Name = "kBtnLocate";
            this.kBtnLocate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnLocate.Size = new System.Drawing.Size(195, 27);
            this.kBtnLocate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kBtnLocate.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnLocate.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnLocate.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.kBtnLocate.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.kBtnLocate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kBtnLocate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kBtnLocate.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.kBtnLocate.StateTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.kBtnLocate.TabIndex = 1;
            this.kBtnLocate.Values.Text = "Locate Forge Executable";
            this.kBtnLocate.Click += new System.EventHandler(this.kBtnLocate_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(667, 507);
            this.Controls.Add(this.fixedTabControl1);
            this.Controls.Add(this.kHeader);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlPanel_FormClosed);
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHeader.Panel)).EndInit();
            this.kHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHeader)).EndInit();
            this.kHeader.ResumeLayout(false);
            this.fixedTabControl1.ResumeLayout(false);
            this.tabPageConnect.ResumeLayout(false);
            this.tabPageHost.ResumeLayout(false);
            this.tabPageHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kComboBoxMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kComboBoxMap)).EndInit();
            this.tabPageConfig.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kHeader;
        private System.Windows.Forms.OpenFileDialog openFileDialogPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnPlayersOnline;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnLogout;
        private FixedTabControl fixedTabControl1;
        private System.Windows.Forms.TabPage tabPageConnect;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnConnectLocal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnConnect;
        public System.Windows.Forms.ListView listViewServer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listViewPlayersOnServer;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TabPage tabPageHost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConfigServer;
        private System.Windows.Forms.TextBox textBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kComboBoxMode;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kComboBoxMap;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.TabPage tabPageConfig;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnLocate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassConfirm;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxCurrentPass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnSaveEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnSavePassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEmailConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelTimePlayed;
        private System.Windows.Forms.Label label13;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnReport;
    }
}