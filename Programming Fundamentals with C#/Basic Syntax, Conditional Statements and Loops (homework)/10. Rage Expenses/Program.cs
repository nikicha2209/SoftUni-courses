using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetBreak = 0;
            int mouseBreak = 0;
            int keyboardBreak = 0;
            int displayBreak = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetBreak++;
                }

                if (i % 3 == 0)
                {
                    mouseBreak++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardBreak++;

                    if (keyboardBreak % 2 == 0)
                    {
                        displayBreak++;
                    }
                } 
            }

            headsetPrice = headsetPrice* headsetBreak;
            mousePrice = mousePrice* mouseBreak;
            keyboardPrice = keyboardPrice* keyboardBreak;
            displayPrice = displayPrice* displayBreak;
            Console.WriteLine($"Rage expenses: {headsetPrice+mousePrice+keyboardPrice+displayPrice:f2} lv.");
        }
    }
}
