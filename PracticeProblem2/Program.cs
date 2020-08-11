// Write a program that will take in a total dollar value (as a double) and a number of diners (as an int) and calculate the amount of the bill that each diner should pay (equal split).
// Use strings to ask the user to enter variables for total bill and number of diners. 
// Convert to integer for number of diners, convert to double for total bill
// perform division calculation and save the value as a double
// read out text display 


using System;

namespace PracticeProblem2
{
    class Program
    {
        static void Main(string[] args)
        {

// https://docs.microsoft.com/en-us/dotnet/api/system.convert.todouble?view=netcore-3.1
// Needed to determine how to call a double, used microsoft documentation to check methods. Used 'Convert.ToDouble() on the console readline
// Unfortunately if you enter in intentionally incorrect values, like entering in a name when it asks for a number, an error occurs and exits the program. 
// Not a critical error, because there is a user work around, simply enter in the values the program is looking for. 
            Console.WriteLine("Hello there, how much was the bill?");
            double myBill = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("And how many diners were at your table?");
            int intTemp = Convert.ToInt32(Console.ReadLine());

            double splitBill = myBill/intTemp;
// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/hello-world?tutorial-step=2
// From the microsoft hello world tutorial, they teach you how to string variables into a WriteLine() statement.
            Console.WriteLine($"Your total bill of {myBill} split between {intTemp} diners is equal to {splitBill}");
            Console.ReadLine();
        }
    }
}
