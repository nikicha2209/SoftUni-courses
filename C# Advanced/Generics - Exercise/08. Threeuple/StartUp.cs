namespace _08._Threeuple
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAddressTown = Console.ReadLine().Split();
            string[] nameBeer = Console.ReadLine().Split();
            string[] nameBank = Console.ReadLine().Split();

            Threeuple<string, string, string> firstThreeuple =
                new Threeuple<string, string, string>($"{nameAddressTown[0]} {nameAddressTown[1]}", nameAddressTown[2], string.Join(" ", nameAddressTown[3..]));

            Threeuple<string, int, bool> secondThreeuple =
                new Threeuple<string, int, bool>(nameBeer[0], int.Parse(nameBeer[1]), nameBeer[2] == "drunk");

            Threeuple<string, double, string> thirdThreeuple =
                new Threeuple<string, double, string>(nameBank[0], double.Parse(nameBank[1]), nameBank[2]);

            Console.WriteLine(firstThreeuple.ToString());
            Console.WriteLine(secondThreeuple.ToString());
            Console.WriteLine(thirdThreeuple.ToString());
        }
    }
}