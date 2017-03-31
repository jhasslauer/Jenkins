using Newtonsoft.Json;
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
    public partial class Register : Form
    {
        WebService ws = null;
        EmailSender eSender = null;

        public Register(WebService w)
        {
            InitializeComponent();
            ws = w;
            eSender = new EmailSender();
        }

        private async void kBtnRegister_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
            {
                User user = new User(textBoxUsername.Text, textBoxLogin.Text, textBoxPassword.Text, textBoxEmail.Text, "", "0");

                bool sucess = eSender.sendEmail("", textBoxEmail.Text, "Account Creation", "Hi " + textBoxUsername.Text + ",\n\nYour account informations :\n\n\tusername : " + textBoxUsername.Text + "\n\tlogin : " + textBoxLogin.Text + "\n\tpassword : " + textBoxPassword.Text + "\n\nGood game.");
                if (!sucess)
                {
                    MessageBox.Show("Wrong email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string json = JsonConvert.SerializeObject(user);
                    json = json.Insert(0, "{\"create_user\":[");
                    json = json.Insert(json.Length, "]}");

                    string result = await ws.postJsonAsync("user.php", json);

                    if (result.Contains("email_exist"))
                    {
                        MessageBox.Show("Email already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxEmail.Clear();
                    }
                    else if (result.Equals("user_exist"))
                    {
                        textBoxUsername.Clear();
                        textBoxLogin.Clear();
                        textBoxPassword.Clear();
                        MessageBox.Show("Username already taken !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result.Equals("login_exist"))
                    {
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        textBoxEmail.Clear();
                        MessageBox.Show("Login already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result.Equals("error"))
                    {
                        MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        textBoxUsername.Clear();
                        textBoxLogin.Clear();
                        textBoxPassword.Clear();
                        textBoxEmail.Clear();
                        MessageBox.Show("Registration success !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Password does not match the confirm password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if(textBoxUsername.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxPassword.Text != "" && textBoxConfirmPassword.Text != "" && textBoxEmail.Text != "")
            {
                kBtnRegister.Enabled = true;
            }
            else
            {
                kBtnRegister.Enabled = false;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxPassword.Text != "" && textBoxConfirmPassword.Text != "" && textBoxEmail.Text != "")
            {
                kBtnRegister.Enabled = true;
            }
            else
            {
                kBtnRegister.Enabled = false;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxPassword.Text != "" && textBoxConfirmPassword.Text != "" && textBoxEmail.Text != "")
            {
                kBtnRegister.Enabled = true;
            }
            else
            {
                kBtnRegister.Enabled = false;
            }
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxPassword.Text != "" && textBoxConfirmPassword.Text != "" && textBoxEmail.Text != "")
            {
                kBtnRegister.Enabled = true;
            }
            else
            {
                kBtnRegister.Enabled = false;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxPassword.Text != "" && textBoxConfirmPassword.Text != "" && textBoxEmail.Text != "")
            {
                kBtnRegister.Enabled = true;
            }
            else
            {
                kBtnRegister.Enabled = false;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
