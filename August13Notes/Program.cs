using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = -1, favourite = -1;

            age = GetValidInt("Please enter your age: ", 1, 100);
     
            favourite = GetValidInt("Please enter your favourite number: ", 0, 1000);

            Console.WriteLine($"Your age is {age}, your favourite number is {favourite}.");


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