namespace ForgeLauncher
{
    partial class PlayerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerList));
            this.listViewPlayerList = new System.Windows.Forms.ListView();
            this.columnHeaderPlayer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPlayerList
            // 
            this.listViewPlayerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.listViewPlayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPlayer});
            this.listViewPlayerList.FullRowSelect = true;
            this.listViewPlayerList.Location = new System.Drawing.Point(12, 51);
            this.listViewPlayerList.Name = "listViewPlayerList";
            this.listViewPlayerList.Size = new System.Drawing.Size(207, 260);
            this.listViewPlayerList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPlayerList.TabIndex = 14;
            this.listViewPlayerList.UseCompatibleStateImageBehavior = false;
            this.listViewPlayerList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPlayer
            // 
            this.columnHeaderPlayer.Text = "Players";
            this.columnHeaderPlayer.Width = 202;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(81, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // PlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 323);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.listViewPlayerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 0);
            this.MaximizeBox = false;
            this.Name = "PlayerList";
            this.Text = "Players online";
            this.Load += new System.EventHandler(this.PlayerList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPlayerList;
        private System.Windows.Forms.ColumnHeader columnHeaderPlayer;
        private System.Windows.Forms.Button buttonRefresh;
    }
}