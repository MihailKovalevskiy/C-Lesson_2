// Задача №15

Console.WriteLine("Введите день недели");
uint day = Convert.ToUInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("working");
        break;
    case 2:
        Console.WriteLine("working");
        break;
    case 3:
        Console.WriteLine("working");
        break;
    case 4:
        Console.WriteLine("working");
        break;
    case 5:
        Console.WriteLine("working");
        break;
    case 6:
        Console.WriteLine("day off");
        break;
    case 7:
        Console.WriteLine("day off");
        break;
    default:
        Console.WriteLine("No day");
        break;
}
