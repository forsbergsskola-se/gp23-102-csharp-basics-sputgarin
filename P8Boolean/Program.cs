// Declared and initialized booleans
bool isChild = false;
bool isTeenager = false;
bool isGrownup = false;

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
Console.WriteLine(@$"You are a grown-up:

 {isGrownup}");



/*
// Declared and initialized booleans
bool isChild = false;
bool isTeenager = false;
bool isGrownup = false;

// Prompting the user for age.
Console.WriteLine("What's your age?");

// Converting the user input to Int32 and assigning it to the age variable.
int age = Convert.ToInt32(Console.ReadLine());

// Checking if age is less than 13. If condition is true change the boolean value to true.
if (age < 13)
{
    isChild = true;
}

// Checking if age is less than 13. If condition is true change the boolean value to true.
else if (age > 12 && age < 19)
{
    isTeenager = true;
}

// Checking if age is less than 13. If condition is true change the boolean value to true.
else if (age > 18)
{
    isGrownup = true;
}

// 
Console.WriteLine("You are a child: {0}", isChild);
Console.WriteLine("You are a teenager: {0}", isTeenager);
Console.WriteLine("You are a grown-up: {0}", isGrownup);

*/