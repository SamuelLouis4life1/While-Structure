using CalculadorWithStaticMethod;
using System;
using System.Globalization;


/// <summary>
/// a program that calculate a Circumference and the volume according to its radius value
/// using static method 
/// </summary>

namespace CalculatorWithStaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius value:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculator.Circumference(raio);
            double volume = Calculator.Volume(raio);
            Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI value: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }

    }
}
