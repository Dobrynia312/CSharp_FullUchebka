Console.Write("Vvedite chislo: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
while (count <= chislo)
{
    /*double res = Math.Pow(count, 3);*/
    int res = count*count*count;
    Console.WriteLine($"{res} куб {count}");
    count++;
}