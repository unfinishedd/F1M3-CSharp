using System;

namespace les1cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //float   mijnCommagetal        = 10.5f;
            //int     mijnHeleGetal         = 1;
            //string  mijnWoord             = "Met Quotes";
            //bool    mijnWaarofNietWaar    = true;
            //double  mijnCommaDouble       = 10.0;

            
            int hetAntwoord  = Plus(10, 10);
            int hetAntwoord1 = Min(10, 10);
            float hetAntwoord2 = Divide(2, 4);
            int hetAntwoord3 = Keer(10, 10);

            string woordenAchterElkaar = "Hello";
            string woordenAchterElkaar1 = "World";

            string woordenAchterElkaar3 = Plus1(woordenAchterElkaar, woordenAchterElkaar1);

            Console.WriteLine(woordenAchterElkaar3);

            Console.WriteLine("het antwoord op de eerste vraag is " + hetAntwoord   + ".");
            Console.WriteLine("het antwoord op de tweede vraag is " + hetAntwoord1  + ".");
            Console.WriteLine("het antwoord op de derde vraag is "  + hetAntwoord2  + ".");
            Console.WriteLine("het antwoord op de vierde vraag is " + hetAntwoord3  + ".");





        }
        //toegangelijkheid, return type, functie naam, argumenten en scope
        
        public static string Plus1(string eersteGetal, string tweedeGetal)
        {

            return eersteGetal + " " + tweedeGetal;
        }
        
        
        public static int Plus(int eersteGetal, int tweedeGetal)
        {


            return eersteGetal + tweedeGetal;
        }
        public static int Min(int eersteGetal, int tweedeGetal)
        {


            return eersteGetal - tweedeGetal;
        }
        public static float Divide(float eersteGetal, float tweedeGetal)
        {


            return eersteGetal / tweedeGetal;
        }
        public static int Keer(int eersteGetal, int tweedeGetal)
        {


            return eersteGetal * tweedeGetal;
        }



    }
}
