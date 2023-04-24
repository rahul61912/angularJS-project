using System;

namespace GuessNumber
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
                Console.Write("Enter the guessed number between 0 to 100: ");

                int i = Convert.ToInt32(Console.ReadLine());

                if (i > winNum)
                {
                    Console.WriteLine("go low, its too high");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("go high, its too low");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("you win");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);
            Console.WriteLine("Thank You");
            Console.WriteLine("Press any key to End");
            Console.ReadKey(true);
  
dhgfjf

        }
    }
}
