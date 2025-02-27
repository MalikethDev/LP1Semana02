using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the user for an int number
            Console.WriteLine("Please enter an integer number: ");
            // Store the input in sbyte
            sbyte n = sbyte.Parse(Console.ReadLine());

            // Decrement the value of n by 1
            sbyte decrement = --n;
            // Increment the value of n by 1
            sbyte increment = ++n; 
            // Print the results
            Console.WriteLine($"The result of the decrement operation is: {decrement}");
            Console.WriteLine($"The result of the increment operation is: {increment}");
        }
    }
}
