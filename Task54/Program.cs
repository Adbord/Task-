// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
//убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
//8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

            Console.WriteLine("Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            FillArrayRandomNumbers(matrix);
            Console.WriteLine();
            Console.WriteLine("Массив первоначальный ");
            PrintArray(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++) // 0 -rows 0
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)  // 1 - columns 1
                {
                    for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1]) 
                        {
                            int temp = 0;
                            temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив по убыванию");
            PrintArray(matrix);

            void FillArrayRandomNumbers(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = new Random().Next(0, 10);
                    }
                }
            }

            void PrintArray(int[,] matrix)
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