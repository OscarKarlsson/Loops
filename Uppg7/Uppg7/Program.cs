using System;

namespace Uppg7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int fibb1 = 0;
            int fibb2 = 1;
            int fibb3;
            int answer = 0;
            Console.WriteLine("Write N");
            n = int.Parse(Console.ReadLine());
            Console.Write("0 1 ");
            for (int i = 2; i < n; i++)
            {
                fibb3 = fibb1 + fibb2;
                Console.Write($"{fibb3} ");
                fibb1 = fibb2;
                fibb2 = fibb3;
                answer += fibb3;
            }
            Console.WriteLine();
            Console.WriteLine($"The sum is : {answer + 1}");
        }
    }
}
