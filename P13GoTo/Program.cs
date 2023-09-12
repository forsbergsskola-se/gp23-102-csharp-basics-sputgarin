// Create a new random.
Random random = new Random();

// Pick a random number between 0-100
int goalNumber = random.Next(100);

// Porompt the user for input.
Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");

// Label for the goto. 
GuessAgain:

// Parse the user input and assign it to a integer named numberGuessed.
int numberGuessed = int.Parse(Console.ReadLine());

// Check if the number guessed is too small.
if (numberGuessed < goalNumber)
{
    Console.WriteLine("Nope! My number is Greater!");
    
    // Go back to the label Guess Again
    goto GuessAgain;
}

// Check if the number guessed is too big.
else if (numberGuessed > goalNumber)
{
    Console.WriteLine("Nope! My number is Smaller!");
    
    // Go back to the label Guess Again
    goto GuessAgain;
}

// If the user gets the correct number congratulate the player and return exit code 0. :)
else
{
    Console.WriteLine("That's the number! Well played!");
}
