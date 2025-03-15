using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] choices = { "rock", "paper", "scissors" };

            Console.WriteLine("Rock, Paper, Scissors\n");

            while (true)
            {
                Console.WriteLine("Type rock, paper, or scissors to start the game. (or if you want to, type 'exit' in order to quit.)\n");
                string userChoice = Console.ReadLine().Trim().ToLower();

                if (userChoice == "exit")
                {
                    Console.WriteLine("Thanks for playing! Goodbye.\n");
                    break;
                }

                if(!Array.Exists(choices, choice => choice == userChoice))
                {
                    Console.WriteLine("Invalid choice, please try again\n");
                    continue;
                }

                string computerChoice = choices[random.Next(choices.Length)].Trim();
                Console.WriteLine($"Computer chose: {computerChoice}\n");

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("its a tie.\n");
                }
                else if ((userChoice == "rock" && computerChoice == "paper") ||
                         (userChoice == "paper" && computerChoice == "scissors") || 
                         (userChoice == "scissors" && computerChoice == "rock"))
                {
                    Console.WriteLine("You lose 3:\n");
                }
                else
                {
                    Console.WriteLine("You Win :3\n");
                }
            }

        }
    }
}