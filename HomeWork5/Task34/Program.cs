
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


int[] array = RandomArrey(length);           // передаем длину массива lenght в метод Random


int[] RandomArrey(int len)                  // метод по генерации рандомных чисел от 100 до 999
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i <= length; i++)
    {
        array[i] = random.Next(100, 1000);  // случайные числа от 100 до 999
        Console.Write($"/{array[i]}/");
    }
    return array;
}

//int num = EventNumbers(RandomArrey);
//Console.WriteLine(num);




//int  EventNumbers (int [] arrey);   //передаем рандомный массив в метод подсчета положительных чисел


void EventNumbers(int RandomArrey)     // метод подсчета положительных чисел
{
    int count = 0;
    int len = 4;
    for (int i = 0; i <= len; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    Console.WriteLine(count);
    }
}


