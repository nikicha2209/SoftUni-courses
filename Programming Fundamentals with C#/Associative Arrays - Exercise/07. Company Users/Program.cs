using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            while ((line = Console.ReadLine()) != "End")
            {
                string[] arguments = line.Split(" -> ");
                string companyName = arguments[0];
                string ID = arguments[1];

                if (!company.ContainsKey(companyName))
                {
                    company[companyName] = new List<string>();
                }

                if (!company[companyName].Contains(ID))
                {

                    company[companyName].Add(ID);
                }

            }

            foreach (KeyValuePair<string, List<string>> pair in company)
            {
                Console.WriteLine(pair.Key);
                pair.Value.ForEach(x => Console.WriteLine($"-- {x}"));

            }
        }
    }
}
