using System;

namespace ArraysAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 10;
                            //  0   1   2   3   4   5
            int[] getallen = { 10, 20, 30, 40, 50, 60 };
            //2 loops
            //1: For loop
            //2: Foreach


            int opsomming = 0;

            foreach(int hetGetal in getallen)
            {
                //Console.WriteLine(hetGetal);
                opsomming += hetGetal;
            }

            Console.WriteLine(opsomming);
            /*
            for(int i = 0; i < getallen.Length; i++)
            {
                Console.WriteLine(getallen[i]);
            }
            */

        }
    }
}
