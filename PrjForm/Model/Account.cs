using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjForm.Model
{
    internal class Account
    {
        // username password user_code
        private string username;
        private string password;
        private string user_code;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string User_code { get => user_code; set => user_code = value; }

        
        
    }
}