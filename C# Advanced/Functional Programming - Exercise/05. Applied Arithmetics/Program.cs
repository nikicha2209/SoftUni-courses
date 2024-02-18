namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;
            Func<int[], int[]> add = arr => arr.Select(num => num + 1).ToArray();
            Func<int[], int[]> multiply = arr => arr.Select(num => num * 2).ToArray();
            Func<int[], int[]> subtract = arr => arr.Select(num => num - 1).ToArray();
            Action<int[]> print = arr => Console.WriteLine(string.Join(" ", arr));


            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = add(numbers);
                        break;

                    case "multiply":
                        numbers = multiply(numbers);
                        break;

                    case "subtract":
                        numbers = subtract(numbers);
                        break;

                    case "print":
                        print(numbers);
                        break;
                }
            }
        }
    }
}