// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void MassRegulation()
{
    Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

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
    
Console.WriteLine();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                if (arrRandom[i, j] <= arrRandom[i, k]) continue;
                int temp = arrRandom[i, j];
                arrRandom[i, j] = arrRandom[i, k];
                arrRandom[i, k] = temp;
            }
        }
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            Console.Write($"{arrRandom[i, j]} ");
        }
        Console.WriteLine();
    }
}

MassRegulation();