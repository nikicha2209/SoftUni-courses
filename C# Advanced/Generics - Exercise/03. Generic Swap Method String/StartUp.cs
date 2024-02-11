namespace _03._Generic_Swap_Method_String
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            string line;

            for (int i = 0; i < n; i++)
            {
                list.Add(line = Console.ReadLine());
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<string> swappedList = Swap(list, indexes[0], indexes[1]);

            foreach (string item in swappedList)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public static List<T> Swap<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
            return list;
        }
    }
}