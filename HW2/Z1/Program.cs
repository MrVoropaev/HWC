﻿//Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
string input = Console.ReadLine();
Console.WriteLine("{0}->{1}",input, input[1]);