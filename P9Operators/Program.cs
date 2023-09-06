using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


// Program 9
string input;
Console.WriteLine("Please enter seconds: ");
input = Console.ReadLine();


/*

// Program 8
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
// Program 7  BMI
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
// Program 6
Console.WriteLine("Please type a number: ");
int i = Convert.ToInt32(Console.ReadLine());
int y = 5;
Console.WriteLine(i * y);

*/

/*
// Program 5
Console.WriteLine("Please type a number: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = -x;
Console.WriteLine("The negation is: {0}",y);

*/

/*
// Program 4
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
// Program 3
int i = 10;
int j = 3;
int result = i % j;
Console.WriteLine("The remainder is: {0}", result);
*/

/*
// PROGRAM 2
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

/*
int secondsTotal;    
Console.WriteLine("Give me a number of seconds");
secondsTotal = Convert.ToInt32(Console.ReadLine());

double days = (double)secondsTotal / 86400;
int secondsLeft = secondsTotal % 86400;
double hours = (double)secondsLeft / 3600;
secondsLeft = secondsLeft % 3600;
double minutes = (double)secondsTotal / 60;
secondsLeft = secondsLeft % 3600;

int daysInt = Convert.ToInt32(days);
int hoursInt = Convert.ToInt32(hours);
int minutesInt = Convert.ToInt32(minutes);
int secondsInt = Convert.ToInt32(secondsLeft);
Console.WriteLine($@"
Seconds: {secondsInt}
Minutes: {minutesInt} 
Hours: {hoursInt} 
Days: {daysInt} 
{daysInt}.{hours}.{minutes}.{secondsLeft}");
*/