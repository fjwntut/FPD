using System;

namespace FPDw4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            Console.WriteLine(true & true);         // True
            Console.WriteLine(true & false);        // False
            Console.WriteLine(false & true);        // False
            Console.WriteLine(false & false);       // False

            Console.WriteLine(5 > 3 && a == b);     // ?
            Console.WriteLine(5 > 3 && a != b);     // ?

            Console.WriteLine(false & a++ > 0);     // False
            Console.WriteLine(a);                   // 6(a++被執行)
            Console.WriteLine(false && b++ > 0);    // False
            Console.WriteLine(b);                   // 5(前面是false，b++被跳過)

            Console.WriteLine(!false);              // True
            Console.WriteLine(!true);               // False

            Console.WriteLine(!(3 > a));            // ?
            Console.WriteLine(!(b > 3));            // ?

            Console.WriteLine(true | true);         // True
            Console.WriteLine(true | false);        // True
            Console.WriteLine(false | true);        // True
            Console.WriteLine(false | false);       // False

            Console.WriteLine(5 > 3 || a == b);     // ?
            Console.WriteLine(5 > 3 || a != b);     // ?


            Console.WriteLine(true ^ true);         // False
            Console.WriteLine(true ^ false);        // True
            Console.WriteLine(false ^ true);        // True
            Console.WriteLine(false ^ false);       // False

            Console.WriteLine(a++ < b || a > b);     // ?
            Console.WriteLine(a > b ^ a == b);       // ?
            Console.WriteLine((a > b && b > a) || a > b);    // ?

            if (a + b > 15)
            {
                Console.WriteLine("The answer is greater than 15");
            }
            else if (a + b < 10)
            {
                Console.WriteLine("The answer is smaller than 10");
            }
            else
            {
                Console.WriteLine("The answer is between 15 and 10");
            }

        }
    }
}
