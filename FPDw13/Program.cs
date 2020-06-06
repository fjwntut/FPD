using System;
using HtmlAgilityPack;

namespace FPDw13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();

            Console.Write("Your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Your name is {0}. Your age is {1}", name, age);

            string s = "Hello world";
            string[] ss = s.Split(" ");
            Console.WriteLine(ss[1]);

            Console.Write("str1:");
            string str1 = Console.ReadLine();

            Console.Write("str2:");
            string str2 = Console.ReadLine();

            Console.WriteLine("Does str1 start with str2? {0}", str1.StartsWith(str2));

            Console.WriteLine("Does str1 end with str2? {0}", str1.EndsWith(str2));

            Console.WriteLine("Is str1 equal to str2? {0}", str1.Equals(str2));

            Console.WriteLine("Does str1 contain str2? {0}", str1.Contains(str2));

            string inputString = Console.ReadLine();
            int inputInt = Convert.ToInt32(inputString);

            for (int i = 0; i < inputInt; i++)
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}
