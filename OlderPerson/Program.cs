using System;

/// <summary>
/// a program that calculates the highest age between two people
/// </summary>
/// 

namespace OlderPeson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("Enter the name of the person: ");
            Console.Write("Name: ");
            p1.name = Console.ReadLine();
            Console.Write("Age: ");
            p1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the age of the person: ");
            Console.Write("Name: ");
            p2.name = Console.ReadLine();
            Console.Write("Age: ");
            p2.age = int.Parse(Console.ReadLine());

            if (p1.age > p2.age)
            {
                Console.WriteLine("The highest age is: " + p1.name);
            }
            else
            {
                Console.WriteLine("The highest age is: " + p2.name);
            }
            Console.ReadLine();
        }
    }
}
