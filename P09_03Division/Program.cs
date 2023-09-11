
Console.WriteLine("Give me a number: ");
int first = int.Parse((Console.ReadLine()));

Console.WriteLine("Give me another number: ");
int second = int.Parse((Console.ReadLine()));

// At least one number needs to be casted to a float.
// Otherwise the division will happen before the number is converted to float
float result = (float)first / second; 
Console.WriteLine(result);
