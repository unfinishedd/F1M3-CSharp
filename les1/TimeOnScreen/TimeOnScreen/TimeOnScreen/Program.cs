using System;
using System.Threading;

namespace TimeOnScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int timer = 0;
            int randomColor;

            while (true)
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString(), Console.ForegroundColor);
                Thread.Sleep(1000);
                timer++;
                Console.Clear();

                if (timer == 1)
                {
                    timer = 0;
                    randomColor = rand.Next(1, 6);

                    switch (randomColor)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                    }
                }
            }
        }
    }
}