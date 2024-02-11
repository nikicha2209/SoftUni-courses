using System.Runtime.InteropServices;

namespace _07._Tuple
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine().Split();
            string[] nameAndBeer = Console.ReadLine().Split();
            string[] numbers = Console.ReadLine().Split();

            CustomTuple<string, string> firstTuple =
                new CustomTuple<string, string>($"{nameAndAddress[0]} {nameAndAddress[1]}", nameAndAddress[2]);

            CustomTuple<string, int> secondTuple =
                new CustomTuple<string, int>(nameAndBeer[0], int.Parse(nameAndBeer[1]));

            CustomTuple<int, double> thirdTuple =
                new CustomTuple<int, double>(int.Parse(numbers[0]), double.Parse(numbers[1]));

            Console.WriteLine(firstTuple.ToString());
            Console.WriteLine(secondTuple.ToString());
            Console.WriteLine(thirdTuple.ToString());

        }
    }
}