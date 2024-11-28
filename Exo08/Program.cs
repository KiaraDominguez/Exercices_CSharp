Random RNG = new Random();
int nbAleatoire = RNG.Next(3);
string computer = "";

switch(nbAleatoire)
{
    case 0:
        computer = "pierre";
        break;
    case 1:
        computer = "ciseaux";
        break;
    case 2:
        computer = "papier";
        break;
}

Console.WriteLine(" Pierre, Papier , Ciseaux ? : ");
string player = Console.ReadLine();

if (player == computer)
{
    Console.WriteLine("Egalité");
}
else if ((player == "papier" && computer == "pierre") || (player == "ciseaux" && computer == "papier") || (player == "pierre" && computer == "ciseaux"))
{
    Console.WriteLine("Gagné");
}
else
    Console.WriteLine("Perdu");
Console.WriteLine($"computer : {computer} player : {player}");