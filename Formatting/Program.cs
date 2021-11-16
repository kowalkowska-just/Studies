using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3. Formatting

            //Add a currency symbol.
            Console.WriteLine("Currency symbol:");
            Console.WriteLine("\tPrice: {0,10:c} from the number: {0}.", 14);
            Console.WriteLine("\tPrice: {0,-30:C4} from the number: {0}.", 14);



            Console.WriteLine();
            Console.WriteLine("Integers:");
            Console.WriteLine("\t{0:D20} from the number: {0}.", 14);

            Console.WriteLine("Real numbers:");
            Console.WriteLine("\tScientific note {0:e3} from the number: {0}.", 2.345);
            Console.WriteLine("\tScientific note {0:E1} from the number: {0}.", 2.345);
            Console.WriteLine("\tOrdinary notation {0:f12} from the number: {0}.", 0.000000345);
            Console.WriteLine("\tCompact notation {0:g} from the number: {0}.", 0.000000345);
            Console.WriteLine("\tCompact notation {0:g} from the number: {0}.", 23.45e-1);

            Console.WriteLine();
            Console.WriteLine("No grouping of digits: {0} from the number: {0}.", 3123456.56);
            Console.WriteLine("With grouping of digits: {0:N} from the number: {0}.", 3123456.56);

            Console.WriteLine();
            Console.WriteLine("Hexadecimal number: {0:x} from the number: {0}.", 23456);
            Console.WriteLine("Hexadecimal number: {0:X} from the number: {0}.", 23456);

            Console.WriteLine();
            Console.WriteLine("Percentages: {0:P} from the number: {0}.", 50);

            Console.WriteLine();
            Console.WriteLine("Approximate value: {0:f10} from the number: {0}.", 123456789.12345678);
            Console.WriteLine("Exact value: {0:r} from the number: {0}.", 123456789.12345678);

            Console.ReadKey();
        }
    }
}
