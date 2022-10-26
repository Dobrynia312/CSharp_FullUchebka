Console.Clear();
Console.Write("Введите растояние между друзьями (в случае нецелых чисел использовать ,) ");
double distance = Convert.ToDouble((Console.ReadLine()??"0"));
Console.Write("Введите скорость первого человека(в случае нецелых чисел использовать ,) ");
double firstPersonSpeed = double.Parse((Console.ReadLine()??"0"));
Console.Write("Введите скорость второго человека (в случае нецелых чисел использовать ,) ");
double secondPersonSpeed = double.Parse((Console.ReadLine()??"0"));
Console.Write("Введите скорость собаки (в случае нецелых чисел использовать ,) ");
double dogSpeed = double.Parse((Console.ReadLine()??"0"));
int Person = 1;
int count = 0;
while (distance > 2)
{
double Time = 0;
if (Person == 1)
{
Time = distance/(firstPersonSpeed+dogSpeed);
Person = 2;
}
else 
{
Time = distance/(secondPersonSpeed+dogSpeed);
Person = 1;
};
distance = distance - (firstPersonSpeed + secondPersonSpeed)*Time;
count++;
}
Console.WriteLine("Собака пробегала {0} раз", count);