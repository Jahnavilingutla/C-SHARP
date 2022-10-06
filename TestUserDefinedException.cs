using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP
{
    //Write a program to create a user-defined to validate the age>22.

    public class ValidateAgeException : Exception
    {
        public ValidateAgeException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
    public class TestUserDefinedException
    {
        public static void validate(int age)
        {
            if (age < 22)
            {
                throw new ValidateAgeException("Sorry, Age must be greater than 22");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validate(20);
            }
            catch (ValidateAgeException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}    