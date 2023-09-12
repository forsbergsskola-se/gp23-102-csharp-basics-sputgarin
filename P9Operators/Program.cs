
// Declaring and initializing the secondsTotal variable.
int secondsTotal = 0;

// Prompting the user for a number of seconds.
Console.WriteLine("Give me a number of seconds");
// Taking the inputut and converting it to int32 then assigning it to the variable secondsTotal.
secondsTotal = Convert.ToInt32(Console.ReadLine());

// Takes seconds total and divides it by mintues in a day. Then assigns the amount of days to the variable days.
int days = (int)secondsTotal / 86400;

// To get the seconds left we use the modulus operator on the secondsTotal variable and assign it to seconds left.
int secondsLeft = secondsTotal % 86400;

// Then seconds left are used to calculate how many hours by dividing it by the number of seconds in an hour.
int hours = (int)secondsLeft / 3600;

// Then we use the modulus operator to get the number of seconds left after we divided my the total amount of seconds in an hour.
secondsLeft = secondsLeft % 3600;

// We do the same thing for minuts.
int minutes = (int)secondsLeft / 60;

// Then we get the seconds left.
secondsLeft = secondsLeft % 60;

// To get the avarage we use the seconds total cast it to a double and then divide with the number of seconds in a day.
double result = (double)secondsTotal  / 86400;

// Printing the results.
Console.WriteLine($@"
Seconds: {secondsLeft}
Minutes: {minutes} 
Hours: {hours} 
Days: {days} 
{days}.{hours}.{minutes}.{secondsLeft}");
Console.WriteLine(result);

