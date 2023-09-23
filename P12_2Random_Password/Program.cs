Random random = new Random();
int character = random.Next(0, 65536);
char randomChar = (char)character;

Console.WriteLine($"Here is your password: ");
Console.Write(randomChar);

character = random.Next(48, 122);
randomChar = (char)character;
Console.Write(randomChar);

character = random.Next(48, 122);
randomChar = (char)character;
Console.Write(randomChar);

character = random.Next(48, 122);
randomChar = (char)character;
Console.Write(randomChar);

character = random.Next(48, 122);
randomChar = (char)character;
Console.Write(randomChar);

character = random.Next(48, 122);
randomChar = (char)character;
Console.Write(randomChar);