/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка

*/
Console.Write("Введите количество строк массива: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов массива: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
{
    Console.WriteLine("Invalid number");
    return;
}


int[,] result = CreateRandomArray(m, n);         // получаем рандомный массив с размерами m и n
Print2DArray(result);                            // печатаем массив для наглядности
MinSumInString(result);


void Print2DArray(int[,] array)                  // метод печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int m, int n)       // метод создания рандомного массива
{
    int[,] array = new int[m, n];

    Random random = new Random();
    Console.WriteLine("Массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);         //задаем массив от 0 до 9
        }
    }

    return array;
}

void MinSumInString(int[,] array)  // находим мин сумму в строках
{

    
    int [] sumI = new int [array.GetLength(0)];


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumI [i] += array[i, j];
        }
    }
    
    int sum = sumI[0];
    int indexLine = 0;

    for (int i = 1; i < array.GetLength(0); i++)
    {

        if (sum > sumI[i])
        {
            sum = sumI[i];
            indexLine = i;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой всех элементов №: {indexLine + 1}");
    Console.WriteLine($"Суммой элементов этой строки: {sum}");

}

