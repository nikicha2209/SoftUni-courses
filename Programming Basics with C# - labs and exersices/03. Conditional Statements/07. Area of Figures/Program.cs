using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = squareSide  * squareSide ;
                Console.WriteLine("{0:F3}", squareArea );
            }

            else if (figure == "rectangle")
            {
                double rectangleLength = double.Parse(Console.ReadLine());
                double rectangleWidth = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleWidth  * rectangleLength ;
                Console.WriteLine("{0:F3}", rectangleArea );
            }

            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * (radius * radius);
                Console.WriteLine("{0:F3}", circleArea );
            }

            else if (figure == "triangle")
            {
                double triangleLength = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                double triangleArea = triangleLength * triangleHeight   / 2;
                Console.WriteLine("{0:F3}", triangleArea );
            }
        }
    }
}
