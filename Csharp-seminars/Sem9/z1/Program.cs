//вывести натуральные числа от 1 до N
void VivodChisel(int a, int b)
{
    if(a<=b)
    {
    Console.Write(a+" ");
    VivodChisel(a+1,b);
    }
}
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()??"0");
VivodChisel(1,N);