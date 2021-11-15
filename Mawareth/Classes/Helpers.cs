using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Mawareth.Classes
{
    public static class Helpers
    {
        public static string EnryptString(string strEncrypted)
        {
            byte[] b = Encoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }

        public static string DecryptString(string encrString)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(encrString);
                decrypted = Encoding.ASCII.GetString(b);
            }
            catch (FormatException)
            {
                decrypted = string.Empty;
            }
            return decrypted;
        }

        public static bool IsValidEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success == true;
        }
    }
}
