string greeting = "Welcome to NumGuesser";

Console.WriteLine(greeting);

int secretNumber = 42;

Console.WriteLine("Guess a number: ");
int response = int.Parse(Console.ReadLine());

if (response == secretNumber)
{
    Console.WriteLine("You guessed the correct number! Congratulations!");
}
else
{
    Console.WriteLine("Incorrect response. Try again!");
    int response2 = int.Parse(Console.ReadLine());
    if (response2 == secretNumber)
    {
        Console.WriteLine("You guessed the correct number! Congratulations!");
    }
    else
    {
        Console.WriteLine("Incorrect response. Try again!");
        int response3 = int.Parse(Console.ReadLine());
        if (response3 == secretNumber)
        {
            Console.WriteLine("You guessed the correct number! Congratulations!");
        }
        else
        {
            Console.WriteLine("Incorrect response. Try again!");
            int response4 = int.Parse(Console.ReadLine());
            if (response4 == secretNumber)
            {
                Console.WriteLine("You guessed the correct number! Congratulations!");
            }
            else
            {
                Console.WriteLine("Incorrect response. Try again!");
            }
        }
    }
    ;
}



