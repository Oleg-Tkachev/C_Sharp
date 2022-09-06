
/*
Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 ==> (-0,5; -0,5)
*/

Console.WriteLine("Программа найдёт точку пересечения двух прямых");

Console.Write("Please enter b1: ");
bool isNumberB1 = double.TryParse(Console.ReadLine(), out double b1);

Console.Write("Please enter k1: ");
bool isNumberK1 = double.TryParse(Console.ReadLine(), out double k1);

Console.Write("Please enter b2: ");
bool isNumberB2 = double.TryParse(Console.ReadLine(), out double b2);

Console.Write("Please enter k2: ");
bool isNumberK2 = double.TryParse(Console.ReadLine(), out double k2);

if (!isNumberB1 || !isNumberB2 || !isNumberK1 || !isNumberK2)
{
    Console.WriteLine("Некорректный ввод данных");
    return;
}

DotСrossingsLines(b1, k1, b2, k2);                // Вызов метода 

void DotСrossingsLines(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))
        {
            Console.WriteLine("Прямые совпадают");
            return;
        }
    if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны");
            return;
        }

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1; 
    Console.WriteLine($"Прямые пересекутся в точке с координатами X: {x}; Y: {y}");
}
