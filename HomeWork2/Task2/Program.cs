
int number = 21830690;
string text = number.ToString();
if (text.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(text[2]);
}
Console.WriteLine(text);
