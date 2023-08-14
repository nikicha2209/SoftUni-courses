using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool flag = true;
            if (IsPasswordFrom6To10Characters(password))
            {

            }

            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                flag = false;
            }

            if (DoesPasswordConsistOnlyLettersAndDigits(password))
            {

            }

            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
                flag = false;
            }

            if (DoesPasswordHave2Digits(password))
            {

            }

            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                flag = false;
            }

            if (flag)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool DoesPasswordHave2Digits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] > 47 && password[i] < 58)
                {
                    counter++;
                }

                if (counter == 2)
                {
                    return true;
                }
            }

            return false;

            return true;
        }

        static bool DoesPasswordConsistOnlyLettersAndDigits(string password)
         {
             for (int i = 0; i < password.Length; i++)
             {
                 if ((password[i] > 47 && password[i] < 58) || (password[i] > 64 && password[i] < 91) || (password[i] > 96 &&
                     password[i] < 123))
                 {

                 }

                 else
                 {
                     return false;
                 }

             }

             return true;
         }

        static bool IsPasswordFrom6To10Characters(string password)
        {
            if (password.Length >= 6 && password.Length - 1 <= 10)
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
