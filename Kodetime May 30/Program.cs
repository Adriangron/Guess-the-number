using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int min = 1;
        int max = 100;
        int numberToGuess = random.Next(min, max + 1);
        int numberOfAttempts = 0;
        bool guessCorrect = false;

        Console.WriteLine("Pick a Number between 1 to 100");
        Console.WriteLine($"I have chosen a number between {min} and {max}. Try to guess it!");

        while (!guessCorrect)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            int guess;

            if (int.TryParse(input, out guess))
            {
                numberOfAttempts++;
                if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    guessCorrect = true;
                    Console.WriteLine($"Congratulations! You've guessed the right number in {numberOfAttempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}