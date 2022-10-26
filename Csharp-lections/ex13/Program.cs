//vid 1
void Method1()
{
    Console.WriteLine("autor DMV");
}

Method1();

//vid2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "DMV made this");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method21("DMV2 made this", 4);
Method21(count: 4, msg: "DMV21 made this");

//vid3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

//vid4
string Method4 (int arg1, string arg2)
{
string res = String.Empty;
for (int i =0; i<arg1;i++)
{
    res = res + arg2;
}
return res;
}
string res2 = Method4(10, "Der");
System.Console.WriteLine(res2);

