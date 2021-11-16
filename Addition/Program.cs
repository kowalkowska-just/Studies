using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2.
            // Write a program that calculates the sum of two real numbers.

            Console.WriteLine("2. Addition.");

            double x, y, sum;

            Console.WriteLine("Enter the value of X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            sum = x + y;

            Console.WriteLine("\nThe sum of {0} + {1} = {2}.", x, y, x+y);
            Console.ReadKey();
        }
    }
}
