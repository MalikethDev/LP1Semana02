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

            // Result of the n decrement operation
            sbyte result = --n;
            // Print the result
            Console.WriteLine($"The result of the decrement operation is: {result}");
        }
    }
}
