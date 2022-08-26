
/* Программа на вход принимает два числа и проверяет, 
является ли первое число квадратом второго 
a = 25, b = 5 => yes
a = 2, b = 10 => no
a = 9, b = -3 => yes
a = -3, b = 9 => no
*/

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(System.Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int b = Convert.ToInt32(System.Console.ReadLine());

if (b * b == a)
    {
    Console.WriteLine("yes");
    }
if (b * b != a)
    {
    Console.WriteLine("no");
    }


///////////////////////////////////////////////////
/* Напишите программу, которая будет выдавать 
название дня недели по заданному номеру
3 => среда
5=> пятница
*/

Console.WriteLine("Введите цифру, согласно дню недели: ");
int day = Convert.ToInt32(System.Console.ReadLine());

if (day !=1 && day !=2 && day !=3 && day !=4 && day !=5 && day !=6 && day !=7) //проверка на корректность ввода
{
    Console.WriteLine("Некооректный ввод"); 
}
switch (day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
}



//////////////////////////////////////////////////////////
/* Напишите программу, которая на вход принимает число N и 
на выходе показывает все целые числа от -N до N 
4 => ("-4, -3, -2, -1, 0, 1, 2, 3, 4") 
3 => ("-3, -2, -1, 0, 1, 2, 3")
*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
    {
    Console.WriteLine("Некооректный ввод");
    }
for (int i = (-1 * num); i <= num; i++)     //цикл (Start -N) (Stop = N) (Step = 1) 
    Console.Write(i);



//////////////////////////////////////////////////////////
/* Программа, которая на вход принимает трехзначное число 
и на выходе показывает последнюю цифру этого числа
456 => 6
782 => 2
*/

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0 || num < 100 || num > 999)   // проверка на корректный ввод
{
    Console.WriteLine("Некорректный ввод");
}
else
{
int lastDigi = num % 10;      // последняя цифра примет 135 % 10 = 13,5 ==> остаток 5
Console.WriteLine(lastDigi);
}