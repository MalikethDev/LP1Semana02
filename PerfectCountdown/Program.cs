using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the user for an initial number
            Console.WriteLine("Start number: ");
            // Store the input in the variable start
            int start = int.Parse(Console.ReadLine());

            // Ask the user for a step number
            Console.WriteLine("Step number: ");
            // Store the input in the variable step
            int step = int.Parse(Console.ReadLine()); 

            // If one of the inputs is out of range inform the user
            if (start < 0 || step < 0)
            {
                Console.WriteLine("Out-of-range start or step. try again.");
                return;
            }

            // If step > start inform the user
            if (step > start)
            {
                Console.WriteLine("Start must be higher than step.");
                return;
            }

            // If start is not divisible by step inform the user
            if (start % step != 0)
            {
                Console.WriteLine("Start not divisible by step. Try again.");
                return;
            }

            // Else print the countdown, from start to 0, with step by step and end
            for (int i = start; i >= 0; i -= step) // i start at start, while i is higher or equal to 0, decrement i by step
            {
                Console.WriteLine(i);
            }
        }
    }
}
