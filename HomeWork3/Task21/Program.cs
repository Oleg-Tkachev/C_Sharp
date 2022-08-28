
/* 
Программа, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/



Console.WriteLine("Введите координату х первой точки: ");
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int x1);    // ввод данных + проверка на цифровой ввод

Console.WriteLine("Введите координату у первой точки: ");
bool isNumberY1 = int.TryParse(Console.ReadLine(), out int y1);    // ввод данных + проверка на цифровой ввод

Console.WriteLine("Введите координату z первой точки: ");
bool isNumberZ1 = int.TryParse(Console.ReadLine(), out int z1);    // ввод данных + проверка на цифровой ввод

Console.WriteLine("Введите координату x второй точки: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int x2);

Console.WriteLine("Введите координату y второй точки: ");
bool isNumberY2 = int.TryParse(Console.ReadLine(), out int y2);

Console.WriteLine("Введите координату z второй точки: ");
bool isNumberZ2 = int.TryParse(Console.ReadLine(), out int z2);

if (!isNumberX1 || !isNumberX2 || !isNumberY1 || !isNumberY2 || !isNumberZ1 || !isNumberZ2) 
{
    Console.WriteLine("Числа введены неверно");                    
    return;
}


double GetLenght(int x1, int y1, int z1, int x2, int y2, int z2)            // метод получаем длину отрезка в 3D
    {    
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    }

Console.WriteLine($"расстояние: {GetLenght(x1, y1, z1, x2, y2, z2)}");