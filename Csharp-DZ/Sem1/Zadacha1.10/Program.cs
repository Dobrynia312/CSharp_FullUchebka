Console.Write("Vvedite трёхзначное числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
int tretiechislo = ((Chislo % 100) % 10);
int vtoroechislo = ((Chislo % 100) / 10);
int pervoechislo = (Chislo / 100);
int res = (pervoechislo * 10) + tretiechislo;
Console.WriteLine($"pervoe chislo {pervoechislo}, vtoroe chislo {vtoroechislo}, tretie chislo {tretiechislo}");
Console.WriteLine($"{pervoechislo}{tretiechislo}");
Console.WriteLine(res);