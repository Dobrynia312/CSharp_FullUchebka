Console.Write("Введите число: ");
int chislo = int.Parse(Console.ReadLine() ?? "0");
int fib1=1;
int fib2=1;
int fib3=1;
while(fib3<chislo)
{
    Console.Write($"{fib3} ");
    fib3=fib1+fib2;
    fib1=fib2;
    fib2=fib3;
}
