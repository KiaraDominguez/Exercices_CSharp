point? [,] tableau = new point? [5,5];

point one;
one.x = 1;
one.y = 1;
tableau[0,0] =one;

point two;
two.x = 2;
two.y = 2;
tableau[1, 1] = two;

point three;
three.x = 3;
three.y = 3;
tableau[2, 2] = three;

point four;
four.x = 4;
four.y = 4;
tableau[3, 3] = four;

point five;
five.x = 5;
five.y = 5;
tableau[4, 4] = five;


for (int i = 0; i < 5; i++)
{

    for (int j = 0; j < 5; j++)
    {
        if (!(tableau[i, j] is null))
        {
            Console.Write($"X : {((point)tableau[i, j]).x} - Y : {((point)tableau[i, j]).y} ");
        }
        else
            Console.Write("\t");
    }
    Console.WriteLine();
}

public struct point
{
    public int x, y;
} 