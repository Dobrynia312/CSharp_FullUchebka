(double count, double proc) Poisk(char[] massiv, char find)
{
    double schet = 0;
    double procen = 0;
    var res = (count: schet, proc: procen);
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] == find)
        {
            schet++;
        }
    }
    res.count = schet;
    res.proc = ((schet / ((massiv.Length)) * 100));
    return res;
}

char[] Dictionary(string str)
{
    str = str.ToLower();
    int count = 1;
    for (int i = 1; i < str.Length; i++)
    {
        for (int j = 0; j < i+1; j++)
        {
            if (str[i] == str[j])
            {
                break;
            }
            else if (j == i-1)
            {
                count += 1;
            }
        }
    }

    char[] dictionary = new char[count];
    int k = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < dictionary.Length; j++)
        {
            if (str[i] == dictionary[j])
            {
                break;
            }
            else if (j == dictionary.Length-1)
            {
                dictionary[k] = str[i];
                k += 1;
            }
        }
    }
    return dictionary;
}
Console.Write("Введите текст: ");
string m = (Console.ReadLine() ?? "0");

char[] simvoli = Dictionary(m);
for (int i = 0; i < simvoli.Length; i++)
{
    var result = Poisk(simvoli, simvoli[i]);
    Console.WriteLine($"Символ {simvoli[i]} встречается {result.count} раз и составляет {result.proc} от строки");
}
