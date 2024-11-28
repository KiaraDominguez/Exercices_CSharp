Console.WriteLine("Introduisez votre mdp : ");
string user = Console.ReadLine();

string password = "mdp";

if (user == password)
{
    Console.WriteLine("Bienvenue!");

}
else
{
     for (int i = 0; i < 2; i++)
    {
        Console.WriteLine("Mdp incorrect!");
        
        Console.WriteLine("Introduisez votre mdp : ");
        user = Console.ReadLine();
            
    }
}

if (user != password)
    Console.WriteLine("Compte bloque");
