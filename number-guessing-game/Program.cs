// random object to display random numbers.
Random random = new Random();
bool playAgain = true;  //if user would like to play again, bool set to true
int min = 1;            //minimun value the user can select
int max = 100;          //maximum value the user can select
int guess;              //the user's guess
int number;             //number that is randomly generated
int guesses;            //number of guess the user has guessed
int guessLimit = 5;     //number of times a player is allowed to play
string response;

while (playAgain == true)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min, max + 1);

    while (guess != number && guesses < guessLimit)
    {
        Console.WriteLine($"Guess a number between {min} to {max} :");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Guess: {guess}");

        if (guess > number)
        {
            Console.WriteLine($"{guess} is too high!");
        }
        else if (guess < number)
        {
            Console.WriteLine($"{guess} is too low!");
        }
        else if (guess == number)
        {
            Console.WriteLine($"\nNumber: {number}");
            Console.WriteLine("YOU WIN!");
            Console.WriteLine($"Guesses: {guesses}");
        }
        guesses++;
    }
    Console.WriteLine("\nGAME OVER!");
    Console.WriteLine($"The right number is {number}.");


    Console.WriteLine("\nWould you like to play again? (Y/N");
    response = Console.ReadLine().ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}
Console.WriteLine($"Thanks for playing my number guessing game!...");