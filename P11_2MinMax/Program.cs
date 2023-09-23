// See https://aka.ms/new-console-template for more information

using System.Numerics;

// Prompt the user for three numbers.
Console.WriteLine("Please Input 3 numbers");

// Convert the strings to integers.
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

// Compare the two first numbers and add the smallest to the minNumber1 variable
int minNumber1 = Math.Min(number1, number2);

// Then compare the minNumber1 to the third number and store it into the minNumberResult variable.
int minNumberResult = Math.Min(minNumber1, number3);

// Compare the two first numbers and add the biggest to the maxNumberResult variable
int maxNumber1 = Math.Max(number1, number2);

// Then compare the maxNumber1 to the third number and store it into the maxNumberResult variable.
int maxNumberResult = Math.Max(maxNumber1, number3);

// Print the result to the console.
Console.WriteLine($"The minimum number is: {minNumberResult}, The maximum number is: {maxNumberResult}");
