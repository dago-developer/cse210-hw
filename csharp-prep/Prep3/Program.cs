using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int number = 0;

            int attempts = 0;

            while (number != magicNumber)
            {
                Console.Write("Please tell me your magic number");
                number = int.Parse(Console.ReadLine());
                attempts++;

                if (number > magicNumber)
                {
                    Console.WriteLine("Try a lower number");
                }
                else if (number < magicNumber)
                {
                    Console.WriteLine("Try a higher number");
                }
                else
                {
                    Console.WriteLine("You guess it! You win the game");
                }

            }
            Console.WriteLine($"It took you {attempts} guesses.");

            
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}