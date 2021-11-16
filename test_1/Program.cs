//
// test_1
//
// Created by Justyna Kowalkowska on 06/11/2021.
//


using System;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.
            // The creation of a program that prints a greeting to the screen waits
            // for user responses. Then it prints "Finish", waits again for user input,
            // and then exits.


            Console.WriteLine("What is your name?");

            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name +".");

            Console.ReadKey(true);
            Console.Write("Finish!");
            Console.ReadKey(true);

        }
    }
}
