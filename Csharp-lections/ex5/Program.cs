Console.WriteLine("Vvedite imia usera!");
string userName = (Console.ReadLine()??"0");
if(userName.ToLower() == "max")
{
    Console.WriteLine("Zdorova chumba, kak dela {0}?", userName);
}
else
{
    Console.WriteLine("Otoidi ot terminala miaso na linuxe");
}

