using System;

namespace GuessThePassword
{
    class GuessThePassword
    {
        static void Main()
        {
            string currentPassword = "s3cr3t!P@ssw0rd";
            string password = Console.ReadLine();

            if (password.Contains(currentPassword))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
