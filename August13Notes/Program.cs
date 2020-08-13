using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[10];

            PopulateArray(myNumbers);

            // foreach is useful for shorthand output but CANNOT edit array items, they will be marked as readonly.
            foreach(int number in myNumbers)
            {
                Console.WriteLine(number);
            }

            /*
            The above loop is exactly the same as this:
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
            */
        }
        // No return type due to the array being passed by reference (memory address) so any edits will affect the original.
        static void PopulateArray(int[] theArray)
        {
            for(int i = 0; i < theArray.Length; i++)
            {
                theArray[i] = GetValidInt($"Please enter integer #{i+1}: ", 1, 100);
            }
        }

        static int GetValidInt(string prompt, int min, int max)
        {
            bool valid = false;
            int myInt = -1;

            do
            {
                Console.Write(prompt);
                try
                {
                    myInt = int.Parse(Console.ReadLine());
                    if (myInt < min || myInt > max)
                    {
                        throw new Exception("Provided integer was outside of the bounds specified.");
                    }
                    valid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Parse failed: {ex.Message}");
                }
            } while (!valid);

            return myInt;
        }
    }
}