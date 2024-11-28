Console.WriteLine(" Entrez votre nom : ");
string username = Console.ReadLine();

Console.WriteLine(" Entrez nombre 1 : ");
string number_1 = Console.ReadLine();
Console.WriteLine(" Entrez nombre 2 : ");
string number_2 = Console.ReadLine();

Console.WriteLine($" {username}, Le premier nombre est : {number_1} , le second est {number_2}");

Console.WriteLine("Abracadabra!!");

string temp = number_1;
number_1 = number_2;
number_2 = temp;

Console.WriteLine($" {username}, Le premier nombre est : {number_1} , le second est {number_2}");

