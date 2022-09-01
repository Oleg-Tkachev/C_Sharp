
/*
Программа, которая задает массив из элементов и
выводит их на экран. 
1,2,5,7,19 ==> [1,2,5,7,19]
6,1,33 ==> [6,1,33]
*/
// Программа принимает ряд чисел выдает массив

Console.WriteLine("Введите ряд чисел через пробел или разделенных запятой: ");
string array = Console.ReadLine();

string RemoveSpase (string arrey)  // метод удаления запятых и пробелов
{
  string result = String.Empty;
  string text = arrey;
    for (int i = 0; i < text.Length; i++)
  {
    if (text[i] == ',' || text[i] == ' ') result = result + $"{""}";
    else result = result + $"{text[i]}";
  }
  return result;
}

string BildArray( string arrey)   // метод из числа к примеру 3456 выводит [3, 4, 5, 6]
{ 
    for (int i = 0; i < 1; i++)
    {
        Console.Write("[" + arrey[0]);
        for (int j = 1; j < arrey.Length; j++)
        {
            Console.Write(", " + arrey[j]);
        }   
      Console.Write("]");
      break;
    } 
return array;
}

string res2 = BildArray (RemoveSpase(array));





