Console.Write("Vvedite трёхзначное числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");
string str = Chislo.ToString();
Console.WriteLine(str[2]);