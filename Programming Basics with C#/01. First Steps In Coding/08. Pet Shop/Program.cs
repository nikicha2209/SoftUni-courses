using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogPackets = int.Parse(Console.ReadLine());
            int catPackets = int.Parse(Console.ReadLine());
            double totalDog = dogPackets * 2.50;
            int totalCat = catPackets * 4;
            double obshto = totalDog + totalCat;
            Console.WriteLine(obshto + " " + "lv.");
        }
    }
}
