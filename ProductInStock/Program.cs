using System;
using System.Globalization;


/// <summary>
/// a program that add, remove, calculate the quantity and the price of product in stock
/// </summary>

namespace ProductInStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Enter product data:");
            Console.Write("Name: "); p.Name = Console.ReadLine();
            Console.Write("Price: "); p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity in stock: ");

            p.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine("Product Data: " + p);
            Console.WriteLine(); Console.Write("Enter the number of products to add to inventory: ");
            int qte = int.Parse(Console.ReadLine()); p.AddProduct(qte);
            Console.WriteLine(); Console.WriteLine("Updated Data: " + p);
            Console.WriteLine(); Console.Write("Enter the number of products to remove from stock: ");
            qte = int.Parse(Console.ReadLine()); p.RemoveProduct(qte);
            Console.WriteLine(); Console.WriteLine("Updated Data: " + p);
        }
    }
}
