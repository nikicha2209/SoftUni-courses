namespace _02._Fishing_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reading
            int n = int.Parse(Console.ReadLine());
            int currentRow = 0;
            int currentCol = 0;
            int sum = 0;
            bool whirlpool = false;
            int whirlpoolRow = 0;
            int whirlpoolCol = 0;

            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                    if (matrix[i, j] == 'S')
                    {
                        currentRow = i;
                        currentCol = j;
                        matrix[i, j] = '-';
                    }
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                switch (command)
                {
                    case "down":
                        currentRow++;
                        if (currentRow == n)
                        {
                            currentRow = 0;
                        }

                        if (matrix[currentRow, currentCol] == 'W')
                        {
                            whirlpool = true;
                            whirlpoolRow = currentRow;
                            whirlpoolCol = currentCol;
                        }

                        if (Char.IsDigit(matrix[currentRow, currentCol]))
                        {
                            sum += int.Parse(matrix[currentRow, currentCol].ToString());
                            matrix[currentRow, currentCol] = '-';
                        }

                        break;


                    case "up":
                        currentRow--;
                        if (currentRow == -1)
                        {
                            currentRow = n - 1;
                        }

                        if (matrix[currentRow, currentCol] == 'W')
                        {
                            whirlpool = true;
                            whirlpoolRow = currentRow;
                            whirlpoolCol = currentCol;
                        }

                        if (Char.IsDigit(matrix[currentRow, currentCol]))
                        {
                            sum += int.Parse(matrix[currentRow, currentCol].ToString());
                            matrix[currentRow, currentCol] = '-';
                        }

                        break;


                    case "left":
                        currentCol--;
                        if (currentCol == -1)
                        {
                            currentCol = n - 1;
                        }


                        if (matrix[currentRow, currentCol] == 'W')
                        {
                            whirlpool = true;
                            whirlpoolRow = currentRow;
                            whirlpoolCol = currentCol;
                        }

                        if (Char.IsDigit(matrix[currentRow, currentCol]))
                        {
                            sum += int.Parse(matrix[currentRow, currentCol].ToString());
                            matrix[currentRow, currentCol] = '-';
                        }

                        break;


                    case "right":
                        currentCol++;
                        if (currentCol == n)
                        {
                            currentCol = 0;
                        }

                        if (matrix[currentRow, currentCol] == 'W')
                        {
                            whirlpool = true;
                            whirlpoolRow = currentRow;
                            whirlpoolCol = currentCol;
                        }

                        if (Char.IsDigit(matrix[currentRow, currentCol]))
                        {
                            sum += int.Parse(matrix[currentRow, currentCol].ToString());
                            matrix[currentRow, currentCol] = '-';
                        }

                        break;
                }

            }

            if (whirlpool)
            {
                Console.WriteLine(
                    $"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{whirlpoolRow},{whirlpoolCol}]");
            }


            else if (sum >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");

                if (sum > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {sum} tons.");
                }

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (row == currentRow && col == currentCol)
                        {
                            Console.Write("S");
                        }

                        else
                        {
                            Console.Write(matrix[row, col]);
                        }

                    }

                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - sum} tons of fish more.");
                if (sum > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {sum} tons.");
                }
                
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (row == currentRow && col == currentCol)
                        {
                            Console.Write("S");
                        }

                        else
                        {
                            Console.Write(matrix[row, col]);
                        }

                    }

                    Console.WriteLine();
                }
            }

        }
    }
}