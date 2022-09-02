/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);  //получаем длину массива
if (!isNumber || length <= 0)
{
    Console.WriteLine("Некорректный ввод");                        //проверяем 
    return;
}

int[] array = RandomArrey(length);          // передаем длину массива lenght в метод RandomArrrey
SumOddNumbers(array);                       //передаем рандомный массив в метод подсчета суммы по нечет.индексам

int[] RandomArrey(int len)                  // метод по генерации рандомных чисел от -99 до 99
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)        // цикл заполняем массив
    {
        array[i] = random.Next(-99, 100);     // случайные числа от -99 до 99
    }
    return array;
}

void SumOddNumbers(int[] random)           // метод подсчета чисел нечет.индексов + вывод 
{
    Console.Write("[");
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
        Console.Write($" {array[i]}");
    }
  Console.Write(" ]");
  Console.WriteLine();
  Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях  = {sum}");
}
