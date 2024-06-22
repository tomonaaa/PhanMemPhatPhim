using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login1
{
    internal class Account
    {
        private string Username;
        private string Password;

        //constructor k chua tham so
        public Account()
        {
        }

        //constructor chua tham so
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}
