//возведение числа в степень
Console.Write("Vvedite chislo: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Vvedite stepen': ");
int stepen = int.Parse(Console.ReadLine() ?? "0");
int res = 1;
for (int i = 0; i < stepen; i++)
{
   res = res * chislo;
}
Console.WriteLine(res);