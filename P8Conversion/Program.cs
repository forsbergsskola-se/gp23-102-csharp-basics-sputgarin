using System;
using System.Diagnostics;
using System.Globalization;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
double doubleNumber;
int intNumber;
string input;

Console.WriteLine("Give me a number.");
input = Console.ReadLine();
doubleNumber = double.Parse(input, CultureInfo.InvariantCulture);
Console.WriteLine(doubleNumber);
intNumber = Convert.ToInt32(doubleNumber);
Console.WriteLine(intNumber);
doubleNumber = double.Parse(intNumber);