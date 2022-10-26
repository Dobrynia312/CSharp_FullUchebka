Console.WriteLine("Введите номер дня недели, напоминаю их 7");
int DenNedeli = int.Parse(Console.ReadLine() ?? "0");
if (DenNedeli <= 7)
    switch (DenNedeli)
    {
        case 1:
            Console.WriteLine("Понедельник, работа работа никакого безделья бедняга джек не знает веселья");
            break;
        case 2:
            Console.WriteLine("Вторник, работа работа никакого безделья бедняга джек не знает веселья");
            break;
        case 3:
            Console.WriteLine("Среда, работа работа никакого безделья бедняга джек не знает веселья");
            break;
        case 4:
            Console.WriteLine("Четверг, работа работа никакого безделья бедняга джек не знает веселья");
            break;
        case 5:
            Console.WriteLine("Пятница, работа работа никакого безделья бедняга джек не знает веселья");
            break;
        case 6:
            Console.WriteLine("Суббота, ей, это выходной");
            break;
        case 7:
            Console.WriteLine("Воскресенье, ей, это выходной");
            break;
    }
else
{
    Console.WriteLine("Введен неправильный номер дня недели, напоминаю их 7");
}