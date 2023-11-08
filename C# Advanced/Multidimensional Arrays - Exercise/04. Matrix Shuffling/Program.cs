namespace _04._Matrix_Shuffling
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

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col].ToString();
                }
            }

            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);



                if (tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string command = tokens[0];
                int row1 = int.Parse(tokens[1]);
                int col1 = int.Parse(tokens[2]);
                int row2 = int.Parse(tokens[3]);
                int col2 = int.Parse(tokens[4]);

                if (command != "swap" || row1 > rows - 1 || row2 > rows - 1 || col1 > cols - 1 ||
                    col2 > cols - 1 || row1 < 0 || row2 < 0 || col1 < 0 || col2 < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string oldValue = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = oldValue;


                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}