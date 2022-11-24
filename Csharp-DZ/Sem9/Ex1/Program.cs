// Показать натуральные числа от M до N, N и M заданы
void VivodChisel(int a, int b)
{
    if (a <= b)
    {
        Console.Write(a + " ");
        VivodChisel(a + 1, b);
    }
};
void VivodChisel2(int a, int b)
{
    if (a >= b)
    {
        Console.Write(a + " ");
        VivodChisel2(a - 1, b);
    }
};

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
if(M>N)VivodChisel2(M,N);
else if(N>M)VivodChisel(M,N);