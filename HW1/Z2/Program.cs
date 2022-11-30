// Принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maximalnumber = number1;

if (number2>maximalnumber)
{
    maximalnumber = number2;
}

if (number3>maximalnumber)
{
    maximalnumber = number3;
}

Console.WriteLine("Максимальное число:" + maximalnumber);


