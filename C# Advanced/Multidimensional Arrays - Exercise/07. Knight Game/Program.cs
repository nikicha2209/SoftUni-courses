using System.Numerics;

namespace _07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string rowValues = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int knightsRemoved = 0;

            while (true)
            {
                int mostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int currentAttackKnights = AttackedKnights(row, col, n, matrix);
                            if (currentAttackKnights > mostAttacking)
                            {
                                mostAttacking = currentAttackKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }

                        }
                    }
                }

                if (mostAttacking == 0)
                {
                    break;
                }

                else
                {
                    knightsRemoved++;
                    matrix[rowMostAttacking, colMostAttacking] = '0';
                }
            }

            Console.WriteLine(knightsRemoved);
        }

        private static int AttackedKnights(int row, int col, int n, char[,] matrix)
        {
            int attackedKnights = 0;


            if (IsValid(row - 2, col -1, n))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsValid(row - 2, col + 1 , n))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsValid(row - 1, col + 2, n))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsValid(row - 1, col - 2, n))
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsValid(row + 1, col - 2, n))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsValid(row + 1, col + 2, n))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsValid(row + 2, col - 1, n))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsValid(row + 2, col + 1, n))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
        }

        private static bool IsValid(int row, int col, int n)
        {
            return (row >= 0 && col >= 0 && row < n && col < n);
        }
    }
}