int numberA = new Random().Next(1, 100);//1 2 3 4...7
Console.WriteLine($"Chislo {numberA}");
int vtoroechislo = (numberA % 10);
int pervoechislo = (numberA / 10);
Console.WriteLine($"pervoe chislo {pervoechislo}, vtoroe chislo {vtoroechislo}");
Console.WriteLine("Max: " + Math.Max(pervoechislo, vtoroechislo));