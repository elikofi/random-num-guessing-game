// random object to display random numbers.
Random random = new Random();
bool playAgain = true;  //if user would like to play again, bool set to true
int min = 1;            //minimun value the user can select
int max = 100;          //maximum value the user can select
int guess;              //the user's guess
int number;             //number that is randomly generated
int guesses;            //number of guess the user has guessed
string response;

while (playAgain == true)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min, max + 1);

    while (guess != number)
    {
        Console.WriteLine($"Guess a number between {min} {max} :");
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
        guesses++;
    }
    Console.WriteLine($"Number: {number}");
    Console.WriteLine("YOU WIN!");
    Console.WriteLine($"Guesses: {guesses}");

    Console.WriteLine("Would you like to play again? (Y/N");
    response = Console.ReadLine();
    response = response.ToUpper();

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