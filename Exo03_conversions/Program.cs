Console.WriteLine("Entrez nombre 1 : ");
string number_1 = Console.ReadLine();
int numberInt1;
bool itsOkay = int.TryParse(number_1, out numberInt1);

Console.WriteLine("Entrez nombre 1 : ");

int.TryParse(Console.ReadLine(), out int numberInt2);

int result = numberInt1 + numberInt2;

Console.WriteLine($" L'addition de {number_1} et de {numberInt2} est égal à {result}");