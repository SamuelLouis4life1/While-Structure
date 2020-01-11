using System;
using System.Globalization;

/// <summary>
/// a program that calculates square of a number while that number is not negative.
/// </summary>

namespace WhileStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Enter another number: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Negative numbers !");
        }
    }
}
