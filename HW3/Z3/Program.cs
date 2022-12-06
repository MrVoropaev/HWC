// Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

/*Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= number)
{
    if (i != 1)
    {
        Console.Write(i*i*i + " ");
    }
    i++;
} */

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введи число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i*i*i} ");
}

