// Create a new random.
Random random = new Random();

// Give a random cordinate on the x and y axis.
int x = random.Next(1, 101);
int y = random.Next(1, 101);;

// Print result.
Console.WriteLine($"The enemy is at cordinates x: {x}, y: {y}");
