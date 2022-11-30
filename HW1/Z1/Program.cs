//На вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} больше {number2}");
}
else
{
    Console.WriteLine($"{number2} больше {number1}");
}
