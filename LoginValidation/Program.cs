using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string password = "pass1234";
            string userName, userPassword;


            int try1 = 0;

            while (try1 != 3)
            {
                Console.WriteLine("enter your username");
                userName = Console.ReadLine();
                Console.WriteLine("enter your password");
                userPassword = Console.ReadLine();

                if (login != userName || password != userPassword)
                {
                    Console.WriteLine("Oops.. Something went wrong");
                    try1++;
                    Console.WriteLine($"{3 - try1} attempts left");
                }
                else
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
            }
        }
    }
}
