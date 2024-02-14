namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] setsLengths = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int nLength = setsLengths[0];
            int mLength = setsLengths[1];
            List<int> outputList = new List<int>();

            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();

            for (int i = 0; i < nLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                n.Add(number);
            }

            for (int i = 0; i < mLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                m.Add(number);
            }


            foreach (int number in n)
            {
                if (m.Contains(number))
                {
                    outputList.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}