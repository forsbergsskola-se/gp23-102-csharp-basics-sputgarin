
// P09_05CircleArea

// Declare the string input.
string input;

// Declare a double named radius.
double radius;

// Initializing and assigning the pi variable.
double pi = 3.14159;

// Prompt the user to enter the radius.
Console.WriteLine("Enter the radius: ");

// Read the input and assign it to the input variable.
input = Console.ReadLine();

// Convert the input variable to a double.
radius = Convert.ToDouble(input);

// Using Pythagoras sats to calculate the results.
double result = pi * (radius * radius);

// Printing the result to the console.
Console.WriteLine("The area is: {0}", result);
