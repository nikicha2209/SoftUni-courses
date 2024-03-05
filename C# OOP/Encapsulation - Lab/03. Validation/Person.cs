using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get => firstName;
            private set
            {
                if (value.Length > 3)
                {
                    firstName = value;
                }

                else
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                
            }
        }

        public string LastName
        {
            get => lastName;
            private set
            {
                if (value.Length > 3)
                {
                    lastName = value;
                }

                else
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

            }
        }

        public int Age
        {
            get => age;
            private set
            {
                if (value > 0)
                {
                    age = value;
                }

                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }

        public decimal Salary
        {
            get => salary;
            private set
            {
                if (value >= 650 )
                {
                    salary = value;
                }

                else
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                percentage /= 2;
            }

            Salary += Salary * percentage / 100;
        }
    }
}