// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

void FillArrayRandomNumbers(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 -rows 0
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // 1 - columns
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-99, 99)) / 10;
        }
    }
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

