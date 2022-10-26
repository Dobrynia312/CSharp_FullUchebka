Console.Write("Vvedite celoe chislo:");
int pervoeChislo = int.Parse(Console.ReadLine()?? "0");
if (pervoeChislo% 2==1)
{
    Console.WriteLine ("Chislo nechetnoe");
}
else
{
   Console.WriteLine ("Chislo chetnoe");
}
