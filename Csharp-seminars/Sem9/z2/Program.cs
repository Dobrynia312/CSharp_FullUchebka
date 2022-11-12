//Показать натуральные числа от N до 1, N задано

void VivodChisel(int a)
{
    if(a>=1)
    {
    Console.Write(a+" ");
    VivodChisel(a-1);
    }
}
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()??"0");
VivodChisel(N);