
Console.WriteLine("Please enter namber");
int number = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<= number; i++) // Программа не работает если ввести число с "-" 
if (i % 2 == 0)
{
   Console.WriteLine(i); 
}

