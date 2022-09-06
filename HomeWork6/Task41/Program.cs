/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 ==> 2
1, -7, 567, 89, 223 ==> 3
*/

Console.WriteLine("Программа считает сколько положительных чисел введено в массив");
Console.WriteLine("Введите длину элементов массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int len);
if (!isNumber || len <= 0)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}


BuildArray(len);

void BuildArray(int len)
{
    int[] nums = new int[len];
    int i = 0;
    int count = 0;
    while (i < len)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");  // +1 для понимания ввода
        nums[i] = Convert.ToInt32(Console.ReadLine());
        if (nums[i] > 0) count = count + 1;
        i++;
    }
    Console.Write("Введен массив: ");            //вывод на экран массива
    Console.Write("[");
    for (i = 0; i < len; i = i + 1)
        Console.Write($" {nums[i]}");
    Console.Write(" ]");
    Console.WriteLine();
    Console.WriteLine($"Количество чисел больше нуля: {count}");
}


// int CheckPositivNum(int [] array)
// {
//     int count = 0;
//     int i = 0;
//     while (i > array.Length)
//     {
//         if (array[i] > 0) count = count+1;
//         Console.WriteLine(count);
//         i++;
//         Console.WriteLine(i);
//     }
//     Console.WriteLine(count);
//     return count;
// }

