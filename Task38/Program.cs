// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5 7.1 22.9 2.3 78.5] -> 76.2



Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
CreateArrayRndInt(number);
Console.WriteLine("массив: ");
PrintArray(number);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int а = 0; а < number.Length; а++)
{
    if (number[а] > max)
      {
        max = number[а];
      }
    if (number[а] < min)
      {
        min = number[а];
      }
}

Console.WriteLine($"Максимальный {number.Length} элемент. MaxValue = {max}, MinValue = {min}");
Console.WriteLine($"Разница составляет -> {max - min}");

void CreateArrayRndInt(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
