string greeting = "Welcome to NumGuesser";

Console.WriteLine(greeting);

Random random = new Random();
int secretNumber = random.Next(1, 100);
int maxAttempts = 4;

for (int attempt = 1; attempt <= maxAttempts; attempt++)
{
    Console.WriteLine($"Your guess ({attempt})");
    int response = int.Parse(Console.ReadLine());

    if (response == secretNumber)
    {
        Console.WriteLine("You guessed the correct number!");
        break;
    }
    else
    {
        Console.WriteLine("Incorrect response. Try again.");
    }
}
Console.WriteLine("Game over!");



