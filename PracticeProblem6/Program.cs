using System;

namespace PracticeProblem6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will tell you the max and min of 3 separate integers. Please enter the FIRST INTEGER:");   // Asks for input
            int userInput1 = Convert.ToInt32(Console.ReadLine());                                                           // Converts first input to an integer
            Console.WriteLine($"You entered {userInput1}! Please enter the SECOND INTEGER:");                               // Asks for 2nd input
            int userInput2 = Convert.ToInt32(Console.ReadLine());                                                           // Converts 2nd input to an integer
            Console.WriteLine($"You entered {userInput2}! Please enter the THIRD AND FINAL INTEGER:");                      // Asks for 3rd input
            int userInput3 = Convert.ToInt32(Console.ReadLine());                                                           // Converts 3rd input to an integer

            int input12 = Math.Max(userInput1,userInput2);          // Checks which is greater, int1 or int2 -> save as int12
            int input23 = Math.Max(userInput2,userInput3);          // Which is greater, int2 or int3 -> save as int23
            int input123 = Math.Max(input12,input23);               // Which is greater, int12 or int23

            int minInput12 = Math.Min(userInput1,userInput2);       // Checks which is less, int1 or int2
            int minInput23 = Math.Min(userInput2,userInput3);       // Checks which is less, int2 or int3
            int minInput123 = Math.Min(minInput12,minInput23);      // Checks which is less, int12 or int23

            Console.WriteLine($"The largest integer you entered was {input123}!");          // Writes out which was greatest of the 3 inputs

            Console.WriteLine($"The smallest integer you entered was {minInput123}!");      // Writes out which was smallest of the 3 inputs
            Console.ReadLine();     // Wait for input

        }
    }
}
