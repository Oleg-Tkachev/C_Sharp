
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
// if (numberA == numberB) // добавил строчку если числа равны. (+ к карме, т.к. в задании этого нет)
//    {
//        Console.Write(" Числа равны");
//    }