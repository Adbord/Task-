// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for(int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for(int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {matrixResult[i,j] += matrix1[i,k] * matrix2[k, j];}
        }
    }

    return matrixResult;
}

int[,] FillArray(int m = 4, int n = 4)
{
    int[,] array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {Console.Write("{0,4}", array[i, j]);}
        Console.WriteLine();
    }
}

int[,] myMatrix1 = FillArray();
PrintArray(myMatrix1);
Console.WriteLine();

int[,] myMatrix2 = FillArray();
PrintArray(myMatrix2);
Console.WriteLine();

int[,] newMatrixResult = MatrixMultiply(myMatrix1, myMatrix2);
PrintArray(newMatrixResult);