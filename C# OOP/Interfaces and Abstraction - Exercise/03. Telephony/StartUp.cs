

namespace _03._Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] urls = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in phoneNumbers)
            {
                if (number.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Call(number));
                }

                else if (number.Length == 10)
                {
                    Console.WriteLine(smartphone.Call(number));
                }
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }

        }
    }
}