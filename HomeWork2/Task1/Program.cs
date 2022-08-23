
void SecondDig(int number)
{
    int num = (number / 10) % 10;
    Console.WriteLine(num);
}


Console.WriteLine("Please enret number 100 - 999");
int number = Convert.ToInt32(Console.ReadLine());
SecondDig(number);