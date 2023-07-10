using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGradesLimit = int.Parse(Console.ReadLine());
            string exerciseName;
            int poorGrades = 0;
            int grade;
            double sum = 0;
            int problems = 0;
            string lastProblem = "";

            while ((exerciseName = Console.ReadLine()) != "Enough")
            {
                grade = int.Parse(Console.ReadLine());
                problems ++;
                sum += grade;

                if (grade <= 4)
                {
                    poorGrades++;

                    if (poorGrades == poorGradesLimit )
                    {
                        Console.WriteLine($"You need a break, {poorGradesLimit } poor grades.");
                        break;
                    }
                }

                lastProblem = exerciseName;
            }

            if (exerciseName == "Enough")
            {
                Console.WriteLine($"Average score: {(sum / problems ):f2}");
                Console.WriteLine($"Number of problems: {problems }");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
