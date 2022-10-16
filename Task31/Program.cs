// Задача 31: 
// 1.Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [9, -9].
// 2.Найдите сумму отрицательных и положительных элементов массива.
// 3. Вывод результатов.

// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, 3, ] сумма 
//НОВЫЙ ТОМ 1положительных чисел равна 29, сумма отрицательных 
//Новая папка -20.

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
    if(i < array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
  }
  Console.WriteLine("]");
}

int[] GetSumPositiveNegativeElem (int[] array)
{
    int sumPositive = default;
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
      if(array[i] < 0) sumNegative += array[i];
      else sumPositive += array[i];
    }

    return new int[]{sumPositive, sumNegative};
}

int GetSumPositiveElem(int[] array)
{
    int sumPositive = default;
    
    for (int i = 0; i < array.Length; i++) 
        if(array[i] > 0) sumPositive += array[i];

      return sumPositive;
    }

int GetSumNeagativeElem(int[] array)
{
    int sumNegative = default;
    
    for (int i = 0; i < array.Length; i++) 
        if(array[i] < 0) sumNegative += array[i];

      return sumNegative;
    }

int[] arr = CreateArrayRndIt(10, -9, 9);
PrintArray(arr);
int sumPositive = GetSumPositiveElem(arr);
int sumNegative = GetSumNeagativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");

//int[] sumPositiveNegative = GetSumPositiveNegativeElem(arr);
//Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegative[0]}");
//Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegative[1]}");