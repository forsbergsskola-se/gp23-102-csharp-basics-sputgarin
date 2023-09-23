// P09_09Hypotenuse

// Declare the variables and initialize some of the variables.
string input;
double firstSide = 0;
double secondSide = 0;
double bothSides;
double results;

// Prompt the user to input the first side.
Console.WriteLine("Please enter the first side: ");

// Read the user input.
input = Console.ReadLine();

// Convert the input to a double.
firstSide = Convert.ToDouble(input);

// Prompt the user to input the second side.
Console.WriteLine("Please enter the second side: ");

// Read the user input.
input = Console.ReadLine();

// Convert the input to a double.
secondSide = Convert.ToDouble(input);

// Multiply the first side with itself.
firstSide = firstSide * firstSide;

// Multiply the second side with itself.
secondSide = secondSide * secondSide;

// Add the two sides together add assign the result to the variable bothSides.
bothSides = firstSide + secondSide;

// Get the square root of both sides.
results = Math.Sqrt(bothSides);

// Print the results to the console.
Console.WriteLine($@"The result is: {results}");
