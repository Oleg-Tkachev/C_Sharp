

// int ConvertInt(int x, int lenght)
// {
//     int x2=0;
//     for(int i=0;i<lenght; i++)
//     {
//         x2=x2+x%10*(int)Math.Pow(10,lenght -i-1);
//         x=x/10;
//     }
//     return x2;
// }

/////////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

/*
Программа, которая на вход принимает  число и выдает кол-во цифер в числе
456 ==> 3
89263 ==> 5
*/


Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()); // проверка на ввод числа не цифры

int CountDigi(int number)
{
    int count = 0;
    int temp = number;
    if (temp == 0)
    {
        return 1;
    }
    while (temp != 0)
    {
        temp = temp / 10;
        count++;
    }
    return count;
}

Console.WriteLine($"Количество чисел: {CountDigi(number)}");


//////////////////////////////////////////////////////////////////////////////////////////////

/*
Программа, которая на вход принимает число N и выдает
произведение чисел от 1 до N
*/

Console.WriteLine("Write number: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (isNumber == false || number < 1)              // проверка на ввод цифры и значения number < 0 
    { 
    Console.WriteLine("Wrong number "); return;   // остановка программы при не соблюдении условия
    }

int Multiply(int number)
{
    int result = 1;                     // result = 1 т.к. на 0 нет смысла умножать. 
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine($"Произведение numbers is: {Multiply(number)}");



//////////////////////////////////////////////////////////////////////////////////


/*
программа, которая выводит массив низ 8 элементов, заполненный нулями 
и единицами в случайном порядке
[1, 0, 1, 1, 1, 0, 1, 1]
*/

Console.WriteLine("Введите размер массива number");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);
if (isNumber == false || number != 8)  // ограничение длины массива в 8 цифр
{
    Console.WriteLine("Неверный ввод");
    return;
}

int[] PassArr(int n)
{
    int[] newArray = new int[n];    //инициализация массива длиной n элементов
    for (int i = 0; i < n; i++)
    {
        newArray[i] = new Random().Next(0, 2);  // заполняем массив рандомно 0 и 1
    }
    return newArray;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

PrintArr(PassArr(number));
