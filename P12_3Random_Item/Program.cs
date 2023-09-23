// Create a new random.
Random random = new Random();

// Do a random draw between 1 and 5 and assign it to a number.
int itemnumber = random.Next(1, 6);

// Depending on what number you got, you recieve a different item.
string response =   itemnumber == 1 ? "Accuired: Sword!" : 
                    itemnumber == 2 ? "Accuired: Staff!" : 
                    itemnumber == 3 ? "Accuired: Potion!" : 
                    itemnumber == 4 ? "Accuired: Helmet" :
                    "Accuired: Boots of spanish leather ";
                    
// Print the result.
Console.WriteLine(response);                    