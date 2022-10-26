//создание и вывод массива
void FillnumZ(int[] coll)
{
    int n = coll.Length;
    int index = 0;
    Random ruk = new Random();
    while (index < n)
    {
        coll[index] = ruk.Next(1, 10);
        index++;
    }
}
void PrintNumz(int[] collit)
{
    int count = collit.Length;
    foreach (int item in collit)
    {
        Console.Write($" {item}");
    }
}
int[] numz = new int[8];
FillnumZ(numz);
PrintNumz(numz);
Console.WriteLine();

/*while (position < count)
   {
       Console.Write($" {collit[position]}");
       position++;
   }*/