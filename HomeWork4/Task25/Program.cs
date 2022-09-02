
/*
Напишите цикл программы, которая принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В
3, 5 ==> 243
2, 4 ==> 16
*/


Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B (степень):");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB == 0)  
{
    Console.WriteLine("Любое число в степени ^0 = 1");
    return;
}

if (numberA == 1)
{
    Console.WriteLine("1 в любой степени = 1");
    return;
}

int GetExponent (int numberA, int numberB) 
{
  int result = 1;
  for(int i=1; i <= numberB; i++)     // цикл, как понять цикл идет по numberA или numberB ???
  {                                   // путем экспериментов поставил i <= numberB
    result = result * numberA;
  }
  return result;
}

int result = GetExponent(numberA, numberB);
Console.WriteLine($"Результат: {result}");
  