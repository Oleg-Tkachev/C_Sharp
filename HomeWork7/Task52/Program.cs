/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите количество строк массива: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
if (!isNumberM)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}

Console.Write("Введите количество столбцов массива: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberN)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}


int[,] result = CreatingRandomArray(m, n);  // передаем в переменную result 2D массив размерами [m, n]
Print2D_ArrayToConsole(result);             // печатаем массив в консоль 
AveragInColumn(result);                     // считаем данные по условию задвчи


int[,] CreatingRandomArray(int m, int n)    // метод, создаем 2D массив с числами от 1 до 9
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
    return array;
}

void Print2D_ArrayToConsole(int[,] array)           // метод, печать массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void AveragInColumn(int[,] array)                      // метод, принимаем 2D массив + условие задачи
{
    Console.WriteLine("Cреднее арифметическое: ");
    for (int i = 0; i < n; i++)
    {
        double averagInColumn = 0;
        for (int j = 0; j < m; j++)
        {
            averagInColumn = averagInColumn + result[j, i];      //если, поменять j и i местами - считает строки (условие m == n)
        }
        averagInColumn = Math.Round(averagInColumn / m, 1);      // округляем расчет до 1 цифры после запятой (как в примере)
        Console.WriteLine($"столбца {i + 1} = {averagInColumn}");
    }
}