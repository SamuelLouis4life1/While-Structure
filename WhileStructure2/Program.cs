using System;

namespace WhileStructure2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum;

            x = int.Parse(Console.ReadLine());
            sum = 0;

            while (x != 0)
            {
                sum = sum + x;
                x = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The sum of all numbers is : " + sum);
            Console.ReadLine();
        }
    }
}

