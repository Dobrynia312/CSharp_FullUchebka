﻿Console.Write("Vvedite числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
int res = 0;
while (Chislo / 10 != 0 || Chislo % 10 != 0)
{
    res = res + (Chislo % 10);
    Chislo = Chislo / 10;
}
if (res < 0) res=res*-1;
Console.WriteLine($"Summa chisel {res}");