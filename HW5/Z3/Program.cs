// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76 - это как? Должно быть 75.
// Из задачи не ясно какая должна быть длинна массива. Сколько должно быть элементов. Я приму длинну в 10 элементов.

//int size = 10;

// Если необходимо задать длинну массива с клавиатуры пользователем, то стоит использовать:

// Console.Write("Введите количество элементов: ");
// int size = int.Parse(Console.ReadLine());

double[] myArray = new double[10];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(-10, 10);
        Console.Write(myArray[i] + " ");
}

double max = myArray[0];
double min = myArray[0];
for (int i = 1; i < myArray.Length; i++)
{
    if (max < myArray[i])
    {
    max = myArray[i];
    }
        if (min > myArray[i])
    {
    min = myArray[i];
    }
}
double decision = max - min;
Console.WriteLine($"Разница между между максимальным ({max}) и минимальным({min}) элементами: {decision}");
