using System;

// exercise solved URI 1113
// Read an undetermined number of X and Y integer pairs. 
// Write a message for each X and Y indicating whether these values ​​were entered in ascending or descending order.

namespace WhileStructure3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] vect = Console.ReadLine().Split(' ');

            X = int.Parse(vect[0]);
            Y = int.Parse(vect[1]);

            while (X != Y)
            {
                if (X > Y)
                {
                    Console.WriteLine("Descending");
                }
                else
                {
                    Console.WriteLine("Ascending");
                }

                vect = Console.ReadLine().Split(' ');

                X = int.Parse(vect[0]);
                Y = int.Parse(vect[1]);
            }
        }
    }
}

