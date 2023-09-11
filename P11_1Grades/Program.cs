
Console.WriteLine("Please enter the number of points: ");
int points = Convert.ToInt32(Console.ReadLine());
string result = points >= 90 ? "A" : points >= 80 ? "B" : points >= 70 ? "C" : points >= 60 ? "D" : "F";

Console.WriteLine($"The grade is: {result}");

