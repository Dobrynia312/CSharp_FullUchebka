// В матрице чисел найти сумму элементов главной диагонали
void FillMassiv(int[,] massiv)
{
    Random El = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = El.Next(-9, 10);
        }
    }
}
void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int diagSum(int[,] massiv)
{
    int sum = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        sum += massiv[i, i];
    }
    return sum;
}
Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
FillMassiv(array);
PrintMass(array);
int diagSumma = diagSum(array);
Console.WriteLine($"Сумма главной диагонали равна:{diagSumma}");

