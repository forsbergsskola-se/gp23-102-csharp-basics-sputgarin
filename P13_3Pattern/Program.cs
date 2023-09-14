string symbols1 = "#-";
string symbols2 = "-#";
int counterOuter = 0;
int counterInner = 0;

Console.WriteLine("Please input how many time to write the ascii pattern: ");
int userNumber = Int32.Parse(Console.ReadLine());

outerLoop:
if (counterOuter < userNumber)
{
    counterInner = 0;
    LoopInnerLoop:
    if (counterInner < userNumber)
    {
        if (counterOuter % 2 == 0)
        {
            Console.Write(symbols1);
        }
        else
        {
            
            Console.Write(symbols2);
        }
        counterInner++;
        
        goto LoopInnerLoop;
    }
    counterOuter++;
    
    Console.WriteLine();

    goto outerLoop;
}

/*
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
*/
