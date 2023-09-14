
Random random = new Random();
int itemnumber = random.Next(1, 6);

string response =   itemnumber == 1 ? "Accuired: Sword!" : 
                    itemnumber == 2 ? "Accuired: Staff!" : 
                    itemnumber == 3 ? "Accuired: Potion!" : 
                    itemnumber == 4 ? "Accuired: Helmet" :
                    "Accuired: Boots of spanish leather ";
                    
Console.WriteLine(response);                    