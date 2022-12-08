// Задаёт массив из 8 элементов и выводит их на экран

int lenArray = ReadInt("Введите число: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new lenArray();
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


