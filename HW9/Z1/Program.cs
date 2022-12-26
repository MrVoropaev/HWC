// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


Console.WriteLine("Введите число (больше нуля):");
int number = Convert.ToInt32(Console.ReadLine());
string NumbersTo(int number)
{
    if (number == 1) return "1";
    return $"{number}, {NumbersTo(number - 1)}";
}
Console.WriteLine(NumbersTo(number));