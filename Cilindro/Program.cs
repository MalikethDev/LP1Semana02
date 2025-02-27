using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ask the user for the height "a" of the cylinder
            Console.WriteLine("Please enter the height of the cylinder: ");
            // Store the input in double
            double a = double.Parse(Console.ReadLine());
            // Ask the user for the radius "r" of the cylinder
            Console.WriteLine("Please enter the radius of the cylinder: ");
            // Store the input in double
            double r = double.Parse(Console.ReadLine());
            // Calculate the volume "V" of the cylinder
            double V = Math.PI * Math.Pow(r, 2) * a;
            // Calculate the surface area Sa of the cylinder
            double Sa = 2 * Math.PI * r * (r + a);
            // Print the results
            Console.WriteLine($"The volume of the cylinder is: {V}");
            Console.WriteLine($"The surface area of the cylinder is: {Sa}");
        }
    }
}
