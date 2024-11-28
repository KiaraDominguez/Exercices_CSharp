int count = 10;
int result = 0;

do
{
    Console.WriteLine($"Taper un nombre ( {count} entrée restante ) : ");
    int nb = int.Parse(Console.ReadLine());
    if (nb < result)
        result = nb;
    count--;

}while(count > 0);

Console.WriteLine(result);