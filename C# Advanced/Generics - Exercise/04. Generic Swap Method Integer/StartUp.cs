namespace _04._Generic_Swap_Method_Integer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int number;

            for (int i = 0; i < n; i++)
            {
                list.Add(number = int.Parse(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> reversedList = Swap(list, indexes[0], indexes[1]);

            foreach (int item in reversedList)
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