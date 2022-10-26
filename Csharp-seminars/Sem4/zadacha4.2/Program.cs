//создание и вывод массива с противоположными значениями от первоначального массива
void FillnumZ(int[] coll)
{
    int n = coll.Length;
    int index = 0;
    Random ruk = new Random();
    while (index < n)
    {
        coll[index] = ruk.Next(-100, 100);
        index++;
    }
}
void FillnumZ2(int[] coll)
{
    int n = coll.Length;
    int index = 0;
    Random ruk = new Random();
    while (index < n)
    {
        coll[index] = (coll[index] *-1);
        index++;
    }
}
void PrintNumz(int[] collit)
{
    int count = collit.Length;
    int position = 0;
    foreach (int item in collit)
    {
        Console.Write($" {collit[position]}");
        position++;
    }
}
int[] numz = new int[8];
FillnumZ(numz);
PrintNumz(numz);
Console.WriteLine();
FillnumZ2(numz);
PrintNumz(numz);
Console.WriteLine();