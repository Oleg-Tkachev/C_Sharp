
/* 
Программа, которая выводит случайное число из отрезка
[10, 99] и показывает набольшую цифру числа
78 => 8
12 => 2
87 => 8
*/

Random random = new Random();           //генерация случайного числа
int randomNum = random.Next(10, 100);   // предел рандомных чисел 10 - 99
int digi1 = randomNum / 10;             // получаем первую цифру 
int digi2 = randomNum % 10;             // получаем вторую цифру 
Console.WriteLine($"Рандомное число: {randomNum}");
if (digi1 > digi2)
    {
    Console.WriteLine($"Наибольшая цифра {digi1}");
    }
else 
    {
    Console.WriteLine($"Наибольшая цифра {digi2}"); //интерполяция
    }

//////////////////// Через метод!  ////////////////////////////////

Random random = new Random();           
int randomNum = random.Next(10, 100);   
Console.WriteLine($"Рандомное число: {randomNum}");

int GetMaxNumber (int number)
{
    int digi1 = randomNum / 10;
    int digi2 = randomNum % 10;
if (digi1 > digi2)
    {
    return digi1;
    }
else 
    {
    return digi2;
    }
}

int result = GetMaxNumber(randomNum);
Console.WriteLine($"Наибольшая цифра в числе: {result}");




///////////////////////////////////////////////////////////////////////////
/* 
Программа, которая выводит случайное трехзначное число и 
удаляет вторую цифру этого числа.
456 => 46
782 => 72
*/

Random random = new Random();
int randomNumber = random.Next(100, 1000);

int secondDigi = (randomNumber / 10)%10;
Console.WriteLine($"Случайное число: {randomNumber}");
Console.WriteLine($"Вторая цифра: {secondDigi}");



///////////////////////////////////////////////////////////////////////////
/* 
Программа, которая на вход принимает два числа и выводит
является ли второе число кратным первому. Если, число 2 не кратно числу 1,
то программа выводит остаток от деления. 
34, 5 => не кратно, остаток 4
16, 4 => кратно 
*/

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1 % num2;
if (num1 % num2 == 0)
    {
    Console.WriteLine("Кратно");
    }
else
    {
    Console.WriteLine($"Не кратно, остаток {result}");
    }


///////////////////////////////////////////////////////////////////////////

/* 
Программа, которая проверяет введенное число на кратность двум
введенным числам из консоли. Выводит результат. 
55 => 5, 11 = кратно 
10 => 2, 5 = кратно
44 => 4, 10 = не кратно 
*/

// Решение через метод с вводом трех данных (number, firstDivide, secondDivide)
///////////////////////////////////////////////////////////////////////////////


bool CheckNumber(int number, int firstDivide, int secondDivide)
{
    if (number % firstDivide == 0 && number % secondDivide == 0)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первый делитель: ");
int firstDivide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй делитель: ");
int secondDivide = Convert.ToInt32(Console.ReadLine());

bool check = CheckNumber(number, firstDivide, secondDivide);
Console.WriteLine(check);
 
////////////////////////////////////////////////////////////////////////////