

double critChance = 0.2f;
double randomNumber = Random.Shared.NextDouble();
Console.WriteLine(randomNumber);

Console.WriteLine( randomNumber < critChance
    ? "You only had a 20% chance, but you were successful!"
    : "Unfortunately, 20% chance was not enough this time :(");




