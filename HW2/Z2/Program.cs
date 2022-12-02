//Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine("Цифра номер три это:  " + numberText[2]);
}
else 
{ 
    Console.WriteLine("Третьей цифры нет.");
}
