(double count, double proc) Poisk(char[] massiv, string str)
{
    double schet = 0;
    double procen = 0;
    var res = (count: schet, proc: procen);
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] == str[i])
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
char[] dict = str.Distinct().ToArray();;
/*for (int i = 0; i < str.Length; i++)
{  dict[i] = str[i];}
for (int i = 0; i < dict.Length; i++)
{
    for (int j = 1; j < dict.Length; j++)
    {
        if (dict[i]==dict[j])
        {
            char temp = dict[j];
            dict[j] = dict[dict.Length-1];
            dict[dict.Length-1] = temp;
        }
    }
    
}
*/
return dict;
}
Console.Write("Введите текст: ");
string m = (Console.ReadLine() ?? "0").ToLower();
char[] simvoli = Dictionary(m);
foreach (var item in simvoli)
{
    System.Console.Write(item+" ");
}

for (int i = 0; i < simvoli.Length; i++)
{
    var result = Poisk(simvoli, m);
    Console.WriteLine($"Символ {simvoli[i]} встречается {result.count} раз и составляет {result.proc} от строки");
}
