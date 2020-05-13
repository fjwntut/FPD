using System;

namespace FPDw11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];    // 宣告陣列

            Console.WriteLine(numbers.Length);  // 顯示陣列長度

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * i;                 // 存入數值

                Console.WriteLine(numbers[i]);      // 顯示索引為i的元素

            }

            string[] fruit = { "apple", "orange", "banana" };

            string[,] seat = new string[4, 5];  // 有4*5個位子

            seat[0, 0] = "小航";    // 小航坐在第一排第一位

            Console.WriteLine(seat[0, 0] + "擦白板");   // 坐在第一排第一位的同學去擦白板


            string[,,,] book = new string[5, 3, 4, 3];  // 有5排書架，一排5個，一個暑假有5排書，一排3本書

            book[0, 1, 0, 0] = "blue";    // 藍色的書所在的位置

            string[][] seat2 = new string[3][];
            seat2[0] = new string[4];
            seat2[1] = new string[5];
            seat2[2] = new string[3];

            seat[0][0] = "小航";    // 小航坐在第一排第一位

        }
    }
}
