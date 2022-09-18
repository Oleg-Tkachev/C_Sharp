

/*
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите значение M: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите значение N: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || !isNumberM || m > n)
{
    Console.WriteLine("Некорректный ввод");
    return;
}


int sum = 0;
PrintSum(m, n, sum);


void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {sum}");
        return;
    }
    PrintSum(m, n - 1, sum);
}
