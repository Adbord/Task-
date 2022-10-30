// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int num1 = InputInt("Введите размерность 1: ");
int num2 = InputInt("Введите размерность 2: ");
int num3 = InputInt("Введите размерность 3: ");
int countNumbers = 89;

if (num1 * num2 * num3 > countNumbers)
{
    Console.Write("Массив слишком велик");
    return;
}

int[,,] resultNumbers = Create3DArray(num1, num2, num3);

for (int i = 0; i < resultNumbers.GetLength(0); i++)
{
    for (int j = 0; j < resultNumbers.GetLength(1); j++)
    {
        for (int k = 0; k < resultNumbers.GetLength(2); k++)
        {
            Console.WriteLine($"[ {i},{j},{k} ] - {resultNumbers[i, j, k]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNumbers];
    int num = 9;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}