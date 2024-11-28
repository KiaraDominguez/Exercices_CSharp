Console.WriteLine("Entrez nombre 1 : ");
string number_1 = Console.ReadLine();
Console.WriteLine("Entrez nombre 2 : ");
string number_2 =  Console.ReadLine();

int numberInt1 = int.Parse(number_1);
int  numberInt2 = int.Parse(number_2);

int result = numberInt1 + numberInt2;

Console.WriteLine($" L'addition de {number_1} et de {number_2} est égal à {result}");

// ou , mais mauvaise car on ne peux pas réutiliser les valeurs

Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));