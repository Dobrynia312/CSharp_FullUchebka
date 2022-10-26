Console.Write("Vvedite числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
int Kub_Chisla;
for (int i=1; i<=Chislo;i++)
{
Kub_Chisla = i*i*i;
if ((Kub_Chisla%10)%2==0) Console.Write($"{Kub_Chisla} ");
};