// Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введи номер дня: ");
int day = Convert.ToInt32(Console.ReadLine());

void DayWeekend(int day)
{
    if (day == 6 || day ==7 )
    {
        Console.WriteLine("Это выходной");
    }
    else if (day <1 || day > 7)
    {
        Console.WriteLine("Это не день");
    }
    else
    {
        Console.WriteLine("Это будни");
    }
}

DayWeekend(day);


