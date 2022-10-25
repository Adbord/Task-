// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int rows = ReadInt("Введите число строки: ");
int columns = ReadInt("Введите число столбца: ");
int[,] numbers = new int[5, 5];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) Console.WriteLine(numbers[rows, columns]);
else 
Console.WriteLine($"{rows}{columns} -> такого числа в массиве нет");


void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)  // 0 - rows 0
    {
        for (int j = 0; j < array.GetLength(1); j++) // columns - 1
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}