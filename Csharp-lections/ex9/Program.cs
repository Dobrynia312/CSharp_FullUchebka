int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] numz = { 2, 10, 13, 5, 6, 9, 8, 19, 23 };
numz[4]=156;
Console.WriteLine(numz[4]);
int max = Max(Max(numz[0],numz[1],numz[2]),Max(numz[3],numz[4],numz[5]),Max(numz[6],numz[7],numz[8]));
Console.WriteLine(max);