int f = 0;
int g = f + 1;

int resultat = 0;

for  (int i = 25; i > 0; i--)
{
    resultat = f + g;
    f = resultat ;
    g= f-g;

}

Console.WriteLine(resultat);