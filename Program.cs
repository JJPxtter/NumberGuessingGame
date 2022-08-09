using System;

namespace NumberGuessingGame
{
class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("You need to enter a number between 0 and 100");
                    s = Console.ReadLine();
                }

                int i = int.Parse(s);

                if (i > 100 || i < 1)
                {
                    Console.WriteLine("You need to enter a number between 0 and 100");
                    s = Console.ReadLine();
                }

                if (i > winNum)
                {
                    Console.WriteLine("Too High! Guess Lower..."); 
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too Low! Guess Higher...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thank You For Playing The Game!");
            Console.WriteLine("Press any key to finish.");
            Console.ReadKey(true);

        }
    }
}
