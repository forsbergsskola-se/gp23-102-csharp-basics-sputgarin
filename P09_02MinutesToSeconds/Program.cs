// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter minutes: ");
var minutes = int.Parse((Console.ReadLine()));
var seconds = minutes * 60;
Console.WriteLine(seconds);


/*
// P09_02MinutesToSeconds
Console.WriteLine("Enter Minutes: ");
int minutes = Convert.ToInt32(Console.ReadLine());
int seconds = minutes * 60;
Console.WriteLine($@"There are {seconds} in {minutes} Minute/s");
*/