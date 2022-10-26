
void PrintMass(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($" -{array[i,j]}- ");
    }
    Console.WriteLine();
}
}

void FillMass(int[,] coll)
{
       for (int i=0;i<coll.GetLength(0);i++)
{
    for (int j = 0; j < coll.GetLength(1); j++)
    {
        coll[i,j]=new Random().Next(1,10);
    }
    Console.WriteLine();
}
}

int[,] matris = new int [5,8];

PrintMass(matris);
FillMass(matris);
PrintMass(matris);