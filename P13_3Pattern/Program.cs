
string symbols = "#-#-#-#-#-";

int outerLoopCounter = 0;

Console.WriteLine("Please input how many time to write the ascii pattern: ");
int userNumber = Int32.Parse(Console.ReadLine());

outerLoop:
if (outerLoopCounter < userNumber)
{
    char[] charArray = symbols.ToCharArray();
    Array.Reverse(charArray);
    symbols = new string(charArray);
    Console.WriteLine(symbols);
    outerLoopCounter++;
    
    goto outerLoop;
}

