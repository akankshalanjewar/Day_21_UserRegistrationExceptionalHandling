using System;
using UserRegistrationExceptionalHandling;

namespace UserRegistrationExceptionalHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration ");

            string FirstName;
            Console.Write("Enter First Name : ");
            FirstName = Console.ReadLine();
            Pattern.checkFirstName(FirstName);
            Console.ReadKey();
        }
    }
}
