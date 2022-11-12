// Написать программу возведения числа А в целую стень B

int VozStep(int a, int b)
{
    return b == 0 ? 1 : VozStep(a, b - 1) * a;
}

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(VozStep(A, B));