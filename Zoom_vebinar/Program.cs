Random random = new Random();
//Для генерации рандомных чисел
int randomNumber = random.Next (10,100); 

Console.WriteLine(randomNumber);

int lastNumber = randomNumber % 10;
int firstNumber = randomNumber / 10;

if(lastNumber > firstNumber)
{
    Console.WriteLine($"Максимальное число равно {lastNumber}"); // интерполяция
}
else{
    Console.WriteLine("Максимальное число равно " + firstNumber);
}


Random random = new Random();
// Для генерации рандомных чисел
int randomNumber = random.Next(100,1000); 

Console.WriteLine(randomNumber);

int firstNumber = randomNumber / 100 * 10 ;
int lastNumber =  randomNumber % 10;
int number = firstNumber + lastNumber;

Console.WriteLine(number);


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int mod = a % b;
if (mod == 0) 
{
    Console.WriteLine("кратно");
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {mod}");
}



int a = Convert.ToInt32(Console.ReadLine());
if(a % 7 == 0 && a % 23 == 0)
{
Console.Write ("кратно" );
}
else
{
Console.Write ("не кратно" );
}


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b*b == a)
{
    Console.Write ("Является" );
}
else 
{
    Console.Write ("Неявляется" );
}
