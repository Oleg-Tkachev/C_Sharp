
/* 
Программа, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("please enter number");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);  // ввод данных + проверка на цифровой ввод

if (isNumber != true || num <= 0)
{
    Console.WriteLine("Некорректный ввод.");
    return;                                             // return, если введен символ и отрицательное число
}

int[] GetExponent(int num)                              // метод, получаем куб числа.
{
    int[] array = new int[num];
    for (int i = 1; i <= num; i++)                      // реализовал чере цикл for while был на семинаре, эксперемент)
    {
        array[i - 1] = (int) Math.Pow(i, 3);
    }
    return array;
}

void PrintArray(int[] exponent)                         
{
    for (int i = 0; i < exponent.Length; i++)          // реализовал чере цикл for while был на семинаре, эксперемент)
    {
        Console.Write($" {exponent[i]}");
    }
}

PrintArray(GetExponent(num));