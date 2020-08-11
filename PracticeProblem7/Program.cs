// Write a program that takes in a number of fence posts and determines how many buckets of paint will be required to paint the fence posts. One bucket = 4 Fence Posts. 
// 1. Enter in # of fence Posts
// 2. Divide # of fence posts by 4, rounding up. Save as integer -> Buckets
// https://docs.microsoft.com/en-us/dotnet/api/system.math.ceiling?view=netcore-3.1 -> the Math.Ceiling method can be used to round up to nearest integer
// 3. Display Buckets integer

using System;

namespace PracticeProblem7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello friend, I will tell you how many buckets of paint you need based on the number of fence posts you need to paint! (1 Bucket can paint 4 fence posts)");
            Console.WriteLine("Please enter how many fence posts you need to paint:");
            int x = Convert.ToInt32(Console.ReadLine());        // Converts the user input into an integer based on what they write in the console field                          
            int z = (int)Math.Ceiling(x/4m);        // May want to use x/8m to remove ambiguous call to Math.Ceiling – Marc Sep 1 '13 at 17:28 - https://stackoverflow.com/questions/18560959/how-do-round-int-with-ceiling
                                                    // Previously used Math.Ceiling(x/4); which was giving an error CS0121: ambiguous call. Looked online for a solution found on stackoverflow above^

            Console.WriteLine($"You will need {z} buckets!");          // Writes out which was greatest of the 3 inputs
            Console.ReadLine();
        }
    }
}
