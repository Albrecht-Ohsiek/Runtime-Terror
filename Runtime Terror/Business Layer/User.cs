using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Terror
{
    internal class User
    {
        //Data Fields
        private string password;
        private string username;

        //Properties
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }

        //Constructor
        public User() { }

        public User(string password, string username) 
        { 
            this.password = password;
            this.username = username;
        }
        

    }
}
