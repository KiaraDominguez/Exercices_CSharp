Console.WriteLine(" Nombre de fois : ");
int nbRep =  int.Parse(Console.ReadLine());

Console.WriteLine(" Nombre de tirets : ");
int nbTiret = int.Parse(Console.ReadLine());

Console.WriteLine(" Nombre de d'espace : ");
int nbEspace = int.Parse(Console.ReadLine());

string result = "" , repetition = "";

while (nbRep > 0)
{
    nbRep--;

    while (nbTiret > 0)
    {
        nbTiret--;
        result += "-";

    }
    while (nbEspace > 0)
    {
        nbEspace--;
        result += " ";
    }

    repetition += result;
    
    
}
Console.WriteLine($"[{repetition}]");