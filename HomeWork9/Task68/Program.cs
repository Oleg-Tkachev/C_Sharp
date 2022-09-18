
/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/

Console.Write("Введите значение M: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите значение N: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || !isNumberM || m < 0 || n < 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}


int functionAkerman = Akerman(m, n);
Console.Write($"Функция Аккермана = {functionAkerman} ");


int Akerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akerman(m - 1, 1);
    }
    else
    {
        return (Akerman(m - 1, Akerman(m, n - 1)));
    }
}
