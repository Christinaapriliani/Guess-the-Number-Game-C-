using System;

class GuessTheNumberGame {
    static void Main(string[] args) {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int attempts = 0;

        Console.WriteLine("Guess the Number Game");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        while (true) {
            Console.Write("Your guess: ");
            int guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < targetNumber) {
                Console.WriteLine("Too low. Try again.");
            } else if (guess > targetNumber) {
                Console.WriteLine("Too high. Try again.");
            } else {
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                break;
            }
        }
    }
}
