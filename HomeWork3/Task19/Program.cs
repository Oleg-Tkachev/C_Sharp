/* 
Программа, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. (зеркально)
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите пятизначное число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number); // ввод данных в number + проверка 

if (isNumber != true)                          // проверка ввода на символы !цифры
{
    Console.WriteLine("Некорректный ввод.");
    return;                                    // стоп программы из-за ввода букв
}

bool CheckPolindrome(int namber)               // проверка на зеркальность 5 значного числа
{
    string text = number.ToString();           // для работы число переводим в текст
    if (text.Length > 5 || text.Length < 5)    // проверка длины 5 цифр
    {
        Console.WriteLine("Некорректная длина данных");
        return false;
    }
    if (text[0] == text[4] && text[1] == text[3])
    {
        return true;
    }
    return false;
}

bool check = CheckPolindrome(number);           // вызов метода
Console.WriteLine(check);                       // вывод результата