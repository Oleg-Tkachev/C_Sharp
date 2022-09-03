
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 17;
int b1 = 34;
int c1 = 25;
int a2 = 32;
int b2 = 33;
int c2 = 43;
int a3 = 28;
int b3 = 22;
int c3 = 132;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);


Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);
Console.WriteLine(max);

////////////////////////////////////////////////////////////

// Метод не принемает аргументов и не возвращает (void)

void Method1()
{
    Console.WriteLine("вывод текста в консоль");
}

Method1();  // Вызов этого метода. 




///////////////////////////////////////////////////////////
// Метод принемает аргументs но не возвращает (void)
           // метод может принимать несколько значений!!!

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Привет С#"); // Вызов этого метода + передан текст.

//***********************************************************\\

void Method21(int lan, string txt)        //void метод ничего не возвращает
{
    Console.WriteLine($"{lan} + {txt}");  // интерполяция вывод нескольких элементов int & string
}

Method21(lan: 15, txt: "text");   // вызов метода + передача агрументов с указанием 
Method21(15, "text");             // вызов метода + передача агрументов 




///////////////////////////////////////////////////////////
// Метод могут что-то возвращать, но не принемают ( как пример: генерация каких-то данных)

int Method3()
{
  return DateTime.Now.Hour;  // Генерация текущего часа  \\||// return DateTime.Now.Year; - текущий год
}

int year = Method3();      // В переменную year ложим значение из retutn 
Console.WriteLine(year);   // Вывод в консоль






////////////////////////////////////////////////////////////////////////////////////////
// Метод что-то принемает (аргументы) и что-то возвращает для работы далее


string Method4(int count, string z)
{
  int i = 0;
  string resalt = String.Empty;     // Создана переменная String result с пустым значением

  while (i < count)                 // Цикл с условием True 
    {
        resalt = resalt + z;
        i++;                         // Оперци дикремент
    }
  return resalt;
}

string txt = Method4(7, "Привет С# ");  // вызов метода + передача агрументов с указанием 
Console.WriteLine(txt);                 // Вывод в консоль






