Console.WriteLine("Entrez votre compte bancaire BBAN : ");
String compte = (Console.ReadLine());

if (compte.Length == 12)
{
    String partOne = compte.Substring(0, 10);
    String partTwo = compte.Substring(10, 2);

    long part1;
    bool isOkay = long.TryParse(partOne, out part1);
    if (isOkay)
    {
        {
            long part2;
            bool isOkay2 = long.TryParse(partTwo, out part2);
            if (isOkay2)
            {

                if ((part1 % 97) == part2)
                    Console.WriteLine("OK");
                else if (((part1 % 97) == 0) && part2 == 97)
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("KO");
            }
        }
    
    }

}
else { Console.WriteLine("Numéro de compte invalide"); }