// Prompting the user to give a number.
Console.WriteLine("Give me a number: ");

// Parsing the value and assigning it to the int first variable.
int first = int.Parse((Console.ReadLine()));

// Prompting the user for another number.
Console.WriteLine("Give me another number: ");

// Parsing the value and assigning it to the int second variable.
int second = int.Parse((Console.ReadLine()));

// At least one number needs to be casted to a float.
// Otherwise the division will happen before the number is converted to float
// Calculating the result.
float result = (float)first / second; 

// Print the result
Console.WriteLine(result);

/*
// P09_03Division
int i = 5;
int j = 4;

float summary = (float)i / (float)j;
Console.WriteLine(@"Result: {summary}");
*/