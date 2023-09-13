// Declare and Inialize the variables.
int matchesLeft = 24;
int predictedDraw = 0;
bool playerLost = false;
int aiDraw = 0;
string matchesDrawn = "||||||||||||||||||||||||";

// Create a new random variable.
Random random = new Random();

// Greet the player.
Console.WriteLine("Welcome to Nim!");
Console.WriteLine($"{matchesDrawn} ({matchesLeft})");

DrawAgain:
Console.WriteLine("How many matches do you want to draw?");

// Take user input.
int userDraw = Convert.ToInt32(Console.ReadLine());

// If user input is to big or small send the user to DrawAgain.
if (userDraw > 3 || userDraw < 1)
{
    Console.WriteLine("You can only draw 1-3 matches.");
    goto DrawAgain;
}

// Do a predicted draw.
predictedDraw = matchesLeft - userDraw;

// The user should not be able to pick more straws that exist in the game.
// So limit the draws the user can make.
if (predictedDraw < 1)
{
    Console.WriteLine("There must always be one straw left.");
    goto DrawAgain;
}

// If all checks out let the player draws from matches left.
// Then the matchesDrawn will also be subtracted by the amount the player draw.
{
    matchesLeft -= userDraw;
    matchesDrawn = matchesDrawn.Substring(0, matchesDrawn.Length - userDraw);
    Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
    
    // If there is only one match left.
    // Set the bool playerLost and send the player to the CheckVictoryCondition label.
    if (matchesLeft == 1)
    {
        playerLost = true;
        goto CheckVictoryCondition;
    }
}

AiDrawAgain:

// Check if the AI should randomise by three.
// There is no reason for the ai to randomise more than two numbers if there is three left.
// And if it's lower than two it just sets the variable to 1.
if (matchesLeft < 3)
{
     aiDraw = random.Next(1, 3);
}

else if (matchesLeft == 3)
{
     aiDraw = random.Next(1, 2);
}

else
{
    aiDraw = 1;
}

// Do a predicted draw.
predictedDraw = matchesLeft - aiDraw;

// The ai should not be able to pick more straws that exist in the game.
// So limit the draws the user can make.
if (predictedDraw < 1)
{
    goto AiDrawAgain;
}
else
{
    // If all checks out let the ai draws from matches left.
    // Then the matchesDrawn will also be subtracted by the amount the ai draw.
    matchesDrawn = matchesDrawn.Substring(0, matchesDrawn.Length - aiDraw);
    matchesLeft -= aiDraw;
    Console.WriteLine($"The AI draws {aiDraw} matches.");
    Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
    
    // If the ai have the last straw.
    // Go to the CheckVictoryCondition .
    if (matchesLeft == 1)
    { 
        goto CheckVictoryCondition;
    }
    goto DrawAgain;
}

// Check if the player lost or not
CheckVictoryCondition:
if (playerLost == true)
{
    
    Console.WriteLine("You lost!");
}
else
{
    Console.WriteLine("You won!");
}

