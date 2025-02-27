using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the user for an non negative int number
            Console.WriteLine("Please enter a non negative integer number: ");
            // Store the input in byte
            byte n = byte.Parse(Console.ReadLine());

            // Print the division of n by 2
            Console.WriteLine($"The result of the division operation is: {n / 2}");
            // Shift left by 3 bits and print the result
            Console.WriteLine($"The result of the shift left operation is: {n << 3}");
            // XOR with 6 and print the result
            Console.WriteLine($"The result of the XOR operation is: {n ^ 6}");
            // Verify if the number is bigger than 10 and print the result
            bool isBiggerThan10 = n > 10;
            Console.WriteLine($"Is the result bigger than 10?: {isBiggerThan10}");
        }
    }
}
