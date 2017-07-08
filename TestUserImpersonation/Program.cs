using System;
using System.IO;

namespace TestUserImpersonation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "";
            string domain = "";
            string password = "";

            using (UserImpersonation user = new UserImpersonation(login, domain, password))
            {
                if (user.Connected)
                {
                    File.WriteAllText("test2.txt", "Voici mon texte");
                    Console.WriteLine("File writed");
                }
                else
                {
                    Console.WriteLine("User not connected");
                }
            }

            Console.ReadKey();
        }
    }
}
