﻿using System;

namespace _1nkUppg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N (störst)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write K (minst)");
            int k = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                
                n *= i;
            }
            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }
            n /= k;
            Console.WriteLine(n);
        }
    }
}
