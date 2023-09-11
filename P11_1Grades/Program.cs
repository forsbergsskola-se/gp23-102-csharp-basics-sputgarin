// Prompt the user to enter the number of points the student got on the test.
Console.WriteLine("Please enter the number of points: ");

// Convert the user string input to an Int32 and store in the variable points.
int points = Convert.ToInt32(Console.ReadLine());

// Check the result and give the student a grade depending on the number of points.
string result = points >= 90 ? "A" : points >= 80 ? "B" : points >= 70 ? "C" : points >= 60 ? "D" : "F";

// Display the grade in the console.    
Console.WriteLine($"The grade is: {result}");

