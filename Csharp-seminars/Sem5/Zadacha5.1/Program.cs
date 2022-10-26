//являются ли три числа сторонами треугольника
Console.Write("Введите первое число: ");
int chislo1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int chislo2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите третье число: ");
int chislo3 = int.Parse(Console.ReadLine() ?? "0");
Console.Write((chislo1+chislo2>chislo3 && chislo1+chislo3>chislo2 && chislo2+chislo3>chislo1)? "Числа являются сторонами треугольника" : "Числа не являются сторонами треугольника");