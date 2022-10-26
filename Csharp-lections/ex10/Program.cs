int[] numz = { 1, 2, 3, 4, 1, 6, 7, 8 };
int n = numz.Length;
int find = int.Parse(Console.ReadLine() ?? "0");
int index = 0;
while (index < n)
{
    if (numz[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}