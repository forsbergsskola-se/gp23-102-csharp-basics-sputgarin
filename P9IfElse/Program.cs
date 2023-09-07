int age;
int number;

Console.WriteLine("What's your age?");
age = Convert.ToInt32(Console.ReadLine());

if (age < 13)
{
    Console.WriteLine("You are a child!");
}
else if (age > 12 && age < 19)
{
    Console.WriteLine("You are a Teenager!");
}

else
{
    Console.WriteLine("You are a grown-up.");
}

Console.WriteLine("Give me another integer.");
number = Convert.ToInt32(Console.ReadLine());
if (number > age)
{
Console.WriteLine($"The maximum is. {number} ");
if (number % 2 == 0)
{
    Console.WriteLine($"Your number is an even number.");
}
else
{
    Console.WriteLine($"Your number is an odd number.");
}
}

else
{
Console.WriteLine($"The maximum is. {age} ");
if (age % 2 == 0)
{
Console.WriteLine($"Your number is an even number.");
}
else
{
    Console.WriteLine($"Your number is an odd number.");
}
}

