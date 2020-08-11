

using System;

namespace PracticeProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, what is your age?");
             int myAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("And what is the CURRENT YEAR??");
             int currentYear = Convert.ToInt32(Console.ReadLine());

             int birthYear = currentYear-myAge;

             Console.WriteLine($"Based on the fact that it's {currentYear}, your birth year must be {birthYear} assuming your birthday has already passed!");
             Console.ReadLine();
        }
    }
}
