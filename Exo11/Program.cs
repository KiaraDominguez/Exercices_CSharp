int nb = 1;
int x = nb;

for (int i = 5 ; i>0; i--)
{
    for (int j = 20; j > 0; j--)
    {
        Console.WriteLine($"{nb} x {x} = {nb * x}");
        x++;
    }
    nb += 1;
    x = 1;
}