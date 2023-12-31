namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            Dictionary<string, Dictionary<string, double>> shopInformation = new Dictionary<string, Dictionary<string, double>>();
            while ((line = Console.ReadLine()) != "Revision")
            {
                string[] tokens = line.Split(", ");
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shopInformation.ContainsKey(shop))
                {
                    shopInformation[shop] = new Dictionary<string, double>();
                }

                shopInformation[shop].Add(product, price);
            }

            var orderedDictionary = shopInformation.OrderBy(x => x.Key);

            foreach (var kvp in orderedDictionary)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"Product: {kvp2.Key}, Price: {kvp2.Value}");
                }
            }
        }
    }
}