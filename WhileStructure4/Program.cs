using System;
using System.Globalization;


// It is a program for reading an undetermined number of data, each containing the age of a person. The last data
// which will not enter the calculations, contains a negative age value. calculate and print the average age of this group of individuals.
// If a negative value is entered the first time, show the message "Unable to calculate

namespace WhileStruture4
{
    class Program
    {
        static void Main(string[] args)
        {
            double age, sum, average;
            int countAge;

            age = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sum = 0.0;
            countAge = 0;

            while (age >= 0)
            {
                sum = sum + age;
                countAge = countAge + 1;
                age = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            if (countAge == 0)
            {
                Console.WriteLine("Unable to calculate ");
            }
            else
            {
                average = sum / countAge;
                Console.WriteLine("The average age is " + average.ToString("F2"), CultureInfo.InvariantCulture);
            }
            Console.ReadLine();
        }
    }
}
