Console.Write("Vvedite chislo:");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int a = (chislo/10000);
int b = ((chislo%10000)/1000);
int c = (((chislo%10000)%1000)/100);
int d = ((((chislo%10000)%1000)%100)/10);
int e = ((((chislo/10000)%1000)%100)%10);
int obratnoechislo=(e*10000+d*1000+c*100+b*10+a);
Console.Write(obratnoechislo==chislo ? "Polinom": "Ne Polinom");
/*
if (obratnoechislo==chislo) Console.WriteLine("Polinom");
else Console.WriteLine("Ne Polinom");
*/
