//вывод квадратов от 1 до N
Console.Write("Vvedite chislo: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
while (count <= chislo)
{
    double res = Math.Pow(count, 2);
    Console.WriteLine($"{res} является квадратом {count}");
    count++;
}
