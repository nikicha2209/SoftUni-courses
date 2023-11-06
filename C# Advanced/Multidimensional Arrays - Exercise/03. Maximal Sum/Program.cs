namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int biggest = Int32.MinValue;
            int biggestSquareRow = 0;
            int biggestSquareCol = 0; 
            int currentValue = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    currentValue = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                   matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                   matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentValue > biggest)
                    {
                        biggestSquareRow = row;
                        biggestSquareCol = col;
                        biggest = currentValue;
                    }
                }
            }

            Console.WriteLine($"Sum = {biggest}");
            Console.WriteLine($"{matrix[biggestSquareRow, biggestSquareCol]} {matrix[biggestSquareRow, biggestSquareCol + 1]} {matrix[biggestSquareRow, biggestSquareCol + 2]}");

            Console.WriteLine($"{matrix[biggestSquareRow + 1, biggestSquareCol]} {matrix[biggestSquareRow + 1, biggestSquareCol + 1]} {matrix[biggestSquareRow + 1, biggestSquareCol + 2]}");

            Console.WriteLine($"{matrix[biggestSquareRow + 2, biggestSquareCol]} {matrix[biggestSquareRow + 2, biggestSquareCol + 1]} {matrix[biggestSquareRow + 2, biggestSquareCol + 2]}");
        }
    }
}