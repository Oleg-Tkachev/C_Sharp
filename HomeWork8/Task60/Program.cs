/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/

Console.Write("Введите размер массива x: ");
bool isNumberx = int.TryParse(Console.ReadLine(), out int x);

Console.Write("Введите размер массива y: ");
bool isNumbery = int.TryParse(Console.ReadLine(), out int y);

Console.Write("Введите размер массива z: ");
bool isNumberz = int.TryParse(Console.ReadLine(), out int z);


if (!isNumberx || !isNumbery || !isNumberz)
{
    Console.WriteLine("Invalid number");
    return;
}


int[,,] array3D = new int[x, y, z];            // создаем массив

void Print3DArray(int[,,] array3D)             // метод печати в консоль + 1 цикл для 3D
{
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int [,,] FillArray(int x, int y, int z)
{
    int[] temp = new int[x * y * z];                // временная temp в нее будем генерировать цифры
    temp[0] = new Random().Next(10, 100);
    for (int i = 1; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (temp[i] == temp[j])               // условие, если цифры уже совпали
            {
                temp[i] = new Random().Next(10, 100);
                j = 0;
            }
        }
    }
    int count = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array3D[i, j, k] = temp[count];
                count++;
            }
        }
    } return array3D;
}   


Print3DArray(FillArray( x, y, z));   // на печать 
