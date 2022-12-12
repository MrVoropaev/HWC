// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Из задачи не ясно какая должна быть длинна массива. Сколько должно быть элементов. Я приму длинну в 10 элементов.

//int size = 10;

// Если необходимо задать длинну массива с клавиатуры пользователем, то стоит использовать:

// Console.Write("Введите количество элементов: ");
// int size = int.Parse(Console.ReadLine());

int[] myArray(int size =10)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

//SumValueOfItems - функция подсчёта суммы элементов на нечётных позициях
int SumItems(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if ((i + 1) % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] arrayOfDigits = myArray();

Console.WriteLine("[" + string.Join(", ", arrayOfDigits) + "]");
Console.WriteLine("Сумма элементов на нечётных позициях = " + SumItems(arrayOfDigits));
