using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelAutomation
{
   public class Crypt
    {
        public static string SHA256Hash(string password)
        {
            string source = password;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hasBytes = sha256.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hasBytes).Replace("-", String.Empty);
                return hash;
            }
        }
    }
}
