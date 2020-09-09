using System;
using System.Linq;

namespace arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write numbers!");
            int[] numbers = new int[5];

            for (int x = 0; x < 5; x++)
            {
                numbers[x] = int.Parse(Console.ReadLine());
            }
            int i = numbers.Max();
            int y = numbers.Min();
            Console.WriteLine($"Högsta Nummret: {i}");
            Console.WriteLine($"Lägsta nummret: {y}");
        }
    }
}
