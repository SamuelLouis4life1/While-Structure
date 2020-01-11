using System;
using System.Globalization;


/// <summary>
/// fazer a program to read the measurements on the sides of two X and Y triangles (suppose valid measurements). 
/// Then show the value of the areas of the two triangles and say which of the two triangles has the largest area. 
/// The formula for calculating the area of ​​a triangle from the measurements of its sides a, b, c, is Heron's area
/// </summary>

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter the measurements of triangle X : ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Enter the measurements of triangle Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area of X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));


            if (areaX > areaY)
            {
                Console.WriteLine("Largest area is X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Largest area is Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }

        }
    }
}

