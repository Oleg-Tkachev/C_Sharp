/*
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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
Print2DArray(SortDescendingInString(result));    // печатаем сортированный массив 


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
    Console.WriteLine("Массив до сортировки: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);  //задаем массив от 0 до 9
        }
    }

    return array;
}


int[,] SortDescendingInString (int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1) - 1; k++)  
            {
                if (array1[i, k] < array1[i, k + 1])
                {
                    int temp = array1[i, k + 1];          // меняем элементы через временную temp
                    array1[i, k + 1] = array1[i, k];
                    array1[i, k] = temp;
                }
            }
        }
    }
    Console.WriteLine();                                  // для разделения массивов (сливаются)
    Console.WriteLine("Массив после сортировки:");
    return array1;
}
