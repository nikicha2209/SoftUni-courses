using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{

    /*
3
tt(''DGsvywgerx>6444444444%H%1B9444
GQhrr|A977777(H(TTTT
EHfsytsnhf?8555&I&2C9555SR
     */

    class Message
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public char AttackType { get; set; }
        public int SoldierCount { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();
            int n = int.Parse(Console.ReadLine());
            string starPattern = @"[SsTtAaRr]";
            string messagePattern =
                @"[^\@\-\!\:\>]*@(?<name>[A-Z][a-z]+)[^\@\-\!\:\>]*:(?<population>\d+)[^\@\-\!\:\>]*!(?<attackType>[A]|[D])![^\@\-\!\:\>]*->(?<soldierCount>\d+)[^\@\-\!\:\>]*";

            string line = Console.ReadLine();

            for (int i = 1; i <= n; i++)
            {
                StringBuilder sb = new StringBuilder();
                int starLetters = Regex.Matches(line, starPattern).Count;

                foreach (char letter in line)
                {
                    sb.Append((char)(letter - starLetters));
                }

                string encryptedMessage = sb.ToString();

                Match match = Regex.Match(encryptedMessage, messagePattern);
                if (!Regex.IsMatch(encryptedMessage, messagePattern))
                {
                    if (i < n)
                    {
                        line = Console.ReadLine();
                    }
                    continue;
                }

                Message message = new Message();
                message.Name = match.Groups["name"].Value;
                message.Population = int.Parse(match.Groups["population"].Value);
                message.AttackType = char.Parse(match.Groups["attackType"].Value);
                message.SoldierCount = int.Parse(match.Groups["soldierCount"].Value);

                messages.Add(message);

                if (i == n)
                {
                    break;
                }
                line = Console.ReadLine();
            }
            List<Message> attackedList = new List<Message>();
            List<Message> destroyedList = new List<Message>();


            foreach (Message message in messages)
            {
                if (message.AttackType == 'A')
                {
                    attackedList.Add(message);
                }

                else if (message.AttackType == 'D')
                {
                    destroyedList.Add(message);
                }
            }

            attackedList = attackedList.OrderBy(x => x.Name).ToList();
            destroyedList = destroyedList.OrderBy(x => x.Name).ToList();


            Console.WriteLine($"Attacked planets: {attackedList.Count}");
            foreach (Message message in attackedList)
            {
                Console.WriteLine($"-> {message.Name}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedList.Count}");
            foreach (Message message in destroyedList)
            {
                Console.WriteLine($"-> {message.Name}");

            }
        }
    }
}
