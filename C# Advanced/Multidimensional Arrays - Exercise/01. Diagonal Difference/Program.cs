namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                sumFirstDiagonal += matrix[i, i];
                sumSecondDiagonal += matrix[i, n - i - 1];

            }

            Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));

        }
    }
}