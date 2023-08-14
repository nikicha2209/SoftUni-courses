using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string namePresentation;
            double grade;
            double totalGrade = 0.0;
            double average = 0.0;
            double sumOfAverages = 0.0;
            int presentationCount = 0;

            while ((namePresentation = Console.ReadLine()) != "Finish")
            {

                for (int i = 1; i <= juryCount; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    totalGrade += grade;
                }

                presentationCount++;
                average = totalGrade / juryCount;
                sumOfAverages += average;
                totalGrade = 0;
                Console.WriteLine($"{namePresentation} - {average:f2}.");

            }
            Console.WriteLine($"Student's final assessment is {(sumOfAverages / presentationCount):f2}.");
        }
    }
}
