using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesDictionary = new Dictionary<string, int>();

            string resource;
            int quantity;

            while ((resource = Console.ReadLine()) != "stop")
            {
                quantity = int.Parse(Console.ReadLine());

                if (!resourcesDictionary.ContainsKey(resource))
                {
                    resourcesDictionary[resource] = 0;
                }

                resourcesDictionary[resource] += quantity;
            }

            foreach (KeyValuePair<string, int> value in resourcesDictionary)
            {
                Console.WriteLine($"{value.Key} -> {value.Value}");
            }
        }
    }
}
