// P09_01SpeedConverter


string input = Console.ReadLine();
int kmH = Convert.ToInt32(input);
float result = (float)kmH * 1000 / 60 / 60;

Console.WriteLine($@"m/s is {result}");
