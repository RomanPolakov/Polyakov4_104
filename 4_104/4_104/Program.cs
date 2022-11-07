Console.WriteLine("Введите число дня недели");

int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine(week.Понедельник);
        break;
    case 2:
        Console.WriteLine(week.Вторник);
        break;
    case 3:
        Console.WriteLine(week.Среда);
        break;
    case 4:
        Console.WriteLine(week.Четверг);
        break;
    case 5:
        Console.WriteLine(week.Пятница);
        break;
    case 6:
        Console.WriteLine(week.Суббота);
        break;
    case 7:
        Console.WriteLine(week.Вокресенье);
        break;
    default:
        Console.WriteLine("Нет такого дня");
        break;
}

enum week
{
    Понедельник,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Вокресенье
}