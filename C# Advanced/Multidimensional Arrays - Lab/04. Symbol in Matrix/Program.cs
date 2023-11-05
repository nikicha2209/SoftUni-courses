namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string rowValues = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            char searchedSymbol = char.Parse(Console.ReadLine());
            bool found = false;

            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == searchedSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if(!found)
            {
                Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
            }


        }
    }
}