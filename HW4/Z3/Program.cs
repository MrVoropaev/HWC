// Задаёт массив из 8 элементов и выводит их на экран
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] - тут не 8 цифр?!
//6, 1, 33 -> [6, 1, 33] - тут не 8 цифр?!


// Для 8 цифр:

int Array = 8;

Console.WriteLine("Введите 8 чисел ");

int[] myArray = new int[Array];
for (int i = 0; i < Array; i++)

myArray[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.Write("[");
for (int i = 0; i < Array; i++)
{
    Console.Write(myArray[i] + ", ");
}

Console.WriteLine(myArray[Array -1] + "]");

//Для произвольного колличества код другой