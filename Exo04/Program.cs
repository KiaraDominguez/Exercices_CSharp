Console.WriteLine("Entrez un nombre : ");
int nb = int.Parse(Console.ReadLine());

int midNb = nb / 2 + nb / 2;

if (midNb == nb)
{
    Console.WriteLine($"{nb} est un nombre pair");
}
else
{
    Console.WriteLine($"{nb} est un nombre impair");
}