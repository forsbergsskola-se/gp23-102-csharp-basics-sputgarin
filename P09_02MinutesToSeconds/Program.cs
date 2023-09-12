// P09_02MinutesToSeconds

// Prompting the user to enter minutes
Console.WriteLine("Enter Minutes: ");

// Converting the user read input to an int32 and storing it in the variable minutes.
int minutes = Convert.ToInt32(Console.ReadLine());

// Multiplying minutes with 60 to get the number of seconds in the inputed minutes.
int seconds = minutes * 60;

// Printing the results.
Console.WriteLine($@"There are {seconds} in {minutes} Minute/s");


/*
Console.WriteLine("Please enter minutes: ");
var minutes = int.Parse((Console.ReadLine()));
var seconds = minutes * 60;
Console.WriteLine(seconds);
 */
