namespace ForgeLauncher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kBtnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kBtnRegister = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kBtnReport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.forgotAccount = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(86, 109);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(132, 20);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(86, 161);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(83, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password  :";
            // 
            // kBtnLogin
            // 
            this.kBtnLogin.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.kBtnLogin.Enabled = false;
            this.kBtnLogin.Location = new System.Drawing.Point(110, 201);
            this.kBtnLogin.Name = "kBtnLogin";
            this.kBtnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.kBtnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kBtnLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnLogin.Size = new System.Drawing.Size(90, 25);
            this.kBtnLogin.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnLogin.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnLogin.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.kBtnLogin.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.kBtnLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kBtnLogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kBtnLogin.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.kBtnLogin.StateTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.kBtnLogin.TabIndex = 11;
            this.kBtnLogin.Values.Text = "Login";
            this.kBtnLogin.Click += new System.EventHandler(this.kBtnLogin_Click);
            // 
            // kBtnRegister
            // 
            this.kBtnRegister.Location = new System.Drawing.Point(110, 249);
            this.kBtnRegister.Name = "kBtnRegister";
            this.kBtnRegister.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.kBtnRegister.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kBtnRegister.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnRegister.Size = new System.Drawing.Size(90, 25);
            this.kBtnRegister.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kBtnRegister.StateDisabled.Back.Color2 = System.Drawing.Color.Silver;
            this.kBtnRegister.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.kBtnRegister.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.kBtnRegister.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kBtnRegister.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kBtnRegister.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.kBtnRegister.StateTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.kBtnRegister.TabIndex = 12;
            this.kBtnRegister.Values.Text = "Register";
            this.kBtnRegister.Click += new System.EventHandler(this.kBtnRegister_Click);
            // 
            // kBtnReport
            // 
            this.kBtnReport.Location = new System.Drawing.Point(225, 328);
            this.kBtnReport.Name = "kBtnReport";
            this.kBtnReport.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kBtnReport.Size = new System.Drawing.Size(75, 25);
            this.kBtnReport.StateNormal.Back.Color1 = System.Drawing.Color.DarkGray;
            this.kBtnReport.StateNormal.Back.Color2 = System.Drawing.Color.DarkGray;
            this.kBtnReport.StatePressed.Back.Color1 = System.Drawing.Color.Gray;
            this.kBtnReport.StatePressed.Back.Color2 = System.Drawing.Color.Gray;
            this.kBtnReport.StateTracking.Back.Color1 = System.Drawing.Color.DarkGray;
            this.kBtnReport.StateTracking.Back.Color2 = System.Drawing.Color.Gray;
            this.kBtnReport.TabIndex = 13;
            this.kBtnReport.Values.Text = "Report bug";
            this.kBtnReport.Click += new System.EventHandler(this.kBtnReport_Click);
            // 
            // forgotAccount
            // 
            this.forgotAccount.AutoSize = true;
            this.forgotAccount.BackColor = System.Drawing.Color.Transparent;
            this.forgotAccount.LinkColor = System.Drawing.Color.Cornsilk;
            this.forgotAccount.Location = new System.Drawing.Point(0, 338);
            this.forgotAccount.Name = "forgotAccount";
            this.forgotAccount.Size = new System.Drawing.Size(154, 13);
            this.forgotAccount.TabIndex = 15;
            this.forgotAccount.TabStop = true;
            this.forgotAccount.Text = "Forgot your login or password ?";
            this.forgotAccount.VisitedLinkColor = System.Drawing.Color.Cornsilk;
            this.forgotAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotAccount_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(86, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ForgeLauncher.Properties.Resources.Forge;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(302, 354);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.forgotAccount);
            this.Controls.Add(this.kBtnReport);
            this.Controls.Add(this.kBtnRegister);
            this.Controls.Add(this.kBtnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Launcher";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnRegister;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kBtnReport;
        private System.Windows.Forms.LinkLabel forgotAccount;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

