namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            HashSet<string> parking = new HashSet<string>();
            while ((line = Console.ReadLine()) != "END")
            {
                string[] tokens = line.Split(", ");
                string command = tokens[0];
                string carNumber = tokens[1];

                if (command == "IN")
                {
                    parking.Add(carNumber);
                }

                else if (command == "OUT")
                {
                    parking.Remove(carNumber);
                }
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            else
            {
                Console.WriteLine(string.Join("\n", parking));
            }
        }
    }
}