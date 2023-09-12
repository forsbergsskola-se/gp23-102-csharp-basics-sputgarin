
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

