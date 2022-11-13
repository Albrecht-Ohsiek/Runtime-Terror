using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Terror
{
    internal class Encrypter
    {
        public static string encryption(string mystring)
        {
            string encryptedString;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] sha = sha256.ComputeHash(Encoding.UTF8.GetBytes(mystring));

                encryptedString = Convert.ToBase64String(sha);
            }

            return encryptedString;
        }
    }
}
