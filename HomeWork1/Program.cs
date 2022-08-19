
Console.WriteLine("Please enter first number");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
    {
        Console.Write("Максимальное число: ");
        Console.Write(numberA);
    }
else 
    {
        Console.Write("Максимальное число: ");
        Console.Write(numberB);
    }