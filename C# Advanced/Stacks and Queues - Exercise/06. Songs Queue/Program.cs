namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Queue<string> songsQueue = new Queue<string>(songs);
            string command;
            while (songsQueue.Count > 0)
            {
                command = Console.ReadLine();

                if (command == "Play")
                {
                    songsQueue.Dequeue();
                }

                else if (command.Split().First() == "Add")
                {
                    string newSong = string.Join(" ", command.Split().Skip(1));
                    if (songsQueue.Contains(newSong))
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }

                    else
                    {
                        songsQueue.Enqueue(newSong);
                    }
                }

                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}