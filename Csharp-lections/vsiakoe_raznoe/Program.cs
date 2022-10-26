//задача с собакой
/*int distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int friend = 2;
int time = 0;
int count = 0;
while (distance > 10)
{
    if (friend == 2)
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 1;
    }
    else
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 2;
    }
    distance = distance - (first_friend_speed + second_friend_speed) * time;
    count++;
}
Console.WriteLine(count);*/

//сумма среднеарифметическая всех чисел массива
/*int[] numbers = { 2, 5, 13, 7, 6, 4 };
int size = numbers.Length;
int sum = 0;
int avg = 0;
int index = 0;
while (index < size)
{
    sum = sum + numbers[index];
    index++;
}
avg = sum / size;
Console.WriteLine(avg);*/

//сумма произведения двух массивов
/*int[] nums1 = { 2, 10, 13, 5, 6 };
int[] nums2 = { 9, 1, 3, 5, 4 };
int size = nums1.Length;
int sum = 0;
int index;
for (index = 0; index < size; index++) 
{ sum = sum + (nums1[index] * nums2[index]); };
Console.WriteLine(sum);*/

//поиск положительного числа
/*int[] numz = { 2, -10, 13, -5, 6, -3 };
int i = 0;
int k = 0;
for (i= 0; i < numz.Length; i++)
{
    if (numz[i] > 0) { k++; }
}
Console.WriteLine(k);*/

//поиск разворот
/*int[] numz = { 2, 10, 13, 5, 6, 3 };
int n = numz.Length;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n-1-i; j++)
    {
        if (numz[j] > numz[j + 1])
        {
            int t = numz[j];
            numz[j] = numz[j + 1];
            numz[j + 1] = t;
        }
    }
}
Console.WriteLine(String.Join(",", numz));*/

//разворот массива
/*int[] numz = { 2, 10, 13, 5, 6, 3 };
int n = numz.Length;
for (int i = 0; i < (numz.Length)/2; i++)
{
    int t = numz[i];
    numz[i] = numz[n-1-i];
    numz[n - 1 - i] = t;
}
Console.WriteLine(String.Join(",", numz));*/

//сумма между большим и малым
/*int[] numz = { 15, 1, 22, 3, 5, 0 };
int i = 0, max = 0, min = 0, t = 0, 
l = 0, sum = 0, posN = 0, posM = 0;
for (i = 0; i < numz.Length; i++)
{
    if (numz[i] > max)
    {
        max = numz[i];
        t = i;
    }
    else
    {
        min = numz[i];
        l = i;
    }
}
    if (t > l)
    {
        posN = t;
        posM = l;
    };
    if (l > t)
    {
        posN = l;
        posM = t;
    };
for (i=posM+1; i<posN;i++)
{ sum = sum + numz[i]; };
Console.WriteLine(sum);
*/

/*Console.Write("Vvedite chislo a:");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Vvedite chislo b:");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Vvedite chislo c:");
int c = int.Parse(Console.ReadLine() ?? "0");
int count = 0;

//поиск максимального из двух
if (a > b)
{
    Console.Write("max = {0}:", a);
}
else { Console.Write("max = {0}:", b); }

//поиск максимального из трёх
if (a > b)
{
    if (a > c) { Console.Write("max = {0}:", a); }
    else { Console.Write("max = {0}:", c); }
}
else
{
    if (b > c) { Console.Write("max = {0}:", b); }
    else { Console.WriteLine("max = {0}:", c); }
}

//проверка на четность
if (a % 2 == 0) Console.WriteLine(" число {0} чётное", a);
if (b % 2 != 1) Console.WriteLine(" число {0} чётное", b);
if (c % 2 == 0) Console.WriteLine(" число {0} чётное", c);

//вывод чисел
while (count <= a)
{
    if (count % 2 == 0){Console.WriteLine(count);}
    count++;
};
*/

/*
//поиск и вывод 2 и 3 числа
Console.Write("Vvedite числo:");
int Chislo = int.Parse(Console.ReadLine() ?? "0");

if (Chislo / 100 != 0)
{
    while (Chislo / 100 >= 10)
    {
        Chislo = Chislo / 10;
        Console.WriteLine(Chislo);
    }
    Console.WriteLine(Chislo % 10);
    Console.WriteLine(((Chislo%100)/ 10));

}
else
{
    Console.WriteLine("Chisla net");
}
*/

/*
Random znach = new Random();
int[] numz = { 15, 13, 11, 12, 19, 16, 15, 11} new int [10];
int k = 2;
for (byte index = 0; index < numz.Length; index++)
{
    /*numz[index] = znach.Next(-5, 7);
    System.Console.Write($" {numz[index]}");
}
int ind1 = 0, ind2 = (numz.Length - 1);
int sum = numz[ind1] + numz[ind2];
while (ind1 < ind2 || sum != k)
{
    sum = numz[ind1] + numz[ind2];
    System.Console.WriteLine(" S" + sum);
    if (sum == k) 
    {
        Console.WriteLine($"{numz[ind1]} {numz[ind2]}");
        break;}
    else
    { if (sum < k)
    {
        k++;
        ind1=0;
        ind2=(numz.Length - 1);
    }
    else if (sum > k)
    {
        k--;
        ind1=0;
        ind2=(numz.Length - 1);
    }}
    ind1++;
    ind2--;}
    */

