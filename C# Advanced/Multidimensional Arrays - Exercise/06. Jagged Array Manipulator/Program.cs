namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[(int)rows][];
            ReadingTheMatrix(rows, matrix);
            AnalyzeTheMatrix(matrix);

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split(" ");
                string command = tokens[0];
                double row = double.Parse(tokens[1]);
                double col = double.Parse(tokens[2]);
                double value = double.Parse(tokens[3]);

                if (command == "Add")
                {
                    if (row < 0 || col < 0 || row > rows || col >= matrix[rows - 1].Length)
                    {
                        continue;
                    }

                    matrix[(int)row][(int)col] += value;
                }

                else if (command == "Subtract")
                {
                    if (row < 0 || col < 0 || row > rows || col >= matrix[rows - 1].Length)
                    {
                        continue;
                    }

                    matrix[(int)row][(int)col] -= value;
                }
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }


        }

        private static double[][] AnalyzeTheMatrix(double[][] matrix)
        {
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    
                    matrix[row] = matrix[row].Select(x => x * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(y => y * 2).ToArray();
                }

                else
                {
                    matrix[row] = matrix[row].Select(x => x / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(y => y / 2).ToArray();
                }
            }

            return matrix;
        }

        private static double[][] ReadingTheMatrix(double rows, double[][] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                double[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                matrix[row] = rowValues;
            }

            return matrix;
        }
    }
}