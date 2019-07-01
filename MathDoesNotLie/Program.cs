using System;

namespace MathDoesNotLie
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0.0f;
            for (int count = 1; count <= 1000; count++)
            {
                x = x + 0.1f;
                if (count % 100 == 0) Console.WriteLine($"x = {x}");
            }
            Console.ReadLine();
        }
    }
}
