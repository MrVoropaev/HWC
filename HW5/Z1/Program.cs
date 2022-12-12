// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Из задачи не ясно какая должна быть длинна массива. Сколько должно быть элементов. Я приму длинну в 10 элементов.

int size = 10;

// Если необходимо задать длинну массива с клавиатуры пользователем, то стоит использовать:

// Console.Write("Введите количество элементов: ");
// int size = int.Parse(Console.ReadLine());

int[] myArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int evenNumbered = 0;
    int notEvenNumbered = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) evenNumbered++;
        else notEvenNumbered++;
    }
    Console.WriteLine($"Количество четных элементов {evenNumbered}");
}

PrintResult(myArray(size));


