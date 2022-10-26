void FillMassiv(int[,] massiv)
{
    Random El = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = El.Next(1, 5);
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

double Poisk(int[,] massiv, int find)
{   double procent = 0;
    double count = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            
            if (massiv[i, j] == find)
            {
                count++;
            }
            
        }
    }
    return (procent = (count / ((massiv.GetLength(0))*(massiv.GetLength(1)))*100));
}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
FillMassiv(array);
PrintMass(array);
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {         
            double proc = Poisk(array, array[i,j]);
            Console.WriteLine($"Число {array[i,j]} составляет {proc} от массива");
        }
    }
