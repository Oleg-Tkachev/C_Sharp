/* 
Программа, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. (зеркально)
14212 -> нет
12821 -> да
23432 -> да
*/


bool ChekPalindrom(int number)
{
string text = number.ToString();
        if (text.Length == 5 && text[0] == text[4] && text[1] == text[3])
        {
        return true;
        }
        else
        {
        return false;
        }
    
}

Console.WriteLine("please enter a five-digit number");
int number = Convert.ToInt32(Console.ReadLine());
bool result = ChekPalindrom(number);
Console.WriteLine(result); 



// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3])
//   {
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");