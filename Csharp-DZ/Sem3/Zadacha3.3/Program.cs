Console.Write("Vvedite числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
int sch = 1;
for (int i=1; i<=Chislo;i++)
{
sch = sch * i;
Console.WriteLine(sch);
}