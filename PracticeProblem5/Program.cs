using System;

namespace PracticeProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text and I will capitalize your text on your behalf:");
            string userInput = Console.ReadLine(); // This will capture whatever the user writes into a string variable known as userInput
            string angryUser = userInput.ToUpper(); // This create a string variable named angryUSER, which is equal to the previous userInput sent through a ToUpper() command. 
            Console.WriteLine(angryUser); // Write the capitalized text to the console. 
            Console.ReadLine(); // And wait so the terminal window doesn't close immediately. 
        }
    }
}
