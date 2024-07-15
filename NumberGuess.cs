using System;

//system holds number user have to guess
namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 20
            Random random = new Random();
            int targetNumber = random.Next(1, 21);

            // Initialize the number of guesses
            int numGuesses = 0;

            // Prompt the user to guess the number
            Console.WriteLine("I'm thinking of a number between 1 and 20 . Can you guess what it is?");

            // Loop until the user guesses the correct number
            while (true)
            {
                // Get the user's guess
                Console.Write("Your guess: ");
                int userGuess = int.Parse(Console.ReadLine());
                // Increment the number of guesses
                numGuesses++;

                // Check if the user's guess is correct
                if (userGuess == targetNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number in {0} tries.", numGuesses);
                    break;
                }
                else if (userGuess < targetNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Too high. Try again.");
                }
                
            }

            // Wait for the user to press Enter before closing the console window
            Console.ReadLine();
        }
    }
}