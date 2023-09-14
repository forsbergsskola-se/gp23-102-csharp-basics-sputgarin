// Create a double for the secretMessageChance and give it a 10% change to show up.
double secretMessageChance = 0.1f;

// Create a new random float number and then assign it to the randomNumber variable.
double randomNumber = Random.Shared.NextDouble();

// Test to see if 
string result = randomNumber < secretMessageChance
    ? "Did you know alpacas can't spit?"
    : "This is a normal boring message.";
Console.WriteLine(result);
