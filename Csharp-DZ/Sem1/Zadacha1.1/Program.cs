Console.Write("Vvedite 1 chislo:");
double pervoeChislo = double.Parse(Console.ReadLine()?? "0");
Console.Write("Vvedite 2 chislo:");
double vtoroeChislo = double.Parse(Console.ReadLine()?? "0");
double kvadrat = Math.Pow(vtoroeChislo, 2);
if (pervoeChislo == kvadrat)
{
    Console.WriteLine ("Первое число квадрат второго");
}
else
{
    Console.WriteLine ("Первое число не квадрат второго");
}