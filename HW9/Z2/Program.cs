// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// "В промежутке" - это значит мы учитываем эти элементы или нет? Если да, то код ниже. Если нет - то закоментированный код.

Console.WriteLine("Введите число M (больше нуля):");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N (больше нуля):");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumBetween(int numberM, int numberN)
{
    if (numberM <= numberN) return numberM + SumBetween(numberM + 1, numberN);
    else return 0;
}
Console.WriteLine(SumBetween(numberM, numberN));

/*Console.WriteLine("Введите число M (больше нуля):");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N (больше нуля):");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumBetween(int numberM, int numberN)
{
    if (numberM < numberN) return (numberM + 1) + SumBetween(numberM + 1, numberN);
    else return 0;
}
Console.WriteLine(SumBetween(numberM, numberN - 1));*/