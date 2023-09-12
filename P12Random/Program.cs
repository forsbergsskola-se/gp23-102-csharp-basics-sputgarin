// Prompt the user for a seed.
Console.WriteLine("Please pass me a seed (integer)");

int seed = Convert.ToInt32((Console.ReadLine()));
Random random = new Random(seed);
Console.WriteLine("Three integers between 0 and 5 :");
int randomNumber = random.Next(0,5);
Console.WriteLine(randomNumber);
randomNumber = random.Next(0,5);
Console.WriteLine(randomNumber);
randomNumber = random.Next(0,5);
Console.WriteLine(randomNumber);

Console.WriteLine("Three numbers between 0.0 and 0.5: ");
double doubleNumber = random.NextDouble() / 2;
Console.WriteLine(doubleNumber);
doubleNumber = random.NextDouble() / 2;;
Console.WriteLine(doubleNumber);
doubleNumber = random.NextDouble() / 2;;
Console.WriteLine(doubleNumber);

Console.WriteLine("Three numbers between 0.2 and 0.7: ");
doubleNumber = random.NextDouble() / 2 + 0.2;
Console.WriteLine(doubleNumber);
doubleNumber = random.NextDouble() / 2 + 0.2;
Console.WriteLine(doubleNumber);
doubleNumber = random.NextDouble() / 2 + 0.2;
Console.WriteLine(doubleNumber);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double critChance = Convert.ToDouble((Console.ReadLine()));
double randomNumber2 = random.NextDouble();
Console.WriteLine( randomNumber2 < critChance
    ? "Crit"
    : "No Crit");

randomNumber2 = random.NextDouble();
Console.WriteLine( randomNumber2 < critChance
    ? "Crit"
    : "No Crit");

randomNumber2 = random.NextDouble();
Console.WriteLine( randomNumber2 < critChance
    ? "Crit"
    : "No Crit");

randomNumber2 = random.NextDouble();
Console.WriteLine( randomNumber2 < critChance
    ? "Crit"
    : "No Crit");

randomNumber2 = random.NextDouble();
Console.WriteLine( randomNumber2 < critChance
    ? "Crit"
    : "No Crit");

/*
Console.WriteLine(random.Next());


Console.WriteLine(random.NextDouble().ToString());

*/