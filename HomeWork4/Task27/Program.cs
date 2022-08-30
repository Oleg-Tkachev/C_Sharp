
/*
Программа, которая принимает на вход число и выдает 
сумму цифр в число. 
452 ==> 11
82 ==> 10
9021 ==> 12
*/

Console.Write("Plase enter number:");
bool isNumber = int.TryParse(Console.ReadLine(), out int num2);  // проверка на ввод цифр не буквы
if (isNumber != true)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}

int GetSumDigi(int num2)
{
    string text = Convert.ToString(num2);  // длина числа путем перевода в строку и методом Length
    int num1 = 0; 
    int result = 0;

    for (int i = 0; i < text.Length; i++)
    {
        num1 = num2 - num2 % 10;
        result = result + (num2 - num1);
        num2 = num2 / 10;
    }
    return result;
}

int sum = GetSumDigi(num2);
Console.WriteLine($"Сумма цифр в числе: {sum}");
