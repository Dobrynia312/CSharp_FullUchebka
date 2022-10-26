/*Console.Write("Vvedite трёхзначное числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
string str = Chislo.ToString();
int d = str.Length;
if (d < 3)
{
    Console.Write("Chisla net");
}
else 
{
Console.WriteLine(str[2]);
}
*/
/**/
Console.Write("Vvedite числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");

if (Chislo / 100 != 0)
{
    while (Chislo / 100 >= 10)
    {
        Chislo = Chislo / 10;
        Console.WriteLine(Chislo);
    }
    Console.WriteLine(Chislo % 10);

}
else
{
    Console.WriteLine("Chisla net");
}
