
// Prompt the user for two numbers and an operator.
Console.WriteLine("Please input two number with an operator in between: ");

// Convert the first number to an int and add it to the variable number.
int number1 = Convert.ToInt32(Console.ReadLine());

// Convert the operator to a char.
char mathOperator = Convert.ToChar(Console.ReadLine());

// Convert the second number to an int and add it to the variable number.
int number2 = Convert.ToInt32(Console.ReadLine());

// If the math operator is + add the numbers together.
if (mathOperator == '+')
{
    int result = number1 + number2;
    Console.WriteLine(result);
}

// If the math operator is - subtract the numbers.
else if (mathOperator == '-')
{
    int result = number1 - number2;
    Console.WriteLine(result);
}

// If the math operator is * multiply the numbers.
else if (mathOperator == '*')
{
    int result = number1 * number2;
    Console.WriteLine(result);
}

// If the math operator is / divide the numbers.
else if (mathOperator == '/')
{
    float result = (float)number1 / number2;
    Console.WriteLine(result);
}

else
{
    Console.WriteLine("Not a math operator!!!");
}



