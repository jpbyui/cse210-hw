using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random random = new Random();
        bool playAgain = true;  

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101);
            int userGuess;
            int guessCount = 0;

            Console.WriteLine("Welcome to Guess My Number");
            do
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (userGuess < magicNumber)
                    Console.WriteLine("Higher");
                else if (userGuess > magicNumber)
                    Console.WriteLine("Lower");
                else
                    Console.WriteLine("You guessed it!");

            } while (userGuess != magicNumber);

            Console.WriteLine("You made "+guessCount+" guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();
            if (playAgainInput != "yes")
                playAgain = false;
            Console.Clear();
        }
    }
}