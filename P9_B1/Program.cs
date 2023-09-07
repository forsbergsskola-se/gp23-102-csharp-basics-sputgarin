// Prompt the user for input.
Console.WriteLine("Input a 0 or a 1");


// Converting the user input to a int32 variable named number.
int number = Convert.ToInt32(Console.ReadLine());
int a = number;
int b = 1;
int c = -1;
/*
Inverts the number to 1 if the input is 0. And changes the number to 0 if the input is 1
How it works for input 1: 1 - 1 = 0 * -1 = 0
How it works for input 0: 0 - 1 = -1 * -1 = 1. 
*/
// int result = (number - 1) * inversion ;
//int result = (a - b) * -1 ;
int result = number * c - b * c;

// How it works for input 1: (1 * -1) = -1  - (1 * -1) = 1   -1 + 1 = 0
// How it works for input 0: 0 - 1 = -1 * -1 = 1. 

// Print results.
Console.WriteLine(result);

// :)

