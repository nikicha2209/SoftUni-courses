using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int pieces = 0;
            int piecesInCake = width * length;

            while (command != "STOP")
            {
                pieces = int.Parse(command);

                if (piecesInCake >= pieces)
                {
                    piecesInCake -= pieces;
                }

                else
                {
                    piecesInCake = Math.Abs(piecesInCake - pieces);
                    Console.WriteLine($"No more cake left! You need {piecesInCake} pieces more.");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "STOP")
            {
                Console.WriteLine($"{piecesInCake} pieces are left.");
            }
        }
    }
}
