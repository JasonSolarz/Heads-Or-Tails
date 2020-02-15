using System;
using System.Threading;
using System.Threading.Tasks;

namespace Heads_or_Tails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Heads or Tails
            Random rand = new Random();
            string userInput;
            int coin = rand.Next(1, 2);

            //Ask user if they would like to flip a coin.
            Console.Write("Flip A Coin! (Y, N): ");
            userInput = Console.ReadLine();

            while (userInput.ToUpper() == "Y")
            {
                Console.WriteLine("\n\nYou Flip A Coin In The Air...\n\n");
                Thread.Sleep(2000);
                if(rand.Next(1, 3) == 1)
                {
                    Console.WriteLine("Heads!");
                }
                else
                {
                    Console.WriteLine("Tails!");
                }

                Console.Write("\nFlip Another coin? (Y, N): ");
                userInput = Console.ReadLine();
            }
        }
    }
}
