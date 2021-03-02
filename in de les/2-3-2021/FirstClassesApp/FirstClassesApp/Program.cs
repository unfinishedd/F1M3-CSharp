using System;

namespace FirstClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator calc = new Calculator();
            float circumference = calc.CircumferenceCircle(10f);
            Console.WriteLine("circ: " + circumference);
        }
    }
    
    class Calculator
    {
        float pi = 3.14f;
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("a+b = " + c);
        }
        public int Multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("a*b = " + c);
            return c;
        }
        public float CircumferenceCircle(float radius)
        {
            return radius * radius * pi;
        }
    }
}
