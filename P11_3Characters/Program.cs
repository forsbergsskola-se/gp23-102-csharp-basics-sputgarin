
// Prompt the user to enter a single character.
Console.WriteLine("Please enter a single character: ");

// 
char userCharacter = Convert.ToChar(Console.ReadLine());

// Check if the userCharacter is a digit and then type not a letter. 
// Then checking if the letter is a vawel or a consonant.
string result = char.IsLetter(userCharacter) ?
       (userCharacter == 'a' || userCharacter == 'e' || userCharacter == 'i' || userCharacter == 'o' ||
       userCharacter == 'u' || userCharacter == 'A' || userCharacter == 'E' || userCharacter == 'I' ||
       userCharacter == 'O' || userCharacter == 'U') ? 
       "That's a vowel." 
       : "That's a consonant" 
       : "Not a letter";

/*
if (char.IsLetter(userCharacter))
{
    if (userCharacter == 'a' || userCharacter == 'e' || userCharacter == 'i' || userCharacter == 'o' ||
        userCharacter == 'u' || userCharacter == 'A' || userCharacter == 'E' || userCharacter == 'I' ||
        userCharacter == 'O' || userCharacter == 'U')
    {
        Console.WriteLine("That's a vowel.");  
    }
    else
    {
        Console.WriteLine("That's a consonant.");
    }
}

else
{
      Console.WriteLine("You entered a digit.");  
}

*/