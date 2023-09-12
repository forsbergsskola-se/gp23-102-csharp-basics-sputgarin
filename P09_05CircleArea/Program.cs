
// P09_05CircleArea
string input;
double radius;
double pi = 3.14159;
Console.WriteLine("Enter the radius: ");
input = Console.ReadLine();
radius = Convert.ToDouble(input);
double result = pi * (radius * radius);
Console.WriteLine("The area is: {0}", result);
