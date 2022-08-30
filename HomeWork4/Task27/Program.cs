
/*
Программа, которая принимает на вход число и выдает 
сумму цифр в число. 
452 ==> 11
82 ==> 10
9021 ==> 12
*/

Console.Write("Plase enter number:");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);  // проверка на ввод цифр не буквы
if (isNumber != true)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}

int GetSumDigi(int number)
{
    string text = Convert.ToString(number);  // длина числа путем перевода в строку и методом Length
    int num1 = 0; 
    int result = 0;

    for (int i = 0; i < text.Length; i++)  //перебераем уже text поочереди
    {
        num1 = number - number % 10;           // К примеру "345" num1 = 345 - 345 % 10 ===> 340
        result = result + (number - num1);     // 0 = 0 + (345 - 340) ===> 5 записали в result
        number = number / 10;                  // 345 = 345 / 10 ===> 34 
    }                                          // далее цикл повторяется до i< text.Length;
    return result;
}

int sum = GetSumDigi(number);
Console.WriteLine($"Сумма цифр в числе: {sum}");
