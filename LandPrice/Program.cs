using System;
using System.Globalization;


/// <summary>
/// a program that calculates are, Diagonal, Perimeter and Price of a land according to its width and lenght
/// </summary>

namespace LandPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, lenght, area, price, squareMeterPrice, diagonal, perimeter;

            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            lenght = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            squareMeterPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = width * lenght;
            diagonal = Math.Sqrt(Math.Pow(width, 2.0) + Math.Pow(lenght, 2.0));
            perimeter = 2 * (width + lenght);
            price = area * squareMeterPrice;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter = " + perimeter.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Price = " + price.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
