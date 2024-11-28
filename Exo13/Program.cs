Console.WriteLine("Entrer un nombre : ");
int input;
bool isOkay = int.TryParse(Console.ReadLine(), out input);
while (!isOkay)
{
    Console.WriteLine("Nombre invalide ... ");
    isOkay = int.TryParse(Console.ReadLine(), out input);

}

int count = 0;  
bool premier;

for  (int i = 2; count < input; i++)
{
    premier = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            premier = false;
        }       
    }
    if (premier)
    {
        count ++;
        Console.WriteLine(i);
    }
}