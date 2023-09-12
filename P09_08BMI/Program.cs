using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

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
