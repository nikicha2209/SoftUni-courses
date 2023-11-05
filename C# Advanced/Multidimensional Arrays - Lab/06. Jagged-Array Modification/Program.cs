namespace _06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] rowsValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[rowsValues.Length];
                for (int col = 0; col < rowsValues.Length; col++)
                {
                    jaggedArray[row][col] = rowsValues[col];
                }
            }

            string line = string.Empty;
            while ((line = Console.ReadLine()).ToLower() != "end")
            {
                string[] tokens = line.Split();
                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || col < 0 || row >= jaggedArray.Length || jaggedArray[row].Length <= col)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command == "Add")
                {
                    jaggedArray[row][col] += value;
                }

                else if (command == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }
            }

            foreach (int[] item in jaggedArray)
            {
                Console.Write(string.Join(" ", item));
                Console.WriteLine();

            }
        }
    }
}