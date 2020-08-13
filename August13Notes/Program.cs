using System;

namespace LetterRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Title: Letter Remover
            Purpose: Remove given characters from a string.
            Author: James Grieve
            Last Modified: August 13, 2020
            */

            string menuChoice = "";
            
            Console.WriteLine("Welcome to the letter remover application! You will be prompted to enter both a string and a character, and every instance of that character will be removed from the string.\n");

            do
            {

                Console.Write("Type \"Done\" to exit, or press enter to modify a string.");
                menuChoice = Console.ReadLine();
                if (menuChoice.ToLower() != "done")
                {
                    string userInput, userChar, output = "", replaceWith;

                    Console.Write("Please enter a string from which characters will be removed: ");
                    userInput = Console.ReadLine().Trim();

                    Console.Write("Please enter character(s) to remove from the string: ");
                    userChar = Console.ReadLine();

                    Console.Write("Please enter a character to replace these characters with:");
                    replaceWith = Console.ReadLine();
                
                    for (int i = 0; i < userInput.Length; i++)
                    {
                        if (!userChar.ToUpper().Contains(userInput.ToUpper()[i]))
                        {
                            output += userInput[i];
                        }
                        else
                        {
                            output += replaceWith;
                        }
                    }
                
                
                    /*
                    for (int i = 0; i < userInput.Length; i++)
                    {
                        if (userInput[i] == userChar[0])
                        {
                            // If we try to assign output here rather than userInput, it creates an infinite loop because
                            // we will continuously set output and then decrement, but without changing the string we are
                            // iterating through, it will check the same character forever.
                            userInput = userInput.Remove(i, 1);
                            i--;
                        }
                    }
                    output = userInput;
                    */

                    Console.WriteLine($"Your modified string is on the next line:\n{output}");
                }
            
            } while (menuChoice.ToLower() != "done");
        }
    }
}