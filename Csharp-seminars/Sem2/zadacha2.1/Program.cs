//проверка числа на кратность 7 и 23
string Kratnost(int coll)
{
    string posicia = "0";
    if (coll % 7 == 0)
    {
        if (coll % 23 == 0)
        {
            posicia = "Chislo kratno";
        }
        else { posicia = "Chislo ne kratno"; }
    }
    else { posicia = "Chislo ne kratno"; };
    return posicia;
}
Console.Write("Vvedite числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(Kratnost(Chislo));
