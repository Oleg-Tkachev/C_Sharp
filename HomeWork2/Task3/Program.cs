
void DayWeek(int day)
{
    switch (day)
    {
        case (1):
            Console.WriteLine("Понедельник");
            break;
        case (2):
            Console.WriteLine("Вторник");
            break;
        case (3):
            Console.WriteLine("Среда");
            break;
        case (4):
            Console.WriteLine("Четверг");
            break;
        case (5):
            Console.WriteLine("Пятница");
            break;
        case (6):
            Console.WriteLine("Суббота - ВЫХОДНОЙ!");
            break;
        case (7):
            Console.WriteLine("Воскресенье - ВЫХОДНОЙ!");
            break;
    }
}

Console.WriteLine("Введите цифру, согласно дню недели: \n1 - Понедельник \n2 - Вторник \n3 - Среда \n4 - Четверг");

Console.WriteLine("Введите цифру, согласно дню недели: 5 - Пятница");
Console.WriteLine("Введите цифру, согласно дню недели: 6 - Суббота");
Console.WriteLine("Введите цифру, согласно дню недели: 7 - Воскресенье");

int day = Convert.ToInt32(Console.ReadLine());
DayWeek(day);

