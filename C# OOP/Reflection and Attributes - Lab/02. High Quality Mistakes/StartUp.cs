﻿namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new();
            string result = spy.AnalyzeAccessModifiers("Hacker");
            Console.WriteLine(result);
        }
    }
}