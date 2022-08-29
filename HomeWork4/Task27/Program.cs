
/*
Программа, которая принимает на вход число и выдает 
сумму цифр в число. 
452 ==> 11
82 ==> 10
9021 ==> 12
*/

Console.Write("Plase enter number: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);  // проверка на ввод цифр не буквы
if (isNumber != true)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}

int GetSumDigi(int number)
{
    int len = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < len; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}

int sum = GetSumDigi(number);
Console.WriteLine($"Сумма цифр в числе: {sum}");
