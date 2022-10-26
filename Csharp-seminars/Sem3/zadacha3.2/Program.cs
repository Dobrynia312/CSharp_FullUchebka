//сумма чисел от 1 до N
Console.Write("Vvedite chislo: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
int summ = 0;
while (count <= chislo)
{
    summ = summ + count;
    count++;
}
Console.WriteLine($"Summa chisel {summ}");