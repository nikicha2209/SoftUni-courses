using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double lv = Math.Floor(coins);
            double coinsInCents = Math.Round((coins - lv) * 100);
            double count = 0;

            while (lv > 0)
            {
                if (lv >= 2)
                {
                    count += 1;
                    lv -= 2;
                }
                else if (lv >= 1)
                {
                    count += 1;
                    lv -= 1;
                }
            }
            while (coinsInCents  > 0)
            {
                if (coinsInCents  >= 50)
                {
                    count += 1;
                    coinsInCents  -= 50;
                }
                else if (coinsInCents  >= 20)
                {
                    count += 1;
                    coinsInCents  -= 20;
                }
                else if (coinsInCents  >= 10)
                {
                    count += 1;
                    coinsInCents  -= 10;
                }
                else if (coinsInCents  >= 05)
                {
                    count += 1;
                    coinsInCents  -= 05;
                }
                else if (coinsInCents  >= 02)
                {
                    count += 1;
                    coinsInCents  -= 02;
                }
                else if (coinsInCents  >= 01)
                {
                    count += 1;
                    coinsInCents  -= 01;
                    break;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
