Console.WriteLine(" Entrez le premier numéro : ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine(" Entrez le second numéro : ");
int secondNumber = int.Parse(Console.ReadLine());

double division = (double)firstNumber /secondNumber;
int modulo =firstNumber % secondNumber;
int entiere = firstNumber / secondNumber;

Console.WriteLine($" Division entière : {entiere}");
Console.WriteLine($" Modulo : {modulo}");
Console.WriteLine($" Division : {division}");