namespace _05._Play_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int exceptionCount = 0;


            while(exceptionCount < 3)
            {
                string[] command = Console.ReadLine().Split();

                try
                {
                    switch (command[0])
                    {
                        case "Replace":
                            Replace(numbers, int.Parse(command[1]), int.Parse(command[2]));
                            break;

                        case "Print":
                            Print(numbers, int.Parse(command[1]), int.Parse(command[2]));
                            break;

                        case "Show":
                            Show(numbers, int.Parse(command[1]));
                            break;
                    }
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }

                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));


        }

        static void Show(int[] numbers, int index)
        {
            Console.WriteLine(numbers[index]);
        }

        static void Print(int[] numbers, int start, int end)
        {
            List<int> output = new List<int>();

            for (int i = start; i <= end; i++)
            {
                output.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(", ", output));
        }

        static void Replace(int[] numbers, int index, int number)
        {
            numbers[index] = number;
        }
    }
}