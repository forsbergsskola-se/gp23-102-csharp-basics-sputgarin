char symbol = '#';
int counter = 0;
int counterTwo = 0;
int loopValue = 0;

Console.WriteLine("How high do you want your pyramid to be?");
int height = int.Parse(Console.ReadLine());

OuterLoop:
if (counter < height)
{
    
    
    LoopInnerLoop:
    if (counterTwo < height)
    {
        
        counterTwo++;
        Console.Write(symbol);
        
        goto LoopInnerLoop;
        
    }
    loopValue++;
    counterTwo = loopValue;
    Console.WriteLine();
    

    counter++;
    goto OuterLoop;
    
    
}