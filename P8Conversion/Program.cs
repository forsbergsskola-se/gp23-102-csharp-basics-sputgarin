using System;
using System.Diagnostics;
using System.Globalization;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
double doubleNumber;
int intNumber;
string input;

Console.WriteLine("Give me a number.");
input = Console.ReadLine();
input = input.Replace(',', '.');
doubleNumber = double.Parse(input, CultureInfo.InvariantCulture);
//doubleNumber = double.Parse(input, CultureInfo.GetCultureInfo("sv-SE"));

Console.WriteLine(doubleNumber);

intNumber = Convert.ToInt32(doubleNumber);

Console.WriteLine(intNumber);