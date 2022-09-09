/*
Программа, которая на вход принимает число и ищет в двумерном массиве,
и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:         Массив задавать рандомно. 
1 4 7 2
5 9 2 3
8 4 2 4
7 -> 0 , 2
5 -> 1 , 0
18 -> нет такого элемента
*/


Console.WriteLine("Введите искомое число от 1 до 100: ");
bool isNumberX = int.TryParse(Console.ReadLine(), out int x);
if (!isNumberX)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}

Console.WriteLine("Введите количество строк массива: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
if (!isNumberM)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}

Console.WriteLine("Введите количество столбцов массива: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberN)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}


int[,] result = CreatingRandomArray(m, n);
Print2D_ArrayToConsole(result);
DetectingNumberInArray(result);


int[,] CreatingRandomArray(int m, int n)
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


void Print2D_ArrayToConsole(int[,] array)
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


void DetectingNumberInArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == x)
            {
                Console.WriteLine($"Индекс числа {x} = [{i}, {j}]");
            }
        }
    } 
    //Console.WriteLine("Такой цифры нет :-( ");
}