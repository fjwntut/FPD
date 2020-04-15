using System;

namespace FPDw2
{
    class Program
    {
        public static string accountName;
        public static int accountBalance;
        public static float interestRate;
        static void Main()
        {
            accountName = "Mary Brown";
            Console.WriteLine(accountName);

            accountBalance = 100;
            Console.WriteLine(accountBalance);

            interestRate = 0.05f;
            Console.WriteLine(interestRate);
        }
    }
}
