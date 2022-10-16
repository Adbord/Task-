// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInd(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max);
    return array;
}

int[] array = CreateArrayRndInd(5, -100, 101);

int sizeSum = 0;
for (int i = 1; i < array.Length; i += 2)
    sizeSum += array[i];
        

Console.Write("[");
for (int a = 0; a < array.Length; a++)
{
    if(a < array.Length - 1)
        Console.Write($"{array[a]}, ");
    else
        Console.Write($"{array[a]}");
}
Console.WriteLine($"] -> Сумма чисел (на нечётных позициях) составляет: {sizeSum}");
