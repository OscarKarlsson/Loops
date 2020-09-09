using System;

namespace Uppg6
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer;
            Console.WriteLine("Write N (störst)");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Write X (minst)");
            double x = double.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            { 
                n = ((n *= i) / Math.Pow(x, n));
            }
            answer = n + 1;
            Console.WriteLine(answer);
        }
    }
}
