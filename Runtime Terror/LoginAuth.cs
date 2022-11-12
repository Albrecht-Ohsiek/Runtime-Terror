using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runtime_Terror
{
    internal class LoginAuth
    {
        List<User> users = new List<User>();

        public LoginAuth()
        {
            string filename = @"users.txt";
            List<string> list = new List<string>();
            list = FileHandler.readFromFile(filename);

            foreach (var item in list)
            {
                string[] text = item.ToString().Split(' ');
                User user = new User();
                user.Username = text[0];
                user.Password = text[1];
                users.Add(user);
            }
        }

        public bool passCheck(string username, string password)
        {                 
            foreach (var item in users)
            {
                if (item.Username == Encrypter.encryption(username) && item.Password == Encrypter.encryption(password))
                {
                    return true;
                }
            }
            return false;
        }

        public bool userCheck(string username)
        {
            foreach (var item in users)
            {
                if (item.Username == Encrypter.encryption(username))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
