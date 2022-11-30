// На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1; 

while (i < n)
{
    if (i % 2 != 1)
    {
        Console.Write(i + " ");
    }
    i++;
}


