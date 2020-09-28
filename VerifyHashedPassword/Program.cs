using System;
using System.Web.Helpers;

namespace VerifyHashedPassword
{
    internal class Program
    {
        static private string encryptionPassword = "";//加密後的密碼

        private static void Main(string[] args)
        {
            string password = "test";
            //var salt = Crypto.GenerateSalt();
            //password += salt;

            for (int i = 0; i < 10; i++) {
                SavePassword(password);
                Console.WriteLine($"{encryptionPassword} => {CheckPassword(password)}");
            }

            Console.ReadLine();
        }

        private static void SavePassword(string unhashedPassword)
        {
            encryptionPassword = Crypto.HashPassword(unhashedPassword);
        }

        private static bool CheckPassword(string unhashedPassword)
        {
            return Crypto.VerifyHashedPassword(encryptionPassword, unhashedPassword);
        }
    }
}