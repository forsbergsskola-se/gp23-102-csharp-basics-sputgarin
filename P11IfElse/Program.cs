// Prompting the user for age.
Console.WriteLine("What's your age?");

// Convert the intager to a int32 and assign it the the variable age.
int age = Convert.ToInt32(Console.ReadLine());

// Checking if the user is a child, teenager or an adult.
string response = age < 13 ? "you are a child!" : age < 19 ? "You are a teenager." : "You are a grown-up";
Console.WriteLine(response);

// Prompt the user for another integer.
Console.WriteLine("Give me another integer.");

// Convert the intager to a int32 and assign it the the variable number.
int number = Convert.ToInt32(Console.ReadLine());

// Check what number is the highest out of number and age.
response = number > age ? $"The maximum is {number}" : $"The maximum is {age}"; 
Console.WriteLine(response);

// Check if the number you entered is even or odd.
response = number % 2 == 0 ? "Your number is an even number" : "Your number is an odd number.";
Console.WriteLine(response);



/*
// Declared and initialized booleans
bool isChild = false;
bool isTeenager = false;
bool isGrownup = false;
int number;

// Prompting the user for age.
Console.WriteLine("What's your age?");

// Converting the user input to Int32 and assigning it to the age variable.
int age = Convert.ToInt32(Console.ReadLine());

// Checking if the age is below 13.
isChild = age < 13;

// Checking if the age is over 12 and under 19.
isTeenager = age > 12 && age < 19;

// Checking if the age is over 18.
isGrownup = age > 18;

// Printing the result to the console.
Console.WriteLine("You are a child: {0}", isChild);
Console.WriteLine("You are a teenager: {0}", isTeenager);
Console.WriteLine("You are a grown-up: {0}", isGrownup);

// Check if the age is lower than 13.
if (isChild)
{
    Console.WriteLine("You are a child!");
}

// Check if the user is between 12 and 19.
else if (isTeenager)
{
    Console.WriteLine("You are a Teenager!");
}

// If none of the earlier statements were true. You are a grown up.
else if(isGrownup)
{
    Console.WriteLine("You are a grown-up.");
}

// Prompt the user for another integer.
Console.WriteLine("Give me another integer.");

// Convert the intager to a int32 and assign it the the variable number.
number = Convert.ToInt32(Console.ReadLine());

// Check if the number is bigger than the age.
if (number > age)
{
    Console.WriteLine($"The maximum is. {number} ");

// Check if the number i an even or an odd number.
    if (number % 2 == 0)
    {
        Console.WriteLine($"Your number is an even number.");
    }
// If the number is not equal to 0 "Even" then run the else statement 
    else
    {
        Console.WriteLine($"Your number is an odd number.");
    }
}

//  If the number is no bigger than the age then run this.
else
{
    Console.WriteLine($"The maximum is. {age} ");
// Check if the number i an even or an odd number.
    if (age % 2 == 0)
    {
        Console.WriteLine($"Your number is an even number.");
    }
// If the number is not equal to 0 "Even" then run the else statement 
    else
    {
        Console.WriteLine($"Your number is an odd number.");
    }
}

*/



/*// Declaring and Initializing variables.
int age;
int number;

// Prompts the user for age.
Console.WriteLine("What's your age?");

// Converts the input to a int32 variable named age. 
age = Convert.ToInt32(Console.ReadLine());

// Check if the age is lower than 13.
if (age < 13)
{
    Console.WriteLine("You are a child!");
}

// Check if the user is between 12 and 19.
else if (age > 12 && age < 19)
{
    Console.WriteLine("You are a Teenager!");
}

// If none of the earlier statements were true. You are a grown up.
else
{
    Console.WriteLine("You are a grown-up.");
}

// Prompt the user for another integer.
Console.WriteLine("Give me another integer.");

// Convert the intager to a int32 and assign it the the variable number.
number = Convert.ToInt32(Console.ReadLine());

// Check if the number is bigger than the age.
if (number > age)
{
Console.WriteLine($"The maximum is. {number} ");

// Check if the number i an even or an odd number.
if (number % 2 == 0)
{
    Console.WriteLine($"Your number is an even number.");
}
// If the number is not equal to 0 "Even" then run the else statement 
else
{
    Console.WriteLine($"Your number is an odd number.");
}
}

//  If the number is no bigger than the age then run this.
else
{
Console.WriteLine($"The maximum is. {age} ");
// Check if the number i an even or an odd number.
if (age % 2 == 0)
{
Console.WriteLine($"Your number is an even number.");
}
// If the number is not equal to 0 "Even" then run the else statement 
else
{
    Console.WriteLine($"Your number is an odd number.");
}
}*/




