using System;
using System.Security.Cryptography.X509Certificates;

namespace PLayingCardsUppg11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char[] suits = { '\x2660', '\x2665', '\x2663', '\x2666' };
            //char 1 = '\x2660';
            //char 2 = '\x2665';
            //char 3 = '\x2663';
            //char 4 = '\x2666';
            for (int i = 1; i <= 4; i++)
            {
                for (int x = 1; x <= 14; x++)
                {
                    switch (x)
                    {
                        case 11:
                            Console.Write($" Jack of {suits[i - 1]} ");
                            break;
                        case 12:
                            Console.Write($" Queen of {suits[i - 1]} ");
                            break;
                        case 13:
                            Console.Write($" King of {suits[i - 1]} ");
                            break;
                        case 14:
                            Console.Write($" Ace of {suits[i - 1]} ");
                            break;
                        default:
                            Console.Write($" {x} {suits[i-1]} ");
                            break;
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
