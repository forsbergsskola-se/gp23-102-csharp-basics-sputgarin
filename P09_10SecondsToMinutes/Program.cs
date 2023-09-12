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
