using System.ComponentModel.DataAnnotations;
using System.Globalization;

string greeting = "Welcome to NumGuesser";

Console.WriteLine(greeting);

Console.WriteLine(@"Choose a difficulty level:
1. Easy
2. Medium
3. Hard
4. Cheater");

int userInput = int.Parse(Console.ReadLine());
Random random = new Random();
int secretNumber = random.Next(1, 100);

int maxAttempts = 0;

if (userInput == 1)
{
    maxAttempts = 8;
} 
else if (userInput == 2)
{
    maxAttempts = 6;
}
else if (userInput == 3)
{
    maxAttempts = 4;
}
else if (userInput == 4)
{
    maxAttempts = int.MaxValue;
}

for (int attempt = 1; attempt <= maxAttempts; attempt++)
{
    Console.WriteLine($"Your guess ({attempt}). You have {maxAttempts - attempt + 1} tries left.");
    int response = int.Parse(Console.ReadLine());

    if (response == secretNumber)
    {
        Console.WriteLine("You guessed the correct number!");
        break;
    }
    else if (response > secretNumber)
    {
        Console.WriteLine("Your response was greater than the secret number. Try again.");
    }
    else if (response < secretNumber)
    {
        Console.WriteLine("Your response was less than the secret number. Try again.");
    }
}
Console.WriteLine("Game over!");



