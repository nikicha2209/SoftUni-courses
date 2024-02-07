namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            int difference = DateModifier.GetDateDifference(firstDate, secondDate);
            Console.WriteLine(difference);
        }
    }
}