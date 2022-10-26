Console.Write("Vvedite 1 chislo:");
double pervoeChislo = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Vvedite 2 chislo:");
double vtoroeChislo = double.Parse(Console.ReadLine() ?? "0");
double ostatok = (pervoeChislo % vtoroeChislo);
if (  pervoeChislo % vtoroeChislo == 0)
{
    Console.WriteLine("Chislo cratno");
}
else
{
    Console.WriteLine($"Ostatok ot delenia {ostatok}");
}