using System;

namespace loopppssss
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 101; i++)
            {
                if(i < 50)
                {
                    Console.WriteLine("Laag" + i);
                }
                if(i > 50)
                {
                    Console.WriteLine("Hoog" + i);
                }
                if(i == 50)
                {
                    Console.WriteLine("AY AY" + i);
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            /*for(int i = 0; i <= 101; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/
            }
        }
    }
}
