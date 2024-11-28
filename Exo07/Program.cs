Console.WriteLine("Entrez votre compte bancaire BBAN : ");
String compte = (Console.ReadLine());

if (compte.Length == 12 && long.TryParse(compte, out _))
{

    String part = compte.Substring(10, 2);
    string codeBe = part + part + "111400";

    long codeBe0 = long.Parse(codeBe);
    short modulo = (short)(98 - (codeBe0 % 97));
    
    string moduloo = (modulo<9)? "0" + modulo : modulo + "";

    String bban = "BE" + moduloo + compte;
    Console.WriteLine(bban);
}
else
    Console.WriteLine(" Numéro de compte invalide");