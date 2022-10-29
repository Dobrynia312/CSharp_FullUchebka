/*short[] numz = {5,6,10,11,2,3};
foreach (int i in numz)
{System.Console.WriteLine(i);}
int[,] numz2 = {
    {4,3,1},
    {5,2,3},
    {10,12,22},
};
foreach(int z in numz2)
{
System.Console.Write(z%2==0?"+ ":"- ");
}
List<int> numz3 = new List<int>();*/

/*
int[] numz = { 2, 10, 13, 5, 6, 3 };
int n = numz.Length;
for (int i = 0; i < (numz.Length)/2; i++)
{
    int t = numz[i];
    numz[i] = numz[n-1-i];
    numz[n - 1 - i] = t;
}
Console.WriteLine(String.Join(",", numz));*/


/*string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text [i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}
System.Console.WriteLine("Vvedite text");
string oldText = (Console.ReadLine()?? "0");
string newText = Replase(oldText, ' ', '|');
Console.WriteLine(newText);*/
Random random = new Random();
double mantissa = (random.NextDouble() * 2.0) - 1.0;
double exponent = Math.Pow(2.0, random.Next(-126, 128));
double ex = mantissa*exponent;
Console.WriteLine(ex);  

