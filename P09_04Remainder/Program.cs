
// P09_04Remainder

// Prompting the user to give a number.
Console.WriteLine("Give me a number: ");

// Parsing the value and assigning it to the int first variable.
int first = int.Parse((Console.ReadLine()));

// Prompting the user for another number.
Console.WriteLine("Give me another number: ");

// Parsing the value and assigning it to the int second variable.
int second = int.Parse((Console.ReadLine()));

// Using the modulus operation to get the remainder.
int result = first % second;

// Printing the result to the console.
Console.WriteLine("The remainder is: {0}", result);
