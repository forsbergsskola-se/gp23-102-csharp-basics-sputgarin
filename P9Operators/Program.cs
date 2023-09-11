

using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

/*
// P09_10SecondsToMinutes
int seconds;
int minutes;
int secondsLeft;
string input;

Console.WriteLine("Please enter seconds: ");
input = Console.ReadLine();
seconds = Convert.ToInt32(input);
minutes = seconds / 60;
secondsLeft = seconds % 60;
Console.WriteLine("Minutes: {0} Seconds: {1}", minutes, secondsLeft);
*/

/*

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

*/

/*
// P09_08BMI
double weight = 0;
double height = 0;
string input;
Console.WriteLine("Please enter your weight: ");
input = Console.ReadLine();
weight = double.Parse(input, CultureInfo.InvariantCulture);
Console.WriteLine("Please enter your height: ");
input = Console.ReadLine();
height = Convert.ToDouble(input);

double BMI = weight / (height * height);
Console.WriteLine("Your BMI is: {0}", BMI);
*/

/*
// P09_07Product
Console.WriteLine("Please type a number: ");
int i = Convert.ToInt32(Console.ReadLine());
int y = 5;
Console.WriteLine(i * y);

*/

/*
// P09_06Negation
Console.WriteLine("Please type a number: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = -x;
Console.WriteLine("The negation is: {0}",y);

*/

/*
// P09_05CircleArea
string input;
double radius;
double pi = 3.14159;
Console.WriteLine("Enter the radius: ");
input = Console.ReadLine();
radius = Convert.ToDouble(input);
double result = pi * (radius * radius);
Console.WriteLine("The area is: {0}", result);
*/


/*
// P09_04Remainder
int i = 10;
int j = 3;
int result = i % j;
Console.WriteLine("The remainder is: {0}", result);
*/

/*
// P09_03Division
int i = 5;
int j = 4;

float summary = (float)i / (float)j;
Console.WriteLine(@"Result: {summary}");
*/

/*
  // PROGRAM 1
string input = Console.ReadLine();
int kmH = Convert.ToInt32(input);
float result = (float)kmH * 1000 / 60 / 60;

Console.WriteLine($@"m/s is {result}");
*/

/*
// PROGRAM ????
Console.WriteLine("Enter Minutes: ");
int minutes = Convert.ToInt32(Console.ReadLine());
int seconds = minutes * 60;
Console.WriteLine($@"There are {seconds} in {minutes} Minute/s");
*/


// Program 10


int secondsTotal = 0;

Console.WriteLine("Give me a number of seconds");
secondsTotal = Convert.ToInt32(Console.ReadLine());

int days = (int)secondsTotal / 86400;
int secondsLeft = secondsTotal % 86400;
int hours = (int)secondsLeft / 3600;
secondsLeft = secondsLeft % 3600;
int minutes = (int)secondsLeft / 60;
secondsLeft = secondsLeft % 60;

double result = (double)secondsTotal  / 86400;



Console.WriteLine($@"
Seconds: {secondsLeft}
Minutes: {minutes} 
Hours: {hours} 
Days: {days} 
{days}.{hours}.{minutes}.{secondsLeft}");
Console.WriteLine(result);
