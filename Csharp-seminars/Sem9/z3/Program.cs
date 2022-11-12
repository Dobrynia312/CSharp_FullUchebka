// Найти сумму цифр числа
int SummaCifr(int a)
{
    if (a == 0) return 0;
    return a % 10 + SummaCifr(a / 10);

}
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int res = SummaCifr(N);
System.Console.WriteLine($"Сумма цифр {N} = {res}");
