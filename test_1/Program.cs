// 1. Utworzenie programu, który wypisuje na ekranie powitanie,
// czeka na reakcje użytkownika. Potem wypisuje "Koniec"
// i znów czeka na reakcję użytkownika i następnie kończy działanie.


using System;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.ReadKey(true);
            Console.Write("Finish! \x4d");
            Console.ReadKey(true);

            Console.Write("Podaj wartosc temperatury");
            double temp = Convert.ToDouble(Console.ReadLine());

            //double suma = temp + 3;

            //Console.WriteLine("Suma wynosi {0}", suma);



            //2. Zmienne i stałe

            Console.WriteLine("2. Zmienne i stałe.");
            double x, y, suma;
            Console.Write("Podaj x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj y: ");
            y = Convert.ToDouble(Console.ReadLine());
            suma = x + y;
            Console.WriteLine("{0}+{1}={2}", x, y, suma);
            Console.ReadKey();
        }
    }
}
