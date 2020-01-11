using System;

/// <summary>
/// Time Conversion
/// </summary>

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, hours, minutes, seconds, mod;

            N = int.Parse(Console.ReadLine());

            hours = N / 3600;
            mod = N % 3600;

            minutes = mod / 60;
            seconds = mod % 60;

            Console.WriteLine(hours + ":" + minutes + ":" + seconds);

            Console.ReadLine();
        }
    }
}

