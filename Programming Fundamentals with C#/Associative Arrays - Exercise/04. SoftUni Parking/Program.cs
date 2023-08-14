using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] argumemts = line.Split(' ');
                string command = argumemts[0];


                if (command == "register")
                {
                    string username = argumemts[1];
                    string licensePlateNumber = argumemts[2];

                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                    else
                    {
                        parking[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }

                else if (command == "unregister")
                {
                    string username = argumemts[1];
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }

                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (KeyValuePair<string, string> pair in parking)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
