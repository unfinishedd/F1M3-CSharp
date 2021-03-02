using System;
using System.Threading;

namespace Les1CS_BO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");

            string tekst = "Mike hock joined the server!";

            //voor elke letter (c) in tekst gaat hij dit uitvoeren
            foreach (char c in tekst)
            {
                //displayed iets
                Console.Write(c);
                //stopt de code voor 50 miliseconde 
                Thread.Sleep(1000);
            }
        }
    }


}

