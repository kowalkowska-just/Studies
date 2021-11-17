using System;

namespace EnumeratedType
{
    class Program
    {
        // 4.
        // Enumerated Type
        // Definition of the enumeration.

        enum Colors: byte { White, Yellow, Green, Orange, Red, Blue, Black, Brown};
    
        static void Main(string[] args)
        {
            
        Console.WriteLine("My favorite color is: {0}", Colors.Red);
        }
    }
}
