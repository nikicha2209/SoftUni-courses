namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {

        /*
         input:
        3, 6
        7, 1, 3, 3, 2, 1
        1, 3, 9, 8, 5, 6
        4, 6, 7, 9, 1, 0
         */
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                sum += rowValues.Sum();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
            ;
        }

    }
}