
Carte[] cartes = new Carte[52];

Valeurs valeurs;
Couleurs couleurs;

int indexVal = 2;
int indexCol = 0;
int index = 0;


foreach (Carte carte in cartes)
{

    cartes[index].couleur = (Couleurs)indexCol ;
    cartes[index].valeur = (Valeurs)indexVal;


    if (indexCol < 3)
    {
        indexCol++;
    }
    else
    {
        indexCol = 0;
        indexVal++;
    }

    if(indexVal > 14) 
    {
        indexVal = 2;
    }


    Console.Write(cartes[index].couleur);
    Console.WriteLine($" {cartes[index].valeur}");
    index++;

}



public enum Couleurs { Coeur, Carreau, Pique, Trefle}

public enum Valeurs { As=14, Deux=2 , Trois=3, Quatre=4, Cinq=5, Six=6,Sept=7,Huit=8,Neuf=9,Dix=10,Valet=11,Dame=12,Roi=13 }

public struct Carte
{
    public Couleurs couleur;
    public Valeurs valeur;
}