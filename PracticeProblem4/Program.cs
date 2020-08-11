// Q. Write a program that will take in a 4 digit integer and calculate the sum of its digits without ever converting the integer to a string.
// To solve, need to collect 4 digit integer in a integer and then divide by 10 and add the remainder to a new variable called totalSum. 
// Repeat the divide by 10 function 3 times in total, adding the remainder each time. 
// Ex. Integer 5438 -> Divide by 10 = 543 Remainder 8 -> Store remainder to totalSum variable (8) 
// 543 -> Divide by 10 = 54 Remainder 3 -> Store remainder to totalSum variable (11)
// 54 -> Divide by 10 = 5 Remainder 4 -> Store remainder to totalSum variable (15)
// 5 -> Divide by 10 = 0 Remainder 5 -> Store remainder to totalSum variable (20)
// This solution should work for any number of integers, but how to make it 4 digits only?

using System;

namespace PracticeProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a 4 digit integer:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            int result1 = userInput / 10; // divide the user's input by 10, then divide the result by 10 until there should be no remainders.
            int result2 = result1 / 10;
            int result3 = result2 / 10;
            int result4 = result3 / 10;
            int result5 = result4 / 10;


            int remainder1 = userInput % 10; // Find the remainder values after dividing 10 off the user input
            int remainder2 = result1 % 10;
            int remainder3 = result2 % 10;
            int remainder4 = result3 % 10;
            int remainder5 = result4 % 10;

            int sumOfDigits = remainder1 + remainder2 + remainder3 + remainder4; // Throw the remainders into a sum and find the sum of digits. 

            Console.WriteLine($"The total sum of the last four digits you entered is {sumOfDigits}"); // If you enter too many digits it only adds the last 4 digits, ignoring anything past that point. 
            Console.ReadLine();
        }
    }
}
