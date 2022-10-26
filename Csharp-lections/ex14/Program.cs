//таблица умножения

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i * j}");
    }
    Console.WriteLine();
}
*/

//замена текста
string Replase(string text, char oldValue, char newValue)
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
string newText2 = Replase(newText, 'к', 'К');
Console.WriteLine(newText2);