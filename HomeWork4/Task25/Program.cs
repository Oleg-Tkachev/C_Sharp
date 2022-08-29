
/*
Напишите цикл программы, которая принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В
3, 5 ==> 243
2, 4 ==> 16
*/


Console.WriteLine("Введите число A:");
double numberA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число B (степень):");
double numberB = Convert.ToDouble(Console.ReadLine());
if (numberB == 0)
{
    Console.WriteLine("Любое число в степени ^0 = 1");
    return;
}

double GetExpondouble(double numberA, double numberB)
{
  double result = 1;
  for(double i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

double result = GetExpondouble(numberA, numberB);
Console.WriteLine($"Результат: {result}");
