// P09_09Hypotenuse
string input;
double firstSide = 0;
double secondSide = 0;
double bothSides;
double results;

Console.WriteLine("Please enter the first side: ");
input = Console.ReadLine();
firstSide = Convert.ToDouble(input);

Console.WriteLine("Please enter the second side: ");
input = Console.ReadLine();
secondSide = Convert.ToDouble(input);

firstSide = firstSide * firstSide;
secondSide = secondSide * secondSide;
bothSides = firstSide + secondSide;
results = Math.Sqrt(bothSides);
Console.WriteLine($@"The result is: {results}");
