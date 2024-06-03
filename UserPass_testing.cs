using System;

namespace CSharpLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my testing console!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            bool logged = false;

            while (!logged)   //Vong lap de tiep tuc nhap lai thong tin khi sai
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                Console.Clear();

                Console.Write("Enter password: ");
                string password = ReadPassword();
                Console.Clear();

                logged = Authenticate(username, password);

                if (logged)     //In ra man hinh khi dang nhap thanh cong hoac that bai
                {
                    Console.WriteLine("Login Successful");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong username or password!");
                    Console.WriteLine("Press any key to relogin");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static bool Authenticate(string username, string password)    //Xac minh dang nhap
        {
            const string validUser = "akuali";
            const string validPassword = "52179436";
            return username == validUser && password == validPassword;
        }

        static string ReadPassword()    //Doc mat khau chuyen ve dang ****, nhap enter de ket thuc viec nhap
        {
            string password = "";
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, password.Length - 1);
                    Console.Write("\b \b");
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            return password;
        }
    }
}
