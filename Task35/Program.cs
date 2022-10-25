﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массив, значения которых лежат в
// отрезке[10, 99]
// Пример для массива из 5, ф не 123 элементов. В своем решении сделайте для
// 123
// [5, 18, 123, 6 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5




int[] CreateArrayRndIt(int size, int min, int max)
{
  int[] array = new int[size];
  var rnd = new Random();
  for (int i = 0; i < size; i++)
  {
    array[i] = rnd.Next(min, max + 1);
  }
  return array;
}

void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  { 
    if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
  }
  Console.WriteLine("]");
}

int CountOfDeca(int[] array)
{
  int result = default;
  for (int i = 0; i < array.Length; i++)
{ 
  if (array[i] >= 10 && array[i] <= 99) result++;
}
return result;
}


int[] arr = CreateArrayRndIt(10, 1, 150);
PrintArray(arr);
int resultMethod = CountOfDeca(arr);
Console.WriteLine($"В массиве {resultMethod} значений которые находятся в диапазоне от 10 до 99");