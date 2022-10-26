//подсчетн количества цифр в числе
Console.Write("Vvedite числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
    while (Chislo / 10 != 0)
    {
        Chislo = Chislo / 10;
        count++;
    }
Console.WriteLine(count);
