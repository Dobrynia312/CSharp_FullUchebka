Console.Write("Vvedite 1 chislo:");
double pervoeChislo = double.Parse(Console.ReadLine()?? "0");
Console.Write("Vvedite 2 chislo:");
double vtoroeChislo = double.Parse(Console.ReadLine()?? "0");
Console.Write("Vvedite 3 chislo:");
double tretieChislo = double.Parse(Console.ReadLine()?? "0");

Console.WriteLine (Math.Max(pervoeChislo, Math.Max(vtoroeChislo, tretieChislo)));
