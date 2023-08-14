﻿using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stepsWhenIsOut = Console.ReadLine();
            int summedSteps = 0;
            int steps = 0;
            int counter = 0;
            bool success = false;

            while (stepsWhenIsOut != "Going home")
            {
                steps = int.Parse(stepsWhenIsOut);
                summedSteps += steps;

                if (summedSteps >= 10000)
                {
                    success = true;
                    break;
                }

                stepsWhenIsOut = Console.ReadLine();
            }

            if (stepsWhenIsOut == "Going home")
            {
                stepsWhenIsOut = Console.ReadLine();
                summedSteps += int.Parse(stepsWhenIsOut);
            }

            if (success == true || summedSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(10000 - summedSteps)} steps over the goal!");
            }

            else
            {
                Console.WriteLine($"{Math.Abs(10000 - summedSteps)} more steps to reach goal.");
            }
        }
    }
}
