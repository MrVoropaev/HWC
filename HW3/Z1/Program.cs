// Принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length == 5)
{
    if (numberText[0] == numberText[4] && numberText[1] == numberText[3])
    {
        Console.WriteLine("Это полиндром");
    }
    else
    {
        Console.WriteLine("Это не полиндром");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число");
}
