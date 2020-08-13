// We are recreating the August 12th assignment with all challenges complete for the purpose of practice!!!

using System;

namespace August13Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Title: Letter Remover
            Purpose: Remove given character from a string

            Author: Fahad Hameed
            Last Modified: August 13, 2020
            */

            string userInput, userChar, output="";     // Declare variables

            Console.WriteLine("This program removes letters from any given string. Please enter a string and a character, and i'll remove the characters you enter from the string and give you a filtered message!");

            Console.WriteLine("Please enter a string!");
            userInput = Console.ReadLine();
    
            Console.WriteLine("Please enter a string to be filtered out!");
            userChar = Console.ReadLine();


            /*

                or each character in the string:
                    If that character is not the bad char
                        Add that char to a new string

            */

   /*          for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] != userChar[0])
                {
                    output += userInput[i];
                }
            }  
             */


            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == userChar[0])
                {
                    userInput = userInput.Remove(i, 1);
                    i--;
                    
                }
            } 



            Console.WriteLine($"Your filtered string is {userInput} !!");


        }
    }
}
