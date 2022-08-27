
void Findnum3(int num)
{
    int number = num;
    string text = number.ToString();
    if (text.Length < 3)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        Console.WriteLine(text[2]);
    }
}

Console.WriteLine("Please enter any numbers");
int num = Convert.ToInt32(Console.ReadLine());
Findnum3(num);


