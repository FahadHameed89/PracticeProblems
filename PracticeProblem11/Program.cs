﻿using System;

namespace PracticeProblem11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, I will perform a function of your choice on two separate numbers of your choosing! Please enter the first operand");

Console.WriteLine("Please enter the first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator you want to use");
            string c = Console.ReadLine() ;

            Console.WriteLine("Enter the last number");
            int b = int.Parse(Console.ReadLine());

            string formula = "acb";
            formula = formula.Replace("a", a.ToString()).Replace("b", b.ToString()).Replace("c", c.ToString());

            var calc = new System.Data.DataTable();
            Console.WriteLine(calc.Compute(formula, ""));

        }
    }
}
