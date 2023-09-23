// Declaring an initializing a char containing #
char symbol = '#';

// Counter for the outer loop.
int counterOuter = 0;

// Counter for the inner loop.
int counterInner = 0;

Console.WriteLine("How high do you want your pyramid to be?");
int height = int.Parse(Console.ReadLine());

OuterLoop:
// If the outer counter is less than the users input height run the outer loop.
if (counterOuter < height)
{
    
    // The inner loop takes care of typing out the symbols
    LoopInnerLoop:
    if (counterInner < height)
    {
        
        counterInner++;
        Console.Write(symbol);
        
        goto LoopInnerLoop;
        
    }
    // Increment the outer loop.
    counterOuter++;
    // Assign the value to the counterInner.
    counterInner = counterOuter;
    
    // Go to the next line.
    Console.WriteLine();
    
    goto OuterLoop;
    
}


/*
// OLD VERSION
// Declaring an initializing a char containing #
char symbol = '#';

// Counter for the outer loop.
int counterOuter = 0;

// Counter for the inner loop.
int counterInner = 0;

// Increments the value after the inner loop is done so it will run one time less next loop around.
int innerLoopIncrementer = 0;

Console.WriteLine("How high do you want your pyramid to be?");
int height = int.Parse(Console.ReadLine());

OuterLoop:
// If the outer counter is less than the users input height run the outer loop.
if (counterOuter < height)
{
    
    // The inner loop takes care of typing out the symbols
    LoopInnerLoop:
    if (counterInner < height)
    {
        
        counterInner++;
        Console.Write(symbol);
        
        goto LoopInnerLoop;
        
    }
    // Increment the innerloop so it will run one time less.
    innerLoopIncrementer++;
    // Assign the value to the counterInner.
    counterInner = innerLoopIncrementer;
    
    // Go to the next line.
    Console.WriteLine();
    
    // Increment the outer loop.
    counterOuter++;
    goto OuterLoop;
    
}
*/