namespace _07._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];
            pascal[0] = new long [1]{ 1 };

            for (int row = 1; row < n; row++)
            {
                pascal[row] = new long[row + 1];

                for (int col = 0; col < pascal[row].Length; col++)
                {
                    if (col == 0 || col == pascal[row].Length - 1)
                    {
                        pascal[row][col] = 1;
                        continue;
                    }
                    pascal[row][col] = pascal[row - 1][col] + pascal[row - 1][col - 1];
                }
            }

            foreach (var item in pascal)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}