using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgeLauncher
{
    class User
    {
        string username;
        string login;
        string password;
        string email;
        string ip;
        string online;

        public User(string u, string l, string p, string e, string i, string o)
        {
            Username = u;
            Login = l;
            Password = p;
            Email = e;
            Ip = i;
            Online = o;
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public string Online
        {
            get
            {
                return online;
            }

            set
            {
                online = value;
            }
        }
    }
}
