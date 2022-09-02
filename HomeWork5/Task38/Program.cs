/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);  //получаем длину массива
if (!isNumber || length <= 0)
{
    Console.WriteLine("Некорректный ввод");                        //проверяем 
    return;
}

int[] array = RandomArrey(length);              // передаем длину массива lenght в метод Random

int[] RandomArrey(int len)                      // метод по генерации рандомных чисел от 100 до 999
{
    Console.Write("[ ");
    int[] array = new int[length];
    for (int i = 0; i < length; i++)              // цикл заполняем массив
    {
        array[i] = new Random().Next(-100, 101);  // случайные числа от -100 до 100
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    return array;
}

int maxNumber = array[0];
int minNumber = array[0];
GetMaX_Min_Numbers(array);

void GetMaX_Min_Numbers(int[] number)      //метод выводит maxNumber, minNumber 
{
  for (int i = 1; i < array.Length; i++)
    {
      if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
      if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }
}

int result = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine($"Разница между между максимальным [{maxNumber}] и минимальным [{minNumber}] элементами = [{result}]");
Console.WriteLine();