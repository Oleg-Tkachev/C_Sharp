
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



/* 
Программа, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/////////////////////////////// Второй вариант \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

using static System.Console;
int N = InputNumber("Введите целое число: ");
if (N != 0)
{
    int n = N < 0 ? Math.Abs(N) + 2 : N;
    int[] arrey = new int[n];
    arrey = GetCub(N, n);
    WriteArrey("Кубы от 1 до "+Convert.ToString(N)+": ", arrey, n);
}
else { Write(N); }
WriteLine();

void WriteArrey(string text, int[] arrey, int n)
{
    Write(text);
    Write(arrey[0]);
    for (int i = 1; i < n; i++)
    {
        Write($", {arrey[i]}");
    }
}

int InputNumber(string text)
{
    bool isNumber = false; int x = 0;
    while (!isNumber)
    {
        Write(text);
        isNumber = int.TryParse(ReadLine(), out x);
        if (!isNumber) { WriteLine("Это не число"); }
    }
    return x;
}

int[] GetCub(int N, int n)
{
    int[] arrey = new int[n];
    for (int i = 1; i < n + 1; i++)
    {
        arrey[i - 1] = N < 0 ? (int)Math.Pow(2 - i, 3) : i * i * i;
    }
    return arrey;
}