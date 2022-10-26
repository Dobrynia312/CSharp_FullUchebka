//проверка где расположена точна с координатами х,у
string Kratnost(int x, int y)
{
    string posicia = "0";
    if (x>0 && y>0)
    {posicia = "1 chetvert'";}
    else if (x>0 && y<0)
    {posicia = "4 chetvert'";}
    else if (x<0 && y<0)
    {posicia = "3 chetvert'";}
    else if (x<0 && y>0)
    {posicia = "2 chetvert'";}
    return posicia;
}
Console.Write("Vvedite X:");
int Chislo1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Vvedite Y:");
int Chislo2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(Kratnost(Chislo1,Chislo2));



Console.Write("Vvedite X:");
int X = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Vvedite Y:");
int Y = int.Parse(Console.ReadLine() ?? "0");
if (X > 0)
{
    if (Y > 0) Console.WriteLine("Первая четверть");
    else Console.WriteLine("Четвертая четверть");
}
else
{
    if (Y > 0) Console.WriteLine("Вторая четверть");
    else Console.WriteLine("Третья четверть");
}



Console.WriteLine("Введите координату X");
int x = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите координату Y");
int y = int.Parse(Console.ReadLine()?? "0");

if ((x>0) && (y>0) && (x!=0) && (y!=0)) {
    Console.WriteLine("1 четверть");
} 
else if  ((x<0) && (y>0) && (x!=0) && (y!=0)) {
    Console.WriteLine("2 четверть");
}
else if  ((x<0) && (y<0) && (x!=0) && (y!=0)) {
    Console.WriteLine("3 четверть");
}else if  ((x>0) && (y<0) && (x!=0) && (y!=0)) {
    Console.WriteLine("4 четверть");
}else
{
    Console.WriteLine("Х или Y = 0");
}

