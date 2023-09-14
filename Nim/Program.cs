// Declare and Inialize the variables.

// How many matches are there from the start.
int matchesLeft = 24;

// A variable that will do a predicted draw to see if you are able to draw that many matches.
int predictedDraw = 0;

// Boolean if the player have lost or won.
bool playerLost = false;

// How many matches are drawn.
int drawMatches = 0;

// String that keeps track of the graphic component. The amount of matches left determines how many '|' are drawn.
string matchesDrawn = new string('|', matchesLeft);

// Create a new random variable.
Random random = new Random();

// Greet the player.
Console.WriteLine("Welcome to Nim!");
Console.WriteLine($"{matchesDrawn} ({matchesLeft})");

DrawAgain:
Console.WriteLine("How many matches do you want to draw?");

// Take user input.
drawMatches = Convert.ToInt32(Console.ReadLine());

// If user input is to big or small send the user to DrawAgain.
if (drawMatches > 3 || drawMatches < 1)
{
    Console.WriteLine("Please enter a number between 1-3");
    goto DrawAgain;
}


// Do a predicted draw.
predictedDraw = matchesLeft - drawMatches;

// The user should not be able to pick more straws that exist in the game.
// So limit the draws the user can make.
if (predictedDraw < 0)
{
    Console.WriteLine("There must always be one straw left.");
    goto DrawAgain;
}

// If all checks out let the player draws from matches left.
// Then the matchesDrawn will also be subtracted by the amount the player draw.
{
    matchesLeft -= drawMatches;
    matchesDrawn = new string('|', matchesLeft);
    if (matchesLeft == 0)
    {
        // If the player picks the last match and there are no matches left.
        // Set the bool playerLost and send the player to the CheckVictoryCondition label.
        playerLost = true;
        goto CheckVictoryCondition;
    }
    Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
    

}

AiDrawAgain:

// Check if the AI should randomise by three.
// There is no reason for the ai to randomise more than two numbers if there is three left.
// And if it's lower than two it just sets the variable to 1.
if (matchesLeft > 3)
{
     drawMatches = random.Next(1, 4);
}

else if (matchesLeft == 3)
{
     drawMatches = random.Next(1, 2);
}

else
{
    drawMatches = 1;
}

// Do a predicted draw.
predictedDraw = matchesLeft - drawMatches;

// The ai should not be able to pick more straws that exist in the game.
// So limit the draws the user can make.
if (predictedDraw < 0)
{
    goto AiDrawAgain;
}
else
{
    // If all checks out let the ai draws from matches left.
    // Then the matchesDrawn will also be subtracted by the amount the ai draw.
    matchesLeft -= drawMatches;
    matchesDrawn = new string('|', matchesLeft);
    Console.WriteLine($"The AI draws {drawMatches} matches.");
    // If the AI picked the last straw the Ai lost.
    // Go to the CheckVictoryCondition .
    if (matchesLeft == 0)
    { 
        goto CheckVictoryCondition;
    }
    Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
    

    goto DrawAgain;
}

// Check if the player lost or not
CheckVictoryCondition:
if (playerLost == true)
{
    
    Console.WriteLine("You drew the last match. You lose.");
}
else
{
    Console.WriteLine("The AI drew the last match. You win.");
}

/*
BEFORE OPTIMIZATION

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
    Console.WriteLine();
    goto DrawAgain;
}


// Do a predicted draw.
predictedDraw = matchesLeft - userDraw;

// The user should not be able to pick more straws that exist in the game.
// So limit the draws the user can make.
if (predictedDraw < 0)
{
    Console.WriteLine("There must always be one straw left.");
    goto DrawAgain;
}

// If all checks out let the player draws from matches left.
// Then the matchesDrawn will also be subtracted by the amount the player draw.
{
    matchesLeft -= userDraw;
    matchesDrawn = matchesDrawn.Substring(0, matchesDrawn.Length - userDraw);
    if (matchesLeft == 0)
    {
        playerLost = true;
        goto CheckVictoryCondition;
    }
    Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
    
    // If there is only one match left.
    // Set the bool playerLost and send the player to the CheckVictoryCondition label.

}

AiDrawAgain:

// Check if the AI should randomise by three.
// There is no reason for the ai to randomise more than two numbers if there is three left.
// And if it's lower than two it just sets the variable to 1.
if (matchesLeft > 3)
{
     aiDraw = random.Next(1, 4);
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
if (predictedDraw < 0)
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
    // If the ai have the last straw.
    // Go to the CheckVictoryCondition .
    if (matchesLeft == 0)
    { 
        goto CheckVictoryCondition;
    }
    Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
    

    goto DrawAgain;
}

// Check if the player lost or not
CheckVictoryCondition:
if (playerLost == true)
{
    
    Console.WriteLine("You drew the last match. You lose.");
}
else
{
    Console.WriteLine("The ai drew the last match. You win.");
}
*/

