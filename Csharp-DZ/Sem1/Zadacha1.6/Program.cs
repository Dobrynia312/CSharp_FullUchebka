Console.Write("Vvedite  chislo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= Chislo; i++)
{
    if (!(i % 2 == 1))
        Console.Write($" {i}");
}