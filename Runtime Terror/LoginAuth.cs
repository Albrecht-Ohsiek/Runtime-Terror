using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runtime_Terror
{
    internal class LoginAuth
    {
        public static bool passCheck(string username, string password)
        {
            string filename = @"users.txt";
            List<string> users = FileHandler.readFromFile(filename);

            for (int i = 0; i < users.Count; i += 2)
            {
                if (users[i] == Encrypter.encryption(username) && users[i + 1] == Encrypter.encryption(password))
                {
                    return true;
                }
            }

            return false;
        }
               
    }
}
