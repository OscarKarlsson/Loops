using System;

namespace NKUppg5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N (störst)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write K (minst)");
            int k = int.Parse(Console.ReadLine());
            int z = n - k;

            for (int i = n - 1; i > 0; i--)
            {

                n *= i;
            }
            
            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }
            for (int i = z - 1; i > 0; i--)
            {
                z *= i;
            }
            int answer = (n * k) / z;
            Console.WriteLine($"{n} * {k} / {z}");
            Console.WriteLine(answer);
        }
    }
}
