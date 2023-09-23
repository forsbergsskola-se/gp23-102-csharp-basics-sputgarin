// P09_01SpeedConverter

// Prompting the user for an input
Console.WriteLine("Please enter km/h: ");

// Reading the user input and storing it to a variable named input.
string input = Console.ReadLine();

// Converting the variable to an int32 and assigning it to the int kmH
int kmH = Convert.ToInt32(input);

// Calculating the result and assigning it in the result variable.
float result = (float)kmH * 1000 / 60 / 60;

// Printing the result variable.
Console.WriteLine($@"m/s is {result}");
