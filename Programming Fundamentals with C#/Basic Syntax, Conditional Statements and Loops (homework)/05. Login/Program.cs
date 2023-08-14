using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }
            
            string tryPassword = Console.ReadLine();
            int attemps = 0;
            while (tryPassword!=password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                
                if(attemps == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                tryPassword = Console.ReadLine();
                attemps++;
            }

            if (attemps < 3)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            
        }
    }
}
