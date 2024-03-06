namespace _01._Class_Box_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            
            try
            {
                Box box = new Box(height, width, length);
                Console.WriteLine(box.ToString());
            }

            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}