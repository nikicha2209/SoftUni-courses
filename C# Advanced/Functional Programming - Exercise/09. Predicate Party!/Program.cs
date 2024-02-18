namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string line = Console.ReadLine();


            while ((line = Console.ReadLine()) != "Party!")
            {
                string[] tokens = line.Split();
                string command = tokens[0];

                guests = Filter(guests, line);

            }

            if (guests.Length > 0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }

            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static string[] Filter(string[] names, string line)
        {
            string[] tokens = line.Split();
            string command = tokens[0];
            string value = tokens.Length > 1 ? tokens[1] : null;
            switch (tokens[1])
            {
                case "StartsWith":
                
                    break;
                case "EndsWith":

                    break;
                case "Length":
                    break;
            }

            return default;
        }
    }
}





//if (command == "Remove")
//{
//    switch (tokens[1])
//    {
//        case "StartsWith":
//            names => names.Where(name => name.Start)
//            break;
//        case "EndsWith":

//            break;
//        case "Length":
//            break;
//    }
//}

//else if (command == "Double")
//{
//    switch (tokens[1])
//    {
//        case "StartsWith":
//            break;
//        case "EndsWith":
//            break;
//        case "Length":
//            break;
//    }
//}