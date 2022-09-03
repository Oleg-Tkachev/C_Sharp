// Цикл в цикле 
// В данном случае таблица умножения


for (int i = 2; i < 10; i++)
{
    Console.WriteLine();                  // Вывод пустой строки
    for (int j = 2; j <= 10; j++)
    {
        int res = i * j;
        Console.WriteLine($"{i} x {j} = {res}");    // Интерполяция строк
    }
}