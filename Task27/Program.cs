﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
string number = Console.ReadLine();

int sum = 0;

foreach (var item in number)
{
    sum += Convert.ToInt32(item.ToString());452
    
}

Console.WriteLine(sum);