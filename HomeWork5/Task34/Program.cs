
/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);  //получаем длину массива
if (!isNumber || length <= 0)
{
    Console.WriteLine("Некорректный ввод");                        //проверяем 
    return;
}

int[] array = RandomArrey(length);          // передаем длину массива lenght в метод Random
EventNumbers(array);                        //передаем рандомный массив в метод подсчета положительных чисел

int[] RandomArrey(int len)                  // метод по генерации рандомных чисел от 100 до 999
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)        // цикл заполняем массив
    {
        array[i] = random.Next(100, 1000);  // случайные числа от 100 до 999
    }
    return array;
}

void EventNumbers(int[] random)             // метод подсчета положительных чисел
{
    int count = 0;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
        Console.Write($" {array[i]}");             
    }                                                                     // Введите длину массива:
    Console.Write(" ]");                                                  // 7
    Console.WriteLine();                                                  // [ 753 124 749 239 962 999 903 ] Запятые так и не сделал((
    Console.WriteLine($"Количество чётных чисел в массиве  = {count}");   // Количество чётных чисел в массиве  = 2
}