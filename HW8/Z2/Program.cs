// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void SummMin()
{
    Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine();
    int[,] arrRandom = new int[m, n];


    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrRandom[i, j] = new Random().Next(1, 10);
            Console.Write($"{arrRandom[i, j]} ");
        }
        Console.WriteLine();
    }

    int summ = 0;
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        summ = 0;

        for (int j = 0; j < n; j++)
        {
            summ += arrRandom[i, j];
        }
        arr[i] = summ;
    }
    Console.WriteLine();

    int count = 0;
    int min = arr[0];
    for (int i = 1; i < m; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            count = i;
        }
    }
    Console.WriteLine($"наименьшая сумма в строке {count}");

}
SummMin();