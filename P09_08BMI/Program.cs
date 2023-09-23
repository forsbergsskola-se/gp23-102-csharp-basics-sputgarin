// using System.Globalization;
// Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

// P09_08BMI

// Declaring and initializing the double variable weight.
double weight = 0;

// Declaring and initializing the double variable height.
double height = 0;

// Declaring the sting variable input.
string input;

// Prompt the user to enter their weight.
Console.WriteLine("Please enter your weight: ");
input = Console.ReadLine();

// Parsing the input value to a double.
weight = double.Parse(input);


// Prompt the user for height with a comma(,).
Console.WriteLine("Please enter your height with a comma(,). eg. 1,8: ");

// Read the user input.
input = Console.ReadLine();

// Convert the user input to a double.
height = Convert.ToDouble(input);

// Calculate the BMI
double BMI = weight / (height * height);

// Print the result to the console.
Console.WriteLine("Your BMI is: {0}", BMI);
