// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Работает на небольших числах, до 3-4, а дальше Stack overflow :(

Console.WriteLine("Введите число M (больше нуля):");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N (больше нуля):");
int numberN = Convert.ToInt32(Console.ReadLine());


int functionAckerman = Akkerman(numberM, numberN);
Console.Write($"Akkerman = {functionAckerman} ");

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0 && numberM > 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    else
    {
        return (Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)));
    }
}