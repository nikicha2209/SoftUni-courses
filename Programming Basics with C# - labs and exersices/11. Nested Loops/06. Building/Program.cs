using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int floorNumber = 1; floorNumber <= floor; floorNumber++)
            {
                for (int roomNumber = 0; roomNumber < room; roomNumber++)
                {
                    if (floorNumber == 1)
                    {
                        Console.Write($"L{floor}{roomNumber} ");
                    }

                    else
                    {
                        if (floor % 2 == 0)
                        {
                            if (floorNumber % 2 == 1)
                            {
                                Console.Write($"O{floor - floorNumber + 1}{roomNumber} ");
                            }

                            else
                            {
                                Console.Write($"A{floor - floorNumber + 1}{roomNumber} ");
                            }
                        }

                        else
                        {
                            if (floorNumber % 2 == 1)
                            {
                                Console.Write($"A{floor - floorNumber + 1}{roomNumber} ");
                            }

                            else
                            {
                                Console.Write($"O{floor - floorNumber + 1}{roomNumber} ");
                            }
                        }

                    }

                }
                Console.WriteLine("");  
            }
        }
    }
}
