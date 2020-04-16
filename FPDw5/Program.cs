using System;

namespace FPDw5
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = "ramen";

            Console.WriteLine("We have ramen, spaghetti and salad. Which do you like?");
            Console.WriteLine("* Type \"random\" for random recommendation");
            food = Console.ReadLine();

            if (food == "random")
            {
                Random random = new Random();
                int i = random.Next(0, 3); // 0 <= i < 100
                switch (i)
                {
                    case 0:
                        food = "ramen";
                        break;
                    case 1:
                        food = "spaghetti";
                        break;
                    case 2:
                        food = "salad";
                        break;
                }
                Console.WriteLine("Random recommendation: " + food + ".");
            }

            switch (food)
            {
                case "ramen":
                    Console.WriteLine("It cost you NT 200.");
                    break;
                case "spaghetti":
                    Console.WriteLine("It cost you NT 180.");
                    break;
                case "salad":
                    Console.WriteLine("It cost you NT 60.");
                    break;
                default:
                    Console.WriteLine("Sorry, we do not sell " + food + ".");
                    break;
            }

            Console.WriteLine("Enter to exit");
            Console.ReadLine();

        }
    }
}