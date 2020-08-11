// Write a program that will take in two sides of a right triangle and determine the length of the hypotenuse to 2 decimal places, using the pythagorean theorem.


using System;

namespace PracticeProblem8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, I am going to calculate the length of the hypotenuse of a right triange if you can give me the lengths of the other two sides.");
            Console.WriteLine("Please enter the length of the first side:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You entered {side1}! Please enter the length of the second side:");                               // Asks for 2nd input
            double side2 = Convert.ToDouble(Console.ReadLine());
            double A = side1 * side1;           // get the value of A^2
            double B = side2 * side2;           // get the value of B^2
            double C = A + B;                   // get the value of C^2
            double D = Math.Sqrt(C);            // get the value of C 
            decimal E = Convert.ToDecimal(D);               // Convert to a decimal
            decimal F = Math.Round(E, 2);                   // And round to 2 spaces
            Console.WriteLine($"The hypotenuse is {F}!");       // Did I really need to use 6 variables? Probably not...
            Console.ReadLine();
        }
    }
}
