using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Terror
{
    internal class LoginAuth
    {
        public static bool passCheck(string username, string password)
        {
            List<string> list = new List<string>();
            list = FileHandler.readFromFile("users.txt");

            List<User> users = new List<User>();
            foreach (var item in list)
            {
                string[] text = item.ToString().Split(' ');

                User user = new User();
                user.Username = text[0];
                user.Password = text[1];
                users.Add(user);
            }

            foreach (var item in users)
            {
                if (item.Username == Encrypter.encryption(username) && item.Password == Encrypter.encryption(password))
                {
                    return true;
                }
            }

            return false;
        }
               
    }
}
