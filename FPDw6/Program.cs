using System;

namespace FPDw6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count to 5 (do...while loop)");
            int i = 0;
            do
            {
                Console.WriteLine("吃蘋果");
                i++;
            } while (i < 5);

            Console.WriteLine("Count to 5 (while loop)");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("吃蘋果");
                j++;
            }

            Console.WriteLine("Count to 5 (for loop)");
            for (int a = 0; a < 5; a++)
            {
                Console.Write("吃蘋果");
            }

            Console.WriteLine("Nested loop: Square");
            for (int b = 0; b < 9; b++)
            {
                for (int c = 0; c < 9; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Nested loop: Triangle");
            for (int b = 0; b < 9; b++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Nested loop: Flipped Triangle");
            for (int b = 0; b < 9; b++)
            {
                for (int d = 0; d < (9 - b); d++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c <= b; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}