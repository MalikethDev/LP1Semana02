using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Print the max and min values of every type
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // Print special values ​​−∞, +∞ and NaN from float and double
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NaN);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NaN);

            // Result of overflow in uints
            uint max = uint.MaxValue;
            uint overflow = max + 1;
            Console.WriteLine(overflow);
        }
    }
}
