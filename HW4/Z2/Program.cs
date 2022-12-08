// Принимает на вход число и выдаёт сумму цифр в числе

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int sum = 0;
while (number > 0)
{
 
    sum = sum + number % 10;
    number = number / 10 ;
 
}
Console.WriteLine($"Сумма цифр числа равна " + sum);
