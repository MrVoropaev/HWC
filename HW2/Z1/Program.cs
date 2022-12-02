//Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length == 3)
{
  Console.WriteLine("Вторая цифра:  " + numberText[1]);
}
else 
{ 
    Console.WriteLine("Число не трехзначное");
}