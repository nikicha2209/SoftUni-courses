using System;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string newPassword = string.Empty;

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Done")
            {
                if (line == "TakeOdd")
                {
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        newPassword += password[i];
                    }

                    password = newPassword;
                    Console.WriteLine(password);
                }

                else
                {
                    string[] tokens = line.Split(' ');

                    if (tokens[0] == "Cut")
                    {
                        password = password.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        Console.WriteLine(password);
                    }

                    else if (tokens[0] == "Substitute")
                    {
                        if (password.Contains(tokens[1]))
                        {
                            password = password.Replace(tokens[1], tokens[2]);
                            Console.WriteLine(password);
                        }

                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                    }
                }

            }
                
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
