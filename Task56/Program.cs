// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//  2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка



int[,] matrix = CreateArrayRandom(
rows: ReadInteger("Введите количество строк m = "),
columns: ReadInteger("Введите количество столбцов n = "),
minNumbers: -1,
maxNumbers: 99
);

int[] rowSum = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)  // 0 -rows 0
  for (int j = 0; j < matrix.GetLength(1); j++)   // 1 - columns 1
    rowSum[i] += matrix[i, j];

Console.WriteLine("Массив первоначальный:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
    Console.Write($"{matrix[i, j]} ");
  Console.WriteLine($"            |   sum = {rowSum[i]}");
}

int minSumRow = 0;
for (int i = 0; i < rowSum.Length; i++)
  if (rowSum[i] < rowSum[minSumRow])
    minSumRow = i;

Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов:");
for (int j = 0; j < matrix.GetLength(1); j++)
  Console.Write($"{matrix[minSumRow, j]} ");

int[,] CreateArrayRandom(int rows, int columns, int minNumbers, int maxNumbers)
{
  int[,] MyArr = new int[rows, columns];

  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      MyArr[i, j] = new Random().Next(minNumbers, maxNumbers + 1);

  return MyArr;
}

int ReadInteger(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}
