Console.Write("Введите число: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
double result = 0;
int i = 0;
while (chislo != 0)
{
    result = result + (chislo % 2 * Math.Pow(10, i));
    chislo = chislo / 2;
    i++;
}
Console.WriteLine(result);