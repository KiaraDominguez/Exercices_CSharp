Tamagochi pet = new Tamagochi();

Console.WriteLine("Entrez le nom de votre Tamagochi : ");
pet.name = Console.ReadLine();

pet.Reset(pet.name);
Console.Clear();

Console.WriteLine($" Ton Tamogochi porte le merveilleux nom de : {pet.name} ");
Console.WriteLine($"{pet.name} à : \t {pet.age} jours \t {pet.santer} coeurs \t {pet.bonheur} étoiles ");
Console.WriteLine();
Console.WriteLine($"Il te reste {pet.action} actions avant la fin de la journée");
Console.WriteLine();
Console.WriteLine(" Tape : [a] Pour lui donner un snack \t [z] Pour lui donner un repas \t [e] Pour jouer avec lui/elle \t [r] Pour partir en longue balade");
string input = Console.ReadLine();

switch (input)
{
    case "a":
        
        pet.Manger(1);
        break;

    case "z":
        pet.Manger(2);
        break;

    case "e":
        pet.Jouer(1);
        break;

    case "r":
        pet.Jouer(2);
        break;

    }



public struct Tamagochi
{
    public string name;
    public int age, santer,bonheur,action;

    public void Reset(string petName)
    {
        name = petName;
        age = 0;
        santer = 0;
        bonheur = 0;
        action = 3;
    }

    public void Manger(int x)
    {
        action-=1;

        if (x == 1) santer += 1;
        else if (x == 2)
        {
            santer += 2;
            bonheur -= 1;
        }

        if (action == 0)
        {
            Vieillir();
        }
    }

    public void Jouer(int x)
    {
        action -= 1;

        if (x == 1) bonheur += 1;
        else if (x == 2)
        {
            bonheur += 3;
            santer-= 1;
            action -= 1;
        }
        if (action == 0)
        {
            Vieillir();
        }
    }

    public void Vieillir()
    {
        age += 1;
        action = 3;
        santer -= 2;
        bonheur -= 2;
    }

}