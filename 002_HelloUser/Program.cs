Console.Write("Введите ваше имя:");
string username = Console.ReadLine();
Console.Write("Введите ваш возраст:");
string userold = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);
Console.Write(" тебе, ");
Console.Write(userold);
Console.Write(" года");




Console.WriteLine("Введите число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);  // Проверка на ввод цифр
if (!isNumber)                                                     // Данные записаны в переменнную number
{ 
    Console.WriteLine("Некорректный ввод данных");
    return;
}
// Если проверка не прошла (!isNumber) программа остановится и выводит ("Некорректный ввод данных")


///////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\//////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\


int number = Convert.ToInt32(Console.ReadLine());  // ввод данных с консоли и конвертация их в ToInt32 


///////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\//////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\


string text = number.ToString();           // для работы число number переводим в текст

///////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\//////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\

int[] array = new int[num];                 // новый массив длиной num 

Console.WriteLine($"Результат: {result}"); // вывод в консоль метод интерполяция



///////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\//////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\

int[] array = new int[length];         // новый массив длиной num 
Random random = new Random();          //  рандомные числа 
array[i] = random.Next(100, 1000);     //  заполнение массива от 100 до 999