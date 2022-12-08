//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите степень: ");
double degree = Convert.ToDouble(Console.ReadLine());

double step = number;

for (double i = 1; i < degree; i++)
{
    step = step * number;
}
Console.WriteLine($"Число {number} в степени {degree} равно: " + step);

