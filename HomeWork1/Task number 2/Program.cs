
Console.WriteLine("Please enter first number");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Plese enter second number ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter third number");
int numberC = Convert.ToInt32(Console.ReadLine());

int bigNum = numberA;

if (numberB > bigNum)
    {
    bigNum = numberB;
    }
if (numberC > bigNum)
    {
    bigNum = numberC;;
    }
Console.WriteLine("Максимальное число из: {0}, {1}, {2}, является {3}", numberA, numberB, numberC, bigNum);
