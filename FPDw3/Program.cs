using System;

namespace FPDw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + 2); // output: 2

            int a;  // 宣告整數 a
            a = 1 + 2;    //將 1+2 的結果存入 a
            Console.WriteLine(a);   // 輸出 a， output：3

            Console.WriteLine(a + 1); // 輸出 a+1 的結果，output：4

            int b = 2;  // 將 a 的值存入 b
            Console.WriteLine(a + b);   // output：5

            a = a + b;  // 把 a+b 的值存入 a
            Console.WriteLine(a + b);   // 輸出 a+b 的值


            // i++ vs ++i

            int i = 3;
            Console.WriteLine(i);      // Output：3
            Console.WriteLine(i++);    // Output：3
            Console.WriteLine(i);      // Output：4

            i = 3;
            Console.WriteLine(i);     // Output：3
            Console.WriteLine(++i);   // Output：4
            Console.WriteLine(i);     // Output：4


            // 優先順序

            a = 2 + 2 * 2;
            Console.WriteLine(a);   // Output：6

            a = (2 + 2) * 2;
            Console.WriteLine(a);   // Output：8


            // 隱含轉換 - 將 int 轉換為 float
            int num = 214;
            float bignum = num;
            Console.WriteLine(bignum);


            // 明確轉換 - 將 float 轉換為 int
            float x = 1234.5f;
            int y;
            y = (int)x;
            Console.WriteLine(y);   // output：1234

            // 四捨五入
            y = (int)(x + 0.5f);
            Console.WriteLine(y);   // output：1235
        }
    }
}
