// Write a program that prompts the user for a number (as an int) and outputs the cube of that number (raised to the third power)
// Input > User prompt (int)

using System;

namespace PracticeProblem1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solution found from: https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input
            // Use the 'Convert.ToInt32' method to convert whatever is written in the console line to an integer. 
            // If the user input is not an integer, an error will be thrown out.
            // If the user input is an integer, it will convert the entire readline into an integer, then create a new integer which is equal to the cube root of intTemp, intFinal
            // intFinal variable will then be displayed at the end of the program. 

            Console.WriteLine("Enter an Integer:");
            int intTemp = Convert.ToInt32(Console.ReadLine());
            int intFinal = intTemp * intTemp * intTemp;
            Console.WriteLine(intFinal);
            Console.ReadLine();
        }
    }
}
