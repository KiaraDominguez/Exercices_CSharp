
Console.WriteLine("Entrer un nombre : ");
int input;

bool isOkay = int.TryParse(Console.ReadLine(), out input);
int resultat = 0;
int x = input;

while (!isOkay)
{
    Console.WriteLine("Nombre invalide ... ");
    isOkay = int.TryParse(Console.ReadLine(), out input);

}

for (int i = input-1 ; i > 0 ; i--)
{
    resultat = x * i;
    x = resultat;
}

Console.WriteLine(resultat);