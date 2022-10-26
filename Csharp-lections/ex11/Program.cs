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
    int position = 0;
    while (position < count)
    {
        Console.Write($" {collit[position]}");
        position++;
    }
}
int IndexOf(int[] coll, int find)
{
    int count = coll.Length;
    int index = 0;
    int posicia = -1;
    while (index < count)
    {
        if (coll[index] == find)
        {
            posicia = index;
            break;
        }
        index++;
    }
    return posicia;
}
int[] numz = new int[10];
FillnumZ(numz);
PrintNumz(numz);
Console.WriteLine();
int pos = IndexOf(numz, 4);
Console.WriteLine(pos);