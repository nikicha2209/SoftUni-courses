namespace _03._Shopping_Spree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                people = ReadPeopleInfo();
                products = ReadProductsInfo();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "END")
            {
                string personName = line.Split().First();
                string productName = line.Split().Last();
                Person currentPerson = people.Find(p => personName == p.Name);
                Product currentProduct = products.Find(p => productName == p.Name);

                if (currentProduct != null && currentProduct != null)
                {
                    currentPerson.BuyProduct(currentProduct);
                }
            }


            foreach (Person person in people)
            {
                if (person.BagOfProducts.Any())
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                }

                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }

        private static List<Person> ReadPeopleInfo()
        {
            List<Person> people = new List<Person>();
            string[] info = Console.ReadLine().Split(";");

            for (int i = 0; i < info.Length; i++)
            {
                string name = info[i].Split("=").First();
                decimal money = decimal.Parse(info[i].Split("=").Last());

                people.Add(new Person(name, money));
            }

            return people;
        }

        private static List<Product> ReadProductsInfo()
        {
            List<Product> products = new List<Product>();
            string[] info = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < info.Length; i++)
            {
                string name = info[i].Split('=').First();
                decimal cost = decimal.Parse(info[i].Split("=").Last());

                products.Add(new Product(name, cost));
            }

            return products;

        }
    }
}