Console.WriteLine("Entrez un nombre : ");
int number = int.Parse(Console.ReadLine());
string etoile = "*";

for  (int i = number; i > 0 ;i--)
{
    Console.WriteLine(etoile+="*");
}
