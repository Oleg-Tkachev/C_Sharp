



// Console.WriteLine("Введите x");
// bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

// Console.WriteLine("Введите y");
// bool isNumberY= int.TryParse(Console.ReadLine(), out int y);

// if(isNumberX != true || isNumberY != true)
// {
//     Console.WriteLine("Числа введены не верно.");
//     return;
// }

// bool isValid = Validate(x,y);
// if(isValid == false)
// {
//  Console.WriteLine("Како-то число равно нулю");
//  return;
// }

// int result = GetPosition(x,y);
// Console.WriteLine(result);

// bool Validate(int x, int y)
// {
//     if(x == 0 || y == 0)
//     {
//         return false;
//     }
//     return true;
// }

// int GetPosition(int x, int y)
// {
//     if(x>0 && y>0)
//     {
//         return 1;
//     }

//     if(x < 0 && y > 0)
//     {
//         return 2;
//     }

//     if(x < 0 && y < 0)
//     {
//         return 3;
//     }

//     if(x > 0 && y < 0)
//     {
//         return 4;
//     }

//     return -1;
// }


// Console.WriteLine("Введите номер четверти");
// int position = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine(GetPositio(position));

// string GetPositio(int position)

// {
//     if (position == 1)
//     {

//         return "x > 0, y > 0";
//     }

//     if (position == 2)
//     {
//         return "x > 0, y < 0";
//     }
//     if (position == 3)
//     {
//         return "x < 0, y < 0";
//     }
//     if (position == 4)
//     {
//         return "x > 0, y < 0";
//     }
//     return " Неверная цифра";
// }




System.Console.WriteLine("Введите координату х первой точки: ");
bool isNumberX_1 = int.TryParse(Console.ReadLine(),out int x1);

System.Console.WriteLine("Введите координату у первой точки: ");
bool isNumberY_1 = int.TryParse(Console.ReadLine(),out int y1);

System.Console.WriteLine("Введите координату х второй точки: ");
bool isNumberX_2 = int.TryParse(Console.ReadLine(),out int x2);

System.Console.WriteLine("Введите координату у второй точки: ");
bool isNumberY_2 = int.TryParse(Console.ReadLine(),out int y2);

if (!isNumberX_1|| !isNumberX_2 || !isNumberY_1 || !isNumberY_2) 
{
    Console.WriteLine("Числа введены неверно");
    return;
}
System.Console.WriteLine($"расстояние: {GetLenght(x1, y1, x2, y2)}");
double GetLenght(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 -x1), 2) + Math.Pow((x2 - y2), 2));
}


Console.WriteLine("\n Задача 23");
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);