// Declare and Inialize the variable matchsLeft.
int matchesLeft = 24;
int predictedDraw = 0;
bool playerLost = false;
string matchesDrawn = "||||||||||||||||||||||||";

// Create a new random variable.
Random random = new Random();

Console.WriteLine("Welcome to Nim!");
Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
DrawAgain:
Console.WriteLine("How many matches do you want to draw?");
int userDraw = Convert.ToInt32(Console.ReadLine());
if (userDraw > 3 || userDraw < 1)
{
    Console.WriteLine("You can only draw 1-3 matches.");
    goto DrawAgain;
}

predictedDraw = matchesLeft - userDraw;

if (predictedDraw < 1)
{
    Console.WriteLine("There must always be one straw left.");
    goto DrawAgain;
}

else
{
    // 
    matchesLeft -= userDraw;
    matchesDrawn = matchesDrawn.Substring(0, matchesDrawn.Length - userDraw);
    
    if (matchesLeft == 1)
    {
        playerLost = true;
        goto CheckVictoryCondition;
    }
}


AiDrawAgain:
int aiDraw = random.Next(1,3);

predictedDraw = matchesLeft - aiDraw;

if (predictedDraw < 1)
{
    goto AiDrawAgain;
}
else
{
    matchesDrawn = matchesDrawn.Substring(0, matchesDrawn.Length - aiDraw);
    matchesLeft = matchesLeft - aiDraw;
    Console.WriteLine($"The AI draws {aiDraw} matches.");
    Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
    if (matchesLeft == 1)
    { 
        playerLost = false;
        goto CheckVictoryCondition;
    }
    goto DrawAgain;
}

CheckVictoryCondition:
if (playerLost == true)
{
    Console.WriteLine($"{matchesDrawn} ({matchesLeft})");
    Console.WriteLine("You lost!");
}
else
{
    Console.WriteLine("You won!");
}

