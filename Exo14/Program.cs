using System.Diagnostics.CodeAnalysis;

Console.WriteLine(" Taille du premier côté du triange : ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine(" Taille du second côté du triange : ");
int second = int.Parse(Console.ReadLine());

Console.WriteLine(" Taille du troisième côté du triange : ");
int three = int.Parse(Console.ReadLine());

string cote = "";

if (first == second && second == three)
    cote = "Equilatéral";
else if (first == second || first == three || second == three)
    cote = "Isocèle";
else
    cote = "Scalène";

