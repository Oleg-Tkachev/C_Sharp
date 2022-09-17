/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

Console.Write("Введите размерность квадратного массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int size);

if (!isNumber)
{
    Console.WriteLine("Invalid number");
    return;
}

int[,] sqareArray = new int[size, size];         // создаем массив квадрат size * size
int start = 0;                                   // старт от 0 до ++ 
int i = 0;
int j = 0;

while (start < Math.Pow(size, 2))                // квадрат размера для заполнения
{
    sqareArray[i, j] = start;
    start++;
    if (i <= j + 1 && i + j < sqareArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

Print2DArray(sqareArray);                         // в печать

void Print2DArray(int[,] array)                   // метод печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();                           // переход на новую строку
    }
}


