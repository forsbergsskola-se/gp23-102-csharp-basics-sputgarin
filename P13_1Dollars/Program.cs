int counter = 0;
string dollarSign = "$";

Console.WriteLine("How many dollar signs do you want?");
int userNumber = int.Parse(Console.ReadLine());
Console.Write($"Here's your Dollars: ");
Loop:
if (counter < userNumber)
{
    Console.Write(dollarSign);
    counter++;
    goto Loop;
}
