
double secretMessageChance = 0.1f;
double randomNumber = Random.Shared.NextDouble();

string result = randomNumber < secretMessageChance
    ? "Did you know alpacas can't spit?"
    : "This is a normal boring message.";
Console.WriteLine(result);
