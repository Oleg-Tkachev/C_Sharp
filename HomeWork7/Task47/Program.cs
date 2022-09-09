/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
if (!isNumberM)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}

Console.WriteLine("Введите количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberN)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}


double[,] result = CreatingRandomArray(m, n);
Print2D_ArrayToConsole(result);


double[,] CreatingRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;  
        }
    }
    return array;
}


void Print2D_ArrayToConsole(double[,] array)
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