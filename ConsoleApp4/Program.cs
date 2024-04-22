// Choose a word in advance
string secretWord = "programming";

// Initialize variables
int attempts = 5;
bool found = false;

Console.WriteLine("Welcome to the Word Guessing Game!");
Console.WriteLine("You have 5 attempts to guess the word.");

while (attempts > 0)
{
    Console.Write("Enter your guess: ");
    string userGuess = Console.ReadLine();

    if (userGuess.ToLower() == secretWord)
    {
        found = true;
        break;
    }
    else
    {
        attempts--;
        Console.WriteLine("Incorrect guess. You have " + attempts + " attempts left.");
    }
}

if (found)
{
    Console.WriteLine("Congratulations! You guessed the correct word: " + secretWord);
}
else
{
    Console.WriteLine("You are defeated. The correct word was: " + secretWord);
}