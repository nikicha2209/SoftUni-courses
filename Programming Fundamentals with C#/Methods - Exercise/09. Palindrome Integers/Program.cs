using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = string.Empty;
            while ((numberAsString = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsNumberPalindrome(numberAsString));
            }
        }

        static bool IsNumberPalindrome(string number)
        {
            char[] array =  number.ToCharArray();

            Array.Reverse(array);
            string temp = new string(array);

            if (temp == number)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
