// P09_10SecondsToMinutes

// Declaring the variables
int seconds;
int minutes;
int secondsLeft;
string input;

// Promt the user to enter a number of seconds.
Console.WriteLine("Please enter seconds: ");

// Convert the user input to an int32 and assign it to the seconds variable. 
seconds = Convert.ToInt32(Console.ReadLine());

// divide the seconds by 60.
minutes = seconds / 60;

// Then use the modulus operator with 60 to get the seconds left.
secondsLeft = seconds % 60;

// Print the results to the console.
Console.WriteLine("Minutes: {0} Seconds: {1}", minutes, secondsLeft);
