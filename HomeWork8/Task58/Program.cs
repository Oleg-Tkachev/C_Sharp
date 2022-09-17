/*
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

Console.Write("Создадим две матрицы, задайте количество строк: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Создадим две матрицы, задайте количество столбцов: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
{
    Console.WriteLine("Invalid number");
    return;
}


int[,] matrixA = CreateRandomArray(m, n);         // получаем рандомный массив с размерами m и n
Console.WriteLine("Матрица A: ");
Print2DArray(matrixA);                            // печатаем массив для наглядности
Console.WriteLine();

int[,] matrixB = CreateRandomArray(m, n);         // получаем рандомный массив с размерами m и n
Console.WriteLine("Матрица B: ");
Print2DArray(matrixB);                            // печатаем массив для наглядности
Console.WriteLine();

void Print2DArray(int[,] array)                   // метод печать массива
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

int[,] CreateRandomArray(int m, int n)             // метод создания рандомного массива
{
    int[,] array = new int[m, n];

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);         //задаем массив от 0 до 9
        }
    }

    return array;
}

int[,] resultMatrix = new int[m, n];                 // массив результата перемножения
MultiplyMatrix(matrixA, matrixB, resultMatrix);      // вызываем метод перемножения


int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                result += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = result;
        }
    }
    return resultMatrix;                            // возвращаем результат перемножения
}

Console.WriteLine("Результат перемножения А * В:");
Print2DArray(resultMatrix);
