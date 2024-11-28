
SecondDegre number;
number.a = 4;
number.b = 4;
number.c = 1;

double x1;
double x2;

if(number.Resoudre(out x1, out x2))
{
    if (x1 == x2)
    {
    Console.WriteLine($"L'équation possible , il existe 1 valeur possible : {x1}");
    }
   
    else if (x2 != x1)
    {
        Console.WriteLine($"L'équation possible , il existe 2 valeurs possible : {x1} et {x2}");
    }
}
else
{
    Console.WriteLine("L'équation est impossible");
}


public struct SecondDegre
{
    public double a , b, c ;

    public bool Resoudre (out double x1, out double x2)
    {
        double delta = (int)(b * b) - (4 * a * c);
        
        if (delta == 0)
        {
            x1 = -b/(2*a);
            x2 = x1;
            return true;
        }
        else if (delta > 0)
        {
            x1 = (-b - Math.Sqrt(delta))/(2*a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            return true;
        }
        else
        {
            x1 = default;
            x2 = default;
            return false;
        }
    }
}